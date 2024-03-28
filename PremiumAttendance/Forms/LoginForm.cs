using ComponentFactory.Krypton.Toolkit;
using PremiumAttendance.Forms;
using PremiumAttendance.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance
{
    public partial class LoginForm : Form
    {
        private Employee currentEmployee;
        private Thread rfidThread;
        private RFID rfidModule;
        public LoginForm()
        {
            InitializeComponent();
            //start rfid thread
            
            try
            {
                rfidModule = new RFID();
                rfidThread = new Thread(rfidModule.ReadTag);
                rfidThread.IsBackground = true;
                rfidThread.Start();
            }
            catch (Exception ex)
            {
                //ignore error
                //MessageBox.Show("RFID can't be opened");
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }
        }

        /// <summary>
        /// Method to erase placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginTextBox_Enter(object sender, EventArgs e)
        {
            if (this.loginTextBox.Text == "Login")
            {
                this.loginTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
                this.loginTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Method to restore placeholder in case there is no text inside
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.loginTextBox.Text))
            {
                this.loginTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
                this.loginTextBox.Text = "Login";
            }

        }

        /// <summary>
        /// Method to erase placeholder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text == "Password")
            {
                this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
                this.passwordTextBox.Text = "";
                this.passwordTextBox.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Method to restore placeholder in case there is no text inside
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
                this.passwordTextBox.Text = "Password";
                this.passwordTextBox.PasswordChar = '\0';
            }
        }

        /// <summary>
        /// Logs into system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singInBtn_Click(object sender, EventArgs e)
        {
            string username = this.loginTextBox.Text;
            string password = this.passwordTextBox.Text;

            // if not null or empty => procees to login
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password)
                && username != "Login" && password != "Password")
            {

                BusinessLogicLayer bll = new BusinessLogicLayer();
                try
                {
                    bll.Login(username, Program.ComputeSHA256(password));
                    currentEmployee = bll.GetCurrentUser(username);
                    DashBoardForm form = new DashBoardForm(this, ref currentEmployee, ref rfidThread, ref rfidModule);
                    form.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Event to prevent from typing spaces into password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// Event to prevent from typing spaces into login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        /// <summary>
        /// While closing the app it kills the processs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
