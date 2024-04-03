namespace PremiumAttendance.Forms.SidebarForms
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attendanceTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // attendanceTableLayoutPanel
            // 
            this.attendanceTableLayoutPanel.AutoScroll = true;
            this.attendanceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.attendanceTableLayoutPanel.Location = new System.Drawing.Point(12, 143);
            this.attendanceTableLayoutPanel.MaximumSize = new System.Drawing.Size(1260, 580);
            this.attendanceTableLayoutPanel.Name = "attendanceTableLayoutPanel";
            this.attendanceTableLayoutPanel.Size = new System.Drawing.Size(1245, 580);
            this.attendanceTableLayoutPanel.TabIndex = 0;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 734);
            this.Controls.Add(this.attendanceTableLayoutPanel);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel attendanceTableLayoutPanel;
    }
}