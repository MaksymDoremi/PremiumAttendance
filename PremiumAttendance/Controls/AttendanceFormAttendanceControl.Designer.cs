namespace PremiumAttendance.Controls
{
    partial class AttendanceFormAttendanceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.attendanceLabel.Location = new System.Drawing.Point(0, 0);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(67, 70);
            this.attendanceLabel.TabIndex = 0;
            this.attendanceLabel.Text = "1\r\n2\r\n3\r\n4";
            this.attendanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttendanceFormAttendanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.attendanceLabel);
            this.Name = "AttendanceFormAttendanceControl";
            this.Size = new System.Drawing.Size(68, 68);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label attendanceLabel;
    }
}
