using PremiumAttendance.Forms;
using PremiumAttendance.Forms.SubForms;
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

namespace PremiumAttendance.Controls
{
    public partial class NotificationControl : UserControl
    {
        private Notification notification;
        private DashBoardForm dashboardForm;
        private Color currentColor;
        public NotificationControl(Notification notification, DashBoardForm dashboardForm)
        {
            InitializeComponent();
            this.notification = notification;
            this.dashboardForm = dashboardForm;
            InitItems();

            
        }

        public void InitItems()
        {
            if (notification.Is_read)
            {
                this.BackColor = System.Drawing.SystemColors.ActiveBorder;

            }
            this.currentColor = this.BackColor;
            this.author_nameLabel.Text = this.notification.AuthorName;
            this.titleLabel.Text = this.notification.Title;
            this.dateTimeLabel.Text = this.notification.DateOfDelivery.ToString();
        }

        public void InitItemsEvent(object sender, EventArgs e)
        {
            notification.Is_read = true;
            InitItems();
        }

        private void NotificationControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void NotificationControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.currentColor;
        }

        private void NotificationControl_Click(object sender, EventArgs e)
        {
            NotificationDetailsForm form = new NotificationDetailsForm(notification);
            this.dashboardForm.OpenChildFormOverChildForm(form);
            form.markAsReadEvent += InitItemsEvent;
        }
    }
}
