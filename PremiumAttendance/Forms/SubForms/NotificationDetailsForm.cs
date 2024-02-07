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
    public partial class NotificationDetailsForm : Form
    {
        private Notification notification;
        private BusinessLogicLayer bll;

        public EventHandler markAsReadEvent;
        public NotificationDetailsForm(Notification notification)
        {
            InitializeComponent();
            this.notification = notification;
            bll = new BusinessLogicLayer();
            InitItems();
        }

        public void InitItems()
        {
            this.titleLabel.Text = notification.Title;
            this.authorNameLabel.Text = notification.AuthorName;
            this.dateOfDeliveryLabel.Text = notification.DateOfDelivery.ToString();
            this.contentLabel.Text = notification.Content;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void markAsReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bll.MarkAsRead(notification.Have_read_id);

                if(markAsReadEvent != null)
                {
                    markAsReadEvent.Invoke(this, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
