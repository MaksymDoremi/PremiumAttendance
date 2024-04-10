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

namespace PremiumAttendance.objects
{
    /// <summary>
    /// RFID module, used for reading RFID-tag
    /// </summary>
    public class RFID
    {
        private SerialPort serialPort;

        private BusinessLogicLayer bll;

        public RFID()
        {
            bll = new BusinessLogicLayer();

            serialPort = new SerialPort(AutodetectArduinoPort(), 9600);
            OpenSerialPort();

        }

        /// <summary>
        /// Closes <see cref="SerialPort"/>
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
        /// Opens <see cref="SerialPort"/>
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
        /// <para>Reads tag and inserts attendance to database</para>
        /// <para>Main RFID reading thread, has to work during the whole app execution</para>
        /// </summary>
        public void ReadTag()
        {
            string rfid = String.Empty;


            bll = new BusinessLogicLayer();
            while (true)
            {
                rfid = String.Empty;

                try
                {
                    serialPort.DiscardInBuffer();
                    rfid = serialPort.ReadLine().Trim();


                    if (rfid != "" && rfid != null)
                    {
                        Console.WriteLine(rfid);

                        //mark attendance
                        if (Program.markRfidAttendance)
                        {
                            bll.InsertAttendance(rfid);
                            Console.WriteLine("Attendance marked");
                        }
                        //show messagebox with RFID tag
                        else
                        {
                            Console.WriteLine("RFID message box");
                            MessageBox.Show("RFID tag: " + rfid);
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    //fatal error, need to stop execution
                    Console.WriteLine("Serial port error");
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                    CloseSerialPort();
                    break;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                }
                System.Threading.Thread.Sleep(3);
            }
        }

        /// <summary>
        /// <para>Finds the COM port where the Arduino is connected</para>
        /// <para>Selects all serial ports from Windows register and checks if it's Arduino</para>
        /// </summary>
        /// <returns>string of COM port</returns>
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
