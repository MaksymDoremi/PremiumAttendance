using PremiumAttendance.Objects;
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
    public partial class AddEmployeeForm : Form
    {
        private BusinessLogicLayer bll;
        public event EventHandler newEmployeeAddedEvent;

        private Thread rfidThread;

        private RFID rfidModule;
        public AddEmployeeForm(ref RFID rfidModule)
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
            this.rfidModule = rfidModule;

            try
            {
                this.rfidThread = new Thread(rfidModule.ReturnTag);
                rfidThread.Start();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                //MessageBox.Show(ex.Message);
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

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(this.rfidTagTextBox.Text, this.roleComboBox.Text, this.loginTextBox.Text, Program.ComputeSHA256(this.passwordTextBox.Text), this.nameTextBox.Text, this.surnameTextBox.Text, Program.ImageToByteArray(this.imageBox.Image), this.emailTextBox.Text, this.phoneTextBox.Text);
            try
            {
                bll.CreateEmployee(employee);
                MessageBox.Show("Employee created successfully");
                if (newEmployeeAddedEvent != null)
                {
                    newEmployeeAddedEvent.Invoke(this, e);
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
                    imageBox.ImageLocation = imageLocation;
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
