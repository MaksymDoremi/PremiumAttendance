using PremiumAttendance.Controls;
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

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class HomepageForm : Form
    {
        private DashBoardForm dashboardForm;
        private Employee currentUser;

        /// <summary>
        /// Form where admin sees overall report each <see cref="EmployeeStatusControl"/>
        /// </summary>
        /// <param name="dashboardForm"></param>
        /// <param name="currentUser"></param>
        public HomepageForm(DashBoardForm dashboardForm, ref Employee currentUser)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
            this.currentUser = currentUser;

            InitControls();
        }

        /// <summary>
        /// Initializes <see cref="EmployeeStatusControl"/> into <see cref="FlowLayoutPanel"/>
        /// </summary>
        public void InitControls()
        {
            this.employeeStatusFlowPanel.Controls.Clear();
            try
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();
                DataTable dt = bll.GetEmployeeStatus(this.currentUser.Login);

                foreach (DataRow row in dt.Rows)
                {
                    EmployeeStatusControl control = new EmployeeStatusControl(
                        row["Name"].ToString(),
                        row["Surname"].ToString(),
                        row["Type_of_entry"] == DBNull.Value ? false : (bool)row["Type_of_entry"],
                        row["Datetime_of_entry"] == DBNull.Value ? DateTime.MinValue : (DateTime)row["Datetime_of_entry"]);

                    this.employeeStatusFlowPanel.Controls.Add(control);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
