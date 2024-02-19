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

namespace PremiumAttendance.Forms.SubForms
{
    public partial class ChangePasswordForm : Form
    {
        private int employeeID;
        public ChangePasswordForm(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        /// <summary>
        /// Applies password change to database, checks if password confirmed is correct
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyChangesAccountInfoBtn_Click(object sender, EventArgs e)
        {
            if (this.newPasswordTextBox.Text != this.confirmNewPasswordTextBox.Text)
            {
                MessageBox.Show("Incorrect password confirmation");
                return;
            }

            BusinessLogicLayer bll = new BusinessLogicLayer();
            try
            {
                bll.UpdatePassword(employeeID, this.oldPasswordTextBox.Text, this.newPasswordTextBox.Text);

                MessageBox.Show("Password changed successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog($"{ex.Message}\n{ex.StackTrace}", true);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Prevents from typing spaces to password textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
