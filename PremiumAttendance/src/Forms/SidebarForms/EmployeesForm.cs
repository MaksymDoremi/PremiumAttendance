using PremiumAttendance.Controls;
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

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class EmployeesForm : Form
    {
        private DashBoardForm dashboardForm;
        private List<Employee> employeeList;
        private BusinessLogicLayer bll = new BusinessLogicLayer();
        private Employee currentUser;

        /// <summary>
        /// Form for admin, there are displayed all employees at company
        /// </summary>
        /// <param name="dashboardForm"></param>
        /// <param name="currentUser"></param>
        public EmployeesForm(DashBoardForm dashboardForm, ref Employee currentUser)
        {
            InitializeComponent();
            this.dashboardForm = dashboardForm;
            this.currentUser = currentUser;

            employeeList = new List<Employee>();

            InitItems();
        }

        /// <summary>
        /// Initialize attributes
        /// </summary>
        public void InitItems()
        {
            InitEmployeeList();
            InitControls();
        }

        /// <summary>
        /// Event in case adding new employee or deleting one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InitItemsEvent(object sender, EventArgs e)
        {
            InitItems();
        }

        /// <summary>
        /// Get <see cref="System.Data.DataTable"/> from database and initialize list of <see cref="PremiumAttendance.Objects.Employee"/>
        /// </summary>
        public void InitEmployeeList()
        {
            this.employeeList.Clear();
            try
            {
                DataTable dt = bll.GetEmployees(this.currentUser.Login);

                foreach (DataRow row in dt.Rows)
                {
                    employeeList.Add(new Employee(
                        Convert.ToInt32(row["ID"]),
                        row["RFID_Tag"].ToString(),
                        row["Role_name"].ToString(),
                        row["Login"].ToString(),
                        row["Name"].ToString(),
                        row["Surname"].ToString(),
                        row["Photo"] == DBNull.Value ? null : (byte[])row["Photo"],
                        row["Email"].ToString(),
                        row["Phone"].ToString()));
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Initializes <see cref="PremiumAttendance.Controls.EmployeeControl"/> into <see cref="FlowLayoutPanel"/>
        /// </summary>
        public void InitControls()
        {
            this.employeeFlowLayoutPanel.Controls.Clear();

            var newList =
                from employee in employeeList
                where (String.IsNullOrEmpty(this.nameTextBox.Text) || employee.Name.ToLower().Contains(this.nameTextBox.Text.ToLower()))
                && (String.IsNullOrEmpty(this.surnameTextBox.Text) || employee.Surname.ToLower().Contains(this.surnameTextBox.Text.ToLower()))
                select employee;

            foreach (Employee emoployee in newList)
            {
                EmployeeControl control = new EmployeeControl(emoployee, dashboardForm);
                this.employeeFlowLayoutPanel.Controls.Add(control);
            }
        }

        /// <summary>
        /// Opens <see cref="AddEmployeeForm"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            Program.markRfidAttendance = false;

            this.dashboardForm.OpenChildFormOverChildForm(form);
            form.newEmployeeAddedEvent += InitItemsEvent;
        }

        /// <summary>
        /// Calls <see cref="PremiumAttendance.Forms.SidebarForms.EmployeesForm.InitControls"/> to render with given filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterBtn_Click(object sender, EventArgs e)
        {
            InitControls();
        }
    }
}
