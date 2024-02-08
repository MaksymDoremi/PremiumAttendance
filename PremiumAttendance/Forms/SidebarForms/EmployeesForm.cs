using PremiumAttendance.Forms.SubForms;
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
    public partial class EmployeesForm : Form
    {
        private DashBoardForm dashboardForm;
        public EmployeesForm(DashBoardForm dashboardForm)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
        }

        public void InitItems()
        {

        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form =  new AddEmployeeForm();
            this.dashboardForm.OpenChildFormOverChildForm(form);
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
