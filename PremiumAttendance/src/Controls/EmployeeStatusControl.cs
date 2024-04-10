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
    public partial class EmployeeStatusControl : UserControl
    {

        private string name;
        private string surname;
        private bool? type_of_entry;
        private DateTime datetime_of_entry;

        /// <summary>
        /// Control that display status of the employee and last record
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="type_of_entry"></param>
        /// <param name="datetime_of_entry"></param>
        public EmployeeStatusControl(string name, string surname, bool? type_of_entry, DateTime datetime_of_entry)
        {
            InitializeComponent();
            this.name = name;
            this.surname = surname;
            this.type_of_entry = type_of_entry;
            this.datetime_of_entry = datetime_of_entry;
            InitItems();
        }

        /// <summary>
        /// Init attributes
        /// </summary>
        public void InitItems()
        {
            this.employeeNameSurnameLabel.Text = $"{this.name} {this.surname}";

            // employee didn't come at all
            if (datetime_of_entry == DateTime.MinValue)
            {
                this.employeeStatusImage.Image = global::PremiumAttendance.Properties.Resources.redMark;
                this.lastRecordLabel.Text = "---";
            }
            // employee is at work of left
            else
            {
                this.lastRecordLabel.Text = (bool)this.type_of_entry ? $"Check in {this.datetime_of_entry.ToString("t")}" : $"Check out {this.datetime_of_entry.ToString("t")}";
                this.employeeStatusImage.Image = (bool)this.type_of_entry ? global::PremiumAttendance.Properties.Resources.greenMark : global::PremiumAttendance.Properties.Resources.yellowMark;
            }
        }
    }
}
