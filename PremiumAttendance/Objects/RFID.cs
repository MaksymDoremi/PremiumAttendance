using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PremiumAttendance.Objects
{
    public class RFID
    {
        public SerialPort serialPort;

        private BusinessLogicLayer bll;
        public ManualResetEvent manualResetEvent;
        private bool endgameToken;

        private readonly object _lock = new object();
        public RFID()
        {
            bll = new BusinessLogicLayer();

            serialPort = new SerialPort(AutodetectArduinoPort(), 9600);
            OpenSerialPort();
            this.manualResetEvent = new ManualResetEvent(true);
            ResetEndgameToken();
        }

        /// <summary>
        /// Sets endgame token to true
        /// </summary>
        public void SetEndgameToken()
        {
            lock (_lock)
            {
                this.endgameToken = true;
            }

        }

        /// <summary>
        /// Sets endgame token to false
        /// </summary>
        public void ResetEndgameToken()
        {
            lock (_lock)
            {
                this.endgameToken = false;
            }
        }

        /// <summary>
        /// Signals wait handle so the ReadTag can execute again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetEventWaitHandle(object sender, EventArgs e)
        {
            this.manualResetEvent.Set();
            Console.WriteLine("RELEASE THREAD");
        }

        /// <summary>
        /// Signals wait handle to wait
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ResetEventWaitHandle(object sender, EventArgs e)
        {
            this.manualResetEvent.Reset();
            Console.WriteLine("PAUSE THREAD");
        }

        /// <summary>
        /// Closes serial port
        /// </summary>
        public void CloseSerialPort()
        {
            try
            {
                if (serialPort != null)
                {
                    serialPort.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("CloseSerialPort failed");
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }

        }

        /// <summary>
        /// Opens serial port
        /// </summary>
        public void OpenSerialPort()
        {
            try
            {
                if (serialPort != null)
                {
                    serialPort.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OpenSerialPort failed");
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }

        }

        /// <summary>
        /// Shows RFID tag in message box
        /// Secondary RFID thread, works only in some exact forms: <see cref="PremiumAttendance.Forms.SubForms.CustomizeAccountForm">, <see cref="PremiumAttendance.Forms.SubForms.AddEmployeeForm">
        /// </summary>
        public void ReturnTag()
        {
            string rfid = "";


            do
            {
                Console.WriteLine("MESSAGE BOX TAG");
                System.Threading.Thread.Sleep(10);

                rfid = null;
                try
                {
                    rfid = serialPort.ReadLine().Trim();

                    if (rfid != "" && !endgameToken)
                    {
                        Console.WriteLine(rfid);
                        MessageBox.Show("RFID tag: " + rfid);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ReturnTag failed");
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                }
            } while (!endgameToken);

            Console.WriteLine("KILL MESSAGE BOX TAG");
        }

        /// <summary>
        /// Reads tag and inserts attendance to database
        /// Main RFID reading thread, has to work during the whole app execution
        /// </summary>
        public void ReadTag()
        {
            string rfid = "";
            bll = new BusinessLogicLayer();
            while (true)
            {

                //in case ReturnTag works it will wait here until it gets singal
                Console.WriteLine("before INSERT TAG");
                manualResetEvent.WaitOne();
                Console.WriteLine("after INSERT TAG");
                rfid = null;

                try
                {
                    rfid = serialPort.ReadLine().Trim();
                    

                    if (rfid != "" && rfid != null && manualResetEvent.WaitOne(0))
                    {
                        Console.WriteLine(rfid);

                        bll.InsertAttendance(rfid);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ReadTag failed");
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                }
                System.Threading.Thread.Sleep(3);

            }
        }

        /// <summary>
        /// Finds the COM port where the Arduino is connected
        /// </summary>
        /// <returns></returns>
        private string AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("Arduino") || desc.Contains("Sériové zařízení USB") || desc.Contains("Serial device USB"))
                    {
                        return deviceId;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("AutodetectArduinoPort failed");
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }

            return "";
        }
    }
}
