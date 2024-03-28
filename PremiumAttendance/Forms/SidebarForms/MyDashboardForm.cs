using PremiumAttendance.Controls;
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
    public partial class MyDashboardForm : Form
    {

        private List<ColleagueControl> colleaguesAtWorkList;
        private string currentEmployeeLogin;
        public MyDashboardForm(string currentEmployeeLogin)
        {
            InitializeComponent();
            this.colleaguesAtWorkList = new List<ColleagueControl>();
            this.currentEmployeeLogin = currentEmployeeLogin;

            InitItems();
        }

        public void InitItems()
        {
            InitColleaguesList();
            InitControls();
        }

        public void InitColleaguesList()
        {
            BusinessLogicLayer bll = new BusinessLogicLayer();

            this.colleaguesAtWorkList.Clear();
            try
            {
                DataTable dt = bll.GetColleguesAtWork(this.currentEmployeeLogin);

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
