using PremiumAttendance.Controls;
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
using PremiumAttendance.Forms.SubForms;

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class NotificationForm : Form
    {

        private Employee currentUser;
        private DashBoardForm dashboardForm;
        private List<Notification> notificationList;
        private BusinessLogicLayer bll;
        public NotificationForm(DashBoardForm dashboardForm, ref Employee currentUser)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
            this.currentUser = currentUser;
            this.notificationList = new List<Notification>();
            this.bll = new BusinessLogicLayer();

            if (currentUser.Role == "Employee")
            {
                this.sendNotificationBtn.Visible = false;
            }
            InitItems();
        }

        /// <summary>
        /// Init notifications
        /// </summary>
        public void InitItems()
        {
            InitNotificationList();
            InitControls();
        }

        /// <summary>
        /// Init notification list, gets <see cref="System.Data.DataTable"/> of <see cref="PremiumAttendance.Objects.Notification"/>
        /// </summary>
        public void InitNotificationList()
        {
            this.notificationList.Clear();
            try
            {
                DataTable dt = bll.GetNotifications(currentUser.Id);

                foreach (DataRow dr in dt.Rows)
                {
                    this.notificationList.Add(new Notification(
                        (int)dr["Message_ID"],
                        (int)dr["Have_read_ID"],
                        (bool)dr["Is_Read"],
                        (string)dr["Author_name"],
                        (string)dr["Title"],
                        (string)dr["Content"],
                        (DateTime)dr["Date_of_delivery"]));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Init notification controls from notification list
        /// </summary>
        public void InitControls()
        {
            this.notificationsFloatLayoutPanel.Controls.Clear();

            //Notification[] notifications = notificationList.ToArray();

            foreach (Notification notification in notificationList)
            {
                NotificationControl control = new NotificationControl(notification, dashboardForm);
                this.notificationsFloatLayoutPanel.Controls.Add(control);

            }
        }

        /// <summary>
        /// Admin button, only admin can send notifications. Opens <see cref="PremiumAttendance.Forms.SubForms.SendNotificationForm"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendNotificationBtn_Click(object sender, EventArgs e)
        {
            SendNotificationForm form = new SendNotificationForm(this, currentUser);
            form.ShowDialog();
        }
    }
}
