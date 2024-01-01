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
    internal class RFID
    {
        public static SerialPort serialPort;


        private BusinessLogicLayer bll;
        public RFID()
        {

            serialPort = new SerialPort(AutodetectArduinoPort(), 9600);
            OpenSerialPort();


        }
        public static void CloseSerialPort()
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
            }

        }

        public static void OpenSerialPort()
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
            }

        }

        public void ReturnTag()
        {
            string rfid = "";


            while (true)
            {
                System.Threading.Thread.Sleep(10);
                try
                {
                    rfid = serialPort.ReadLine().Trim();

                    if (rfid != "")
                    {
                        Console.WriteLine(rfid);
                        MessageBox.Show("RFID tag: " + rfid);
                    }
                }
                catch 
                {
                    Console.WriteLine("ReturnTag failed");
                }

            }



        }
        public void ReadTag()
        {
            string rfid = "";
            bll = new BusinessLogicLayer();
            while (true)
            {
                rfid = null;
                System.Threading.Thread.Sleep(10);
                try
                {
                    rfid = serialPort.ReadLine().Trim();

                    if (rfid != "" && rfid != null)
                    {
                        Console.WriteLine(rfid);

                        //bll.InsertAttendance(rfid);


                    }


                }
                catch
                {
                    Console.WriteLine("ReadTag failed");
                }

            }
        }
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

                    if (desc.Contains("Arduino"))
                    {
                        return deviceId;
                    }
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("AutodetectArduinoPort failed");
            }

            return null;
        }
    }
}
