﻿using PremiumAttendance.Controls;
using PremiumAttendance.objects;
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

        /// <summary>
        /// Notification page where user sees his notifications he received
        /// </summary>
        /// <param name="dashboardForm"></param>
        /// <param name="currentUser"></param>
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

            this.newestRadionBtn.Checked = true;
            this.oldestRadionBtn.Checked = false;
            InitItems();
        }

        /// <summary>
        /// Init all attributes
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
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Init <see cref="NotificationControl"/> from notification list, then insert into <see cref="FlowLayoutPanel"/>
        /// </summary>
        public void InitControls()
        {
            this.notificationsFloatLayoutPanel.Controls.Clear();

            // sort by newest
            if (this.newestRadionBtn.Checked)
            {
                var newList =
                    from notification in notificationList
                    where (String.IsNullOrEmpty(this.fromTextBox.Text) || notification.AuthorName.ToLower().Contains(this.fromTextBox.Text.ToLower()))
                    && (String.IsNullOrEmpty(this.subjectTextBox.Text) || notification.Title.ToLower().Contains(this.subjectTextBox.Text.ToLower()))
                    orderby notification.DateOfDelivery descending
                    select notification;

                foreach (Notification notification in newList)
                {
                    NotificationControl control = new NotificationControl(notification, dashboardForm);
                    this.notificationsFloatLayoutPanel.Controls.Add(control);

                }

            }
            // sort by oldest
            else if (this.oldestRadionBtn.Checked)
            {
                var newList =
                    from notification in notificationList
                    where (String.IsNullOrEmpty(this.fromTextBox.Text) || notification.AuthorName.ToLower().Contains(this.fromTextBox.Text.ToLower()))
                    && (String.IsNullOrEmpty(this.subjectTextBox.Text) || notification.Title.ToLower().Contains(this.subjectTextBox.Text.ToLower()))
                    orderby notification.DateOfDelivery
                    select notification;

                foreach (Notification notification in newList)
                {
                    NotificationControl control = new NotificationControl(notification, dashboardForm);
                    this.notificationsFloatLayoutPanel.Controls.Add(control);

                }
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

        /// <summary>
        /// Apply new filer settings and initializes attributes again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterBtn_Click(object sender, EventArgs e)
        {
            InitControls();
        }
    }
}
