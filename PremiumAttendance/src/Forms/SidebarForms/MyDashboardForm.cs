using PremiumAttendance.Controls;
using PremiumAttendance.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace PremiumAttendance.Forms.SidebarForms
{
    public partial class MyDashboardForm : Form
    {

        private List<ColleagueControl> colleaguesAtWorkList;
        private Employee currentEmployee;

        /// <summary>
        /// Employee page, sees month report and data fetched from API <see cref="SvatkyAPIObject"/> 
        /// </summary>
        /// <param name="currentEmployee"></param>
        public MyDashboardForm(Employee currentEmployee)
        {
            InitializeComponent();
            this.colleaguesAtWorkList = new List<ColleagueControl>();
            this.currentEmployee = currentEmployee;

            InitItems();

        }

        /// <summary>
        /// Initializes month report, API data, Colleagues at work
        /// </summary>
        /// <returns></returns>
        public async Task InitItems()
        {
            try
            {
                BusinessLogicLayer bll = new BusinessLogicLayer();

                Dictionary<string, int> hoursDays = bll.GetHoursDays(this.currentEmployee.Login);

                this.workedDaysLabel.Text = "Total worked days: " + hoursDays["days"];
                this.workedHoursLabel.Text = "Total worked hours: " + hoursDays["hours"];
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
            }


            this.welcomeMessageLabel.Text = $"Welcome, {this.currentEmployee.Name} {this.currentEmployee.Surname}";

            InitColleaguesList();
            InitControls();

            var somethingTask = GetApiData();
            var winner = await Task.WhenAny(
                somethingTask,
                Task.Delay(TimeSpan.FromSeconds(3)));
            if (winner != somethingTask)
            {
                this.apiResponseNameLabel.Text = $"Today's day is for: API Timeout";
                this.apiResponseHolidayLabel.Text = $"No holiday for today. API Timeout";
            }
        }

        /// <summary>
        /// Fetches data from API using the async and await. Sets labels text
        /// </summary>
        /// <returns></returns>
        public async Task GetApiData()
        {
            APIClient apiClient = new APIClient();

            SvatkyAPIObject svatek = null;


            try
            {
                svatek = await apiClient.GetJsonResponse();

            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                this.apiResponseNameLabel.Text = $"Today's day is for: API Error";
                this.apiResponseHolidayLabel.Text = $"No holiday for today. API Error";
            }

            if (svatek != null)
            {
                this.apiResponseNameLabel.Text = $"Today's day is for: {svatek.name}";
                if (svatek.isHoliday)
                {
                    this.apiResponseHolidayLabel.Text = $"Today's holiday: {svatek.holidayName}";
                }
                else
                {
                    this.apiResponseHolidayLabel.Text = $"No holiday for today.";
                }

            }
        }

        /// <summary>
        /// Fetches <see cref="DataTable"/> and adds <see cref="ColleagueControl"/> into list
        /// </summary>
        public void InitColleaguesList()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();

            this.colleaguesAtWorkList.Clear();
            try
            {
                DataTable dt = bll.GetColleguesAtWork(this.currentEmployee.Login);

                foreach (DataRow row in dt.Rows)
                {
                    colleaguesAtWorkList.Add(new ColleagueControl(
                        row["Name"].ToString(),
                        row["Surname"].ToString(),
                        row["Photo"] == DBNull.Value ? null : (byte[])row["Photo"]));
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Initializes <see cref="ColleagueControl"/> into <see cref="FlowLayoutPanel"/>
        /// </summary>
        public void InitControls()
        {
            this.colleaguesAtWorkFlowLayoutPanel.Controls.Clear();
            foreach (ColleagueControl c in this.colleaguesAtWorkList)
            {
                this.colleaguesAtWorkFlowLayoutPanel.Controls.Add(c);
            }
        }
    }
}
