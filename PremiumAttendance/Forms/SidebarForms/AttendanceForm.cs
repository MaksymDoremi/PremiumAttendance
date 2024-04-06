﻿using PremiumAttendance.Controls;
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
        public AttendanceForm()
        {
            InitializeComponent();
            InitItems();
        }

        public void InitItems()
        {
            attendanceTableLayoutPanel.Controls.Clear();
            BusinessLogicLayer bll = new BusinessLogicLayer();

            DataTable dt = bll.GetAttendanceOverall();

            int employeeHeight = 70;
            int employeeWidth = 200;

            int attendanceHeight = 70;
            int attendanceWidth = 70;

            int height = 70;
            int width = 70;

            attendanceTableLayoutPanel.Dock = DockStyle.None;
            this.attendanceTableLayoutPanel.RowStyles.Clear();
            this.attendanceTableLayoutPanel.ColumnStyles.Clear();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

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
                    attendanceTableLayoutPanel.Controls.Add(a, j + 1, i);
                }
            }


            // Get distinct employee names and surnames
            var distinctEmployees = dt.AsEnumerable()
                                      .Select(row => row.Field<string>("Employee_NameSurname"))
                                      .Distinct()
                                      .ToList();

            // Populate attendance records for each distinct employee
            for (int i = 0; i < distinctEmployees.Count; i++)
            {
                // Add employee name in the first column
                attendanceTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
                attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, employeeWidth));
                AttendanceFormEmployeeControl e = new AttendanceFormEmployeeControl(employeeWidth, employeeHeight, distinctEmployees[i]);
                attendanceTableLayoutPanel.Controls.Add(e, 0, i + 1);

                // Populate attendance records for each day in the month
                for (int j = 0; j < DateTime.DaysInMonth(startDate.Year, startDate.Month); j++)
                {
                    DateTime currentDate = startDate.AddDays(j);
                    DataRow[] employeeRecords = dt.Select($"Employee_NameSurname = '{distinctEmployees[i]}'");
                    //Console.WriteLine(employeeRecords[5]["Attendance_Date"].ToString()+" "+ currentDate.Date.ToString());

                    employeeRecords = employeeRecords.Where(row => row["Attendance_Date"].ToString() == currentDate.Date.ToString()).ToArray();
                    // Check if any records exist for the current date
                    if (employeeRecords.Length > 0)
                    {
                        string attendanceInfo = string.Join("\n ", employeeRecords.Where(r => r["Time_of_Entry"].ToString() != "Absent").Select(r => r["Time_of_Entry"].ToString()));

                        // Display concatenated time of entry values or "None" if no records found
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
                    else
                    {
                        // If no records found for the current date, display "None"
                        attendanceTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, attendanceWidth));
                        AttendanceFormAttendanceControl a = new AttendanceFormAttendanceControl(attendanceWidth, attendanceHeight);
                        attendanceTableLayoutPanel.Controls.Add(a, j + 1, i + 1);
                    }
                }
            }

        }
    }
}
