﻿using ComponentFactory.Krypton.Toolkit;
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
        public LoginForm()
        {

            InitializeComponent();
            //start rfid thread
            try
            {
                RFID r = new RFID();

                rfidThread = new Thread(r.ReadTag);
                rfidThread.Start();
            }
            catch (Exception ex)
            {
                //ignore error
                //MessageBox.Show("RFID can't be opened");
            }

        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// Login into system
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
                
                if (bll.Login(username, Program.ComputeSHA256(password)))
                {
                    currentEmployee = bll.GetCurrentUser(username);
                    DashBoardForm form = new DashBoardForm(this, currentEmployee, ref rfidThread);
                    form.Show();
                    this.Hide();
                }


            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}