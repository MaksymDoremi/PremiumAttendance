using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public RFID()
        {
            bll = new BusinessLogicLayer();

            serialPort = new SerialPort(AutodetectArduinoPort(), 9600);
            OpenSerialPort();

        }

        /// <summary>
        /// Closes serial port
        /// </summary>
        public void CloseSerialPort()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Console.WriteLine("SERIAL PORT CLOSED");
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
                
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    Console.WriteLine("SERIAL PORT OPENED");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OpenSerialPort failed");
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }

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
                //Console.WriteLine("before INSERT TAG");
                //manualResetEvent.WaitOne();
                //Console.WriteLine("after INSERT TAG");
                rfid = null;

                try
                {
                    serialPort.DiscardInBuffer();
                    rfid = serialPort.ReadLine().Trim();


                    if (rfid != "" && rfid != null)
                    {
                        Console.WriteLine(rfid);

                        if (Program.markRfidAttendance)
                        {

                            bll.InsertAttendance(rfid);
                            Console.WriteLine("Attendance marked");
                        }
                        else
                        {
                            Console.WriteLine("RFID message box");
                            MessageBox.Show("RFID tag: " + rfid);
                            Console.WriteLine("After messagebox");

                        }

                    }
                }
                catch (InvalidOperationException ex)
                {
                    //CloseSerialPort();
                    Console.WriteLine("Serial port error");
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                    CloseSerialPort();
                    break;
                }
                catch(SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
