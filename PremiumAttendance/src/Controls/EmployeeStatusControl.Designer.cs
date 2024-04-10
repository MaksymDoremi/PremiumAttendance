namespace PremiumAttendance.Controls
{
    partial class EmployeeStatusControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameSurnameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastRecordLabel = new System.Windows.Forms.Label();
            this.employeeStatusImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeStatusImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(132, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // employeeNameSurnameLabel
            // 
            this.employeeNameSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.employeeNameSurnameLabel.Location = new System.Drawing.Point(229, 12);
            this.employeeNameSurnameLabel.Name = "employeeNameSurnameLabel";
            this.employeeNameSurnameLabel.Size = new System.Drawing.Size(157, 49);
            this.employeeNameSurnameLabel.TabIndex = 7;
            this.employeeNameSurnameLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(132, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last record";
            // 
            // lastRecordLabel
            // 
            this.lastRecordLabel.AutoSize = true;
            this.lastRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastRecordLabel.Location = new System.Drawing.Point(132, 88);
            this.lastRecordLabel.Name = "lastRecordLabel";
            this.lastRecordLabel.Size = new System.Drawing.Size(166, 25);
            this.lastRecordLabel.TabIndex = 12;
            this.lastRecordLabel.Text = "string HH:MM:SS";
            // 
            // employeeStatusImage
            // 
            this.employeeStatusImage.Location = new System.Drawing.Point(12, 12);
            this.employeeStatusImage.Name = "employeeStatusImage";
            this.employeeStatusImage.Size = new System.Drawing.Size(100, 100);
            this.employeeStatusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employeeStatusImage.TabIndex = 13;
            this.employeeStatusImage.TabStop = false;
            // 
            // EmployeeStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.employeeStatusImage);
            this.Controls.Add(this.lastRecordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeNameSurnameLabel);
            this.Name = "EmployeeStatusControl";
            this.Size = new System.Drawing.Size(400, 122);
            ((System.ComponentModel.ISupportInitialize)(this.employeeStatusImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeeNameSurnameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lastRecordLabel;
        private System.Windows.Forms.PictureBox employeeStatusImage;
    }
}
