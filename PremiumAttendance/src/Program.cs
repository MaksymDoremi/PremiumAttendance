using PremiumAttendance.objects;
using System;
using System.Collections.Generic;
using System.Configuration;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        /// <summary>
        /// Computes sha256 for given string and applies salt to it from App.config
        /// </summary>
        /// <param name="input">String to be hashed</param>
        /// <returns>Hashed string</returns>
        public static string ComputeSHA256(string input)
        {
            string hash = String.Empty;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(input + ConfigurationManager.AppSettings["passwordSalt"]));

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
        /// <param name="image">Image to be converted</param>
        /// <returns>byte[] or null</returns>
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (var ms = new MemoryStream())
            {
                (new Bitmap(image)).Save(ms, image.RawFormat);
                return ms.ToArray();
            }

        }

        /// <summary>
        /// Takes byte[] and converts to Image
        /// </summary>
        /// <param name="data">byte[] to be converted</param>
        /// <returns>Image object</returns>
        public static Image ConvertByteArrayToImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
