using PremiumAttendance.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance
{
    
    public static class Program
    {
        /// <summary>
        /// Flag for <see cref="RFID"> thread, whether or not to mark attendance or show it in <see cref="MessageBox">
        /// </summary>
        public static bool markRfidAttendance = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DataAccessLayer dal = new DataAccessLayer();

            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        /// <summary>
        /// Computes sha256 and applies salt to it
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ComputeSHA256(string s)
        {
            string hash = String.Empty;

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s + "XyZ987&*#"));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }

        /// <summary>
        /// Takes Image and converts to byte[]
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image imageIn)
        {
            //ImageConverter converter = new ImageConverter();

            //return (byte[])converter.ConvertTo(imageIn, typeof(byte[]));
            if (imageIn == null)
            {
                return null;
            }

            using (var ms = new MemoryStream())
            {
                //imageIn.Save(ms, imageIn.RawFormat);
                (new Bitmap(imageIn)).Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }

        }

        /// <summary>
        /// Takes byte[] and converts to Image
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Image ConvertByteArrayToImage(byte[] data)
        {
            if (data != null)
            {
                using (MemoryStream ms = new MemoryStream(data))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;

        }
    }
}
