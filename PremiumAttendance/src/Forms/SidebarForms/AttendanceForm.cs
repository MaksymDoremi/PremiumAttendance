using PremiumAttendance.Controls;
using PremiumAttendance.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class AttendanceForm : Form
    {
        private int month;
        private int year;
        private Employee currentEmployee;

        /// <summary>
        /// Form where admin sees attendance for all employees, employee sees only its own
        /// </summary>
        /// <param name="currentEmployee"></param>
        public AttendanceForm(Employee currentEmployee)
        {
            InitializeComponent();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            this.currentEmployee = currentEmployee;
            InitItems(year, month);

        }

        /// <summary>
        /// Initializes <see cref="TableLayoutPanel"/> using <see cref="DataTable"/> returned from database
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void InitItems(int year, int month)
        {
            attendanceTableLayoutPanel.Controls.Clear();

            DateTime startDate = new DateTime(year, month, 1);
            this.monthYearLabel.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;

            BusinessLogicLayer bll = new BusinessLogicLayer();
            DataTable dt = new DataTable();
            try
            {
                if (this.currentEmployee.Role == "Administrator")
                {
                    // display all employees for admin
                    dt = bll.GetAttendanceOverall(year, month);
                }

                if (this.currentEmployee.Role == "Employee")
                {
                    // display attendance only for exact employee
                    dt = bll.GetAttendanceOverall(year, month, this.currentEmployee.Login);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load attendance data, contact developer.");
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }

            int employeeHeight = 70;
            int employeeWidth = 200;

            int attendanceHeight = 70;
            int attendanceWidth = 70;

            int height = 70;
            int width = 70;

            // clear all controls
            attendanceTableLayoutPanel.Dock = DockStyle.None;
            this.attendanceTableLayoutPanel.RowStyles.Clear();
            this.attendanceTableLayoutPanel.ColumnStyles.Clear();

            //draw header, employee column and days for month
            for (int i = 0; i < 1; i++)
            {

                attendanceTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, height));

                attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, employeeWidth));
                AttendanceFormEmployeeControl e = new AttendanceFormEmployeeControl(employeeWidth, employeeHeight, "Employee Column");
                attendanceTableLayoutPanel.Controls.Add(e, 0, i);

                for (int j = 0; j < DateTime.DaysInMonth(startDate.Year, startDate.Month); j++)
                {


                    attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, attendanceWidth));
                    AttendanceFormAttendanceControl a = new AttendanceFormAttendanceControl(attendanceWidth, attendanceHeight, startDate.AddDays(j).ToString("dd/MM"));
                    // 0 column is already employee so do j+1, i is 0, the header column
                    attendanceTableLayoutPanel.Controls.Add(a, j + 1, i);
                }
            }


            // get distinct employees from returned datatable
            var distinctEmployees = dt.AsEnumerable()
                                     .Select(row => row.Field<string>("Employee_NameSurname"))
                                     .Distinct()
                                     .ToList();

            // foreach distinct employee => add new row
            for (int i = 0; i < distinctEmployees.Count; i++)
            {
                // 0 column is employee column, row 0 is header so do i+1
                // add employee name from distinctEmployees
                attendanceTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
                attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, employeeWidth));
                AttendanceFormEmployeeControl e = new AttendanceFormEmployeeControl(employeeWidth, employeeHeight, distinctEmployees[i]);
                attendanceTableLayoutPanel.Controls.Add(e, 0, i + 1);

                // foreach attendance that belongs to that employee
                for (int j = 0; j < DateTime.DaysInMonth(startDate.Year, startDate.Month); j++)
                {
                    DateTime currentDate = startDate.AddDays(j);
                    // all records that belong to employee
                    DataRow[] employeeRecords = dt.Select($"Employee_NameSurname = '{distinctEmployees[i]}'");

                    // get all records that belong for currentDate(current date column)
                    employeeRecords = employeeRecords.Where(row => row["Attendance_Date"].ToString() == currentDate.Date.ToString()).ToArray();

                    // concatenate all attendance records for that day into one string
                    // if it is "Absent" then attendanceInfo will be null
                    string attendanceInfo = string.Join("\n", employeeRecords.Where(r => r["Time_of_Entry"].ToString() != "Absent").Select(r => r["Time_of_Entry"].ToString()));

                    // display concatenated time of entry values or "None" if no records found
                    if (!string.IsNullOrEmpty(attendanceInfo))
                    {
                        attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, attendanceWidth));
                        AttendanceFormAttendanceControl a = new AttendanceFormAttendanceControl(attendanceWidth, attendanceHeight, attendanceInfo);
                        attendanceTableLayoutPanel.Controls.Add(a, j + 1, i + 1);
                    }
                    else
                    {
                        attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, attendanceWidth));
                        AttendanceFormAttendanceControl a = new AttendanceFormAttendanceControl(attendanceWidth, attendanceHeight);
                        attendanceTableLayoutPanel.Controls.Add(a, j + 1, i + 1);
                    }

                }
            }
        }

        /// <summary>
        /// Goes one month backwards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousMonthBtn_Click(object sender, EventArgs e)
        {
            if (month - 1 == 0)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }

            this.InitItems(year, month);
        }

        /// <summary>
        /// Goes one month forwards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextMonthBtn_Click(object sender, EventArgs e)
        {
            if (month + 1 == 13)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }

            this.InitItems(year, month);
        }
    }
}
