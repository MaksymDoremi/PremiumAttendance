using PremiumAttendance.Forms.SidebarForms;
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
    public partial class SendNotificationForm : Form
    {
        private Employee currentUser;
        private BusinessLogicLayer bll = new BusinessLogicLayer();
        private NotificationForm notificationForm;

        /// <summary>
        /// Form that sends notification into database
        /// </summary>
        /// <param name="notificationForm"></param>
        /// <param name="currentUser"></param>
        public SendNotificationForm(NotificationForm notificationForm, Employee currentUser)
        {
            InitializeComponent();
            this.notificationForm = notificationForm;
            this.currentUser = currentUser;
        }

        /// <summary>
        /// Sends notification to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendNotificationBtn_Click(object sender, EventArgs e)
        {

            try
            {
                bll.SendNotification(currentUser.Id, this.titleTextBox.Text, this.contentTextBox.Text);
                notificationForm.InitItems();
                this.titleTextBox.Text = "Title";
                this.contentTextBox.Text = "Content";
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
