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

        /// <summary>
        /// Init notification attributes from given instance
        /// </summary>
        public void InitItems()
        {
            this.titleLabel.Text = notification.Title;
            this.authorNameLabel.Text = notification.AuthorName;
            this.dateOfDeliveryLabel.Text = notification.DateOfDelivery.ToString();
            this.contentLabel.Text = notification.Content;
        }

        /// <summary>
        /// Closes current child form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Marks as read in database and invokes event to the <see cref="PremiumAttendance.Forms.SidebarForms.NotificationForm"/> which marks that control to marked color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markAsReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bll.MarkAsRead(notification.Have_read_id);

                markAsReadEvent?.Invoke(this, e);
                
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
