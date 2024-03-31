﻿using PremiumAttendance.Objects;
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
        public ColleagueControl(string name, string surname, byte[] photo)
        {
            InitializeComponent();

            this.name = name;
            this.surname = surname;
            this.photo = photo;

            InitItems();
        }

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

            this.colleagueNameSurnameLabel.Text = this.name+" "+this.surname;
        }
    }
}