﻿using PremiumAttendance.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Forms.SubForms
{
    public partial class CustomizeAccountForm : Form
    {
        private Employee currentUser;
        public event EventHandler submitChangeEventHandler;
        private bool adminMode;

        private RFID rfidModule;
        private Thread rfidThread;

        public CustomizeAccountForm(ref Employee currentUser, ref RFID rfidModule)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            InitItems();

            this.rfidModule = rfidModule;

            try
            {
                this.rfidThread = new Thread(rfidModule.ReturnTag);
                rfidThread.IsBackground = true;
                rfidThread.Start();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                //MessageBox.Show(ex.Message);
            }

        }

        public CustomizeAccountForm(ref Employee currentUser, bool adminMode, ref RFID rfidModule)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.adminMode = adminMode;
            InitItems();

            this.rfidModule = rfidModule;

            try
            {
                this.rfidThread = new Thread(rfidModule.ReturnTag);
                rfidThread.IsBackground = true;
                rfidThread.Start();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                //MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Init user attributes
        /// </summary>
        public void InitItems()
        {
            this.changeNameTextBox.Text = currentUser.Name;
            this.changeSurnameTextBox.Text = currentUser.Surname;
            this.changeRfidTagTextBox.Text = currentUser.Rfid_tag;
            this.changeEmailTextBox.Text = currentUser.Email;
            this.changePhoneTextBox.Text = currentUser.Phone;

            if (currentUser.Photo != null)
            {
                this.changeImageBox.Image = Program.ConvertByteArrayToImage(currentUser.Photo);

            }

            if (currentUser.Role == "Employee" && !adminMode)
            {
                this.changeRfidTagTextBox.Enabled = false;
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (this.rfidModule != null)
            {
                this.rfidModule.SetEndgameToken();
                rfidModule.SetEventWaitHandle(sender, e);
            }
            this.Close();
        }

        /// <summary>
        /// Opens file explorer to browse for image files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseImagesBtn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    changeImageBox.ImageLocation = imageLocation;
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Applies changes to database and updates currentUser.
        /// Invokes event to updates attributes at <see cref="PremiumAttendance.Forms.SidebarForms.MyAccountForm"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyChangesAccountInfoBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(currentUser.Id, this.changeRfidTagTextBox.Text, currentUser.Role, currentUser.Login, this.changeNameTextBox.Text, this.changeSurnameTextBox.Text, Program.ImageToByteArray(this.changeImageBox.Image), this.changeEmailTextBox.Text, this.changePhoneTextBox.Text);
            BusinessLogicLayer bll = new BusinessLogicLayer();
            try
            {
                bll.UpdateEmployee(emp);

                MessageBox.Show("Changes applied");

                this.currentUser.Name = emp.Name;
                this.currentUser.Surname = emp.Surname;
                this.currentUser.Rfid_tag = emp.Rfid_tag;
                this.currentUser.Email = emp.Email;
                this.currentUser.Phone = emp.Phone;
                this.currentUser.Photo = emp.Photo;

                if (submitChangeEventHandler != null)
                {
                    submitChangeEventHandler.Invoke(this, e);
                }

                if (this.rfidModule != null)
                {
                    this.rfidModule.SetEndgameToken();
                    rfidModule.SetEventWaitHandle(sender, e);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }

        }
    }
}
