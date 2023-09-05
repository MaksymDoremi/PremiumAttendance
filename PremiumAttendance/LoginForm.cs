using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumAttendance
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginTextBox_Enter(object sender, EventArgs e)
        {
            this.loginTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.loginTextBox.Text = "";
        }

        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            this.loginTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.loginTextBox.Text = "Login";
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.passwordTextBox.Text = "";
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordTextBox.Text = "Password";
        }
    }
}
