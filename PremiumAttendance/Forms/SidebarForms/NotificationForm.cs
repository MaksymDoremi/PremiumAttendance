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

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class NotificationForm : Form
    {

        private Employee currentUser;
        private DashBoardForm dashboardForm;
        public NotificationForm(DashBoardForm dashboardForm, ref Employee currentUser)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
            this.currentUser = currentUser;

            InitItems();
        }

        public void InitItems()
        {
            this.notificationsFloatLayoutPanel.Controls.Clear();

            Notification
        }
    }
}
