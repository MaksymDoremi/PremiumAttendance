using PremiumAttendance.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Forms.SubForms
{
    public partial class CustomizeAccountForm : Form
    {
        private Employee currentUser;
        public event EventHandler submitChangeEventHandler;
        public CustomizeAccountForm(ref Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            InitItems();
        }
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

            if(currentUser.Role == "Employee")
            {
                this.changeRfidTagTextBox.Enabled = false;
            }

        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    changeImageBox.ImageLocation = imageLocation;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void applyChangesAccountInfoBtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(currentUser.Id, this.changeRfidTagTextBox.Text, currentUser.Role, currentUser.Login, this.changeNameTextBox.Text, this.changeSurnameTextBox.Text, Program.ImageToByteArray(this.changeImageBox.Image), this.changeEmailTextBox.Text, this.changePhoneTextBox.Text);
            BusinessLogicLayer bll = new BusinessLogicLayer();
            if (bll.UpdateEmployee(emp))
            {
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

                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
