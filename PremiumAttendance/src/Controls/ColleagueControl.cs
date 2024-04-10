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

namespace PremiumAttendance.Controls
{
    public partial class ColleagueControl : UserControl
    {
        private byte[] photo;
        private string name;
        private string surname;

        /// <summary>
        /// Control which employee sees at <see cref="Forms.SidebarForms.MyDashboardForm"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="photo"></param>
        public ColleagueControl(string name, string surname, byte[] photo)
        {
            InitializeComponent();

            this.name = name;
            this.surname = surname;
            this.photo = photo;

            InitItems();
        }

        /// <summary>
        /// Init attributes
        /// </summary>
        public void InitItems()
        {
            if (this.photo == null)
            {
                this.colleaguePicture.Image = global::PremiumAttendance.Properties.Resources.unknownPhoto;
            }
            else
            {
                this.colleaguePicture.Image = Program.ConvertByteArrayToImage(this.photo);
            }

            this.colleagueNameSurnameLabel.Text = this.name + " " + this.surname;
        }
    }
}
