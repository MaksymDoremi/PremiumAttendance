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

        /// <summary>
        /// Control that contains information about notification, references to <see cref="NotificationDetailsForm"/>
        /// </summary>
        /// <param name="notification"></param>
        /// <param name="dashboardForm"></param>
        public NotificationControl(Notification notification, DashBoardForm dashboardForm)
        {
            InitializeComponent();
            this.notification = notification;
            this.dashboardForm = dashboardForm;
            InitItems();


        }

        /// <summary>
        /// Init attributes
        /// </summary>
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

        /// <summary>
        /// Event that after making notification read => makes it grey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InitItemsEvent(object sender, EventArgs e)
        {
            notification.Is_read = true;
            InitItems();
        }

        /// <summary>
        /// Hover effect enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
        }

        /// <summary>
        /// Hover effect leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.currentColor;
        }

        /// <summary>
        /// Reference to <see cref="NotificationDetailsForm"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotificationControl_Click(object sender, EventArgs e)
        {
            NotificationDetailsForm form = new NotificationDetailsForm(notification);
            this.dashboardForm.OpenChildFormOverChildForm(form);
            form.markAsReadEvent += InitItemsEvent;
        }
    }
}
