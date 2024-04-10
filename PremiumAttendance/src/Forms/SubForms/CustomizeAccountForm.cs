using PremiumAttendance.objects;
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

        /// <summary>
        /// <para>Form where you can change <see cref="Employee"/> attributes</para>
        /// User mode, where admin can change RFID tag and employee can't
        /// </summary>
        /// <param name="currentUser"></param>
        public CustomizeAccountForm(ref Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            InitItems();
        }

        /// <summary>
        /// <para>Form where you can change <see cref="Employee"/> attributes</para>
        /// You can define admin mode and change RFID tag for other users
        /// </summary>
        /// <param name="currentUser"></param>
        /// <param name="adminMode"></param>
        public CustomizeAccountForm(ref Employee currentUser, bool adminMode)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.adminMode = adminMode;
            InitItems();

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

        /// <summary>
        /// Closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
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

                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Event to allow RFID thread marking attendance into database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizeAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.markRfidAttendance = true;
        }
    }
}
