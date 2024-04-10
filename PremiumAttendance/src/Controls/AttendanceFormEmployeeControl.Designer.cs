namespace PremiumAttendance.Controls
{
    partial class AttendanceFormEmployeeControl
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.Location = new System.Drawing.Point(3, 9);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(194, 50);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "label1";
            // 
            // AttendanceFormEmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "AttendanceFormEmployeeControl";
            this.Size = new System.Drawing.Size(198, 68);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
    }
}
