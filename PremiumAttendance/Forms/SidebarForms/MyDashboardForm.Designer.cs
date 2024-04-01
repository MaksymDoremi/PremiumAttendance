namespace PremiumAttendance.Forms.SidebarForms
{
    partial class MyDashboardForm
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
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.colleaguesAtWorkFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.welcomeMessagePanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.apiResponseHolidayLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.apiResponseNameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.welcomeMessageLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.reportPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.workedDaysLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.workedHoursLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeMessagePanel)).BeginInit();
            this.welcomeMessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportPanel)).BeginInit();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 355);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(259, 36);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Colleagues at work:\r\n";
            // 
            // colleaguesAtWorkFlowLayoutPanel
            // 
            this.colleaguesAtWorkFlowLayoutPanel.AutoScroll = true;
            this.colleaguesAtWorkFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colleaguesAtWorkFlowLayoutPanel.Location = new System.Drawing.Point(12, 408);
            this.colleaguesAtWorkFlowLayoutPanel.Name = "colleaguesAtWorkFlowLayoutPanel";
            this.colleaguesAtWorkFlowLayoutPanel.Size = new System.Drawing.Size(1245, 283);
            this.colleaguesAtWorkFlowLayoutPanel.TabIndex = 1;
            // 
            // welcomeMessagePanel
            // 
            this.welcomeMessagePanel.Controls.Add(this.apiResponseHolidayLabel);
            this.welcomeMessagePanel.Controls.Add(this.apiResponseNameLabel);
            this.welcomeMessagePanel.Controls.Add(this.welcomeMessageLabel);
            this.welcomeMessagePanel.Location = new System.Drawing.Point(12, 12);
            this.welcomeMessagePanel.Name = "welcomeMessagePanel";
            this.welcomeMessagePanel.Size = new System.Drawing.Size(536, 243);
            this.welcomeMessagePanel.StateCommon.Color1 = System.Drawing.Color.Ivory;
            this.welcomeMessagePanel.TabIndex = 2;
            // 
            // apiResponseHolidayLabel
            // 
            this.apiResponseHolidayLabel.AutoSize = false;
            this.apiResponseHolidayLabel.Location = new System.Drawing.Point(3, 175);
            this.apiResponseHolidayLabel.Name = "apiResponseHolidayLabel";
            this.apiResponseHolidayLabel.Size = new System.Drawing.Size(530, 50);
            this.apiResponseHolidayLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apiResponseHolidayLabel.TabIndex = 2;
            this.apiResponseHolidayLabel.Values.Text = "No holiday for today.";
            // 
            // apiResponseNameLabel
            // 
            this.apiResponseNameLabel.AutoSize = false;
            this.apiResponseNameLabel.Location = new System.Drawing.Point(3, 86);
            this.apiResponseNameLabel.Name = "apiResponseNameLabel";
            this.apiResponseNameLabel.Size = new System.Drawing.Size(530, 50);
            this.apiResponseNameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.apiResponseNameLabel.TabIndex = 1;
            this.apiResponseNameLabel.Values.Text = "Today\'s day is for:";
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.AutoSize = false;
            this.welcomeMessageLabel.Location = new System.Drawing.Point(3, 3);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(530, 50);
            this.welcomeMessageLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Values.Text = "Welcome, username";
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.kryptonLabel2);
            this.reportPanel.Controls.Add(this.workedHoursLabel);
            this.reportPanel.Controls.Add(this.workedDaysLabel);
            this.reportPanel.Location = new System.Drawing.Point(721, 12);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(536, 243);
            this.reportPanel.StateCommon.Color1 = System.Drawing.Color.Ivory;
            this.reportPanel.TabIndex = 3;
            // 
            // workedDaysLabel
            // 
            this.workedDaysLabel.AutoSize = false;
            this.workedDaysLabel.Location = new System.Drawing.Point(3, 81);
            this.workedDaysLabel.Name = "workedDaysLabel";
            this.workedDaysLabel.Size = new System.Drawing.Size(530, 50);
            this.workedDaysLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workedDaysLabel.TabIndex = 1;
            this.workedDaysLabel.Values.Text = "Total worked days: \r\n";
            // 
            // workedHoursLabel
            // 
            this.workedHoursLabel.AutoSize = false;
            this.workedHoursLabel.Location = new System.Drawing.Point(3, 160);
            this.workedHoursLabel.Name = "workedHoursLabel";
            this.workedHoursLabel.Size = new System.Drawing.Size(530, 50);
            this.workedHoursLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.workedHoursLabel.TabIndex = 2;
            this.workedHoursLabel.Values.Text = "Total worked hours: \r\n";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(135, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "This month";
            // 
            // MyDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.welcomeMessagePanel);
            this.Controls.Add(this.colleaguesAtWorkFlowLayoutPanel);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "MyDashboardForm";
            this.Text = "MyDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.welcomeMessagePanel)).EndInit();
            this.welcomeMessagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportPanel)).EndInit();
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.FlowLayoutPanel colleaguesAtWorkFlowLayoutPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel welcomeMessagePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel welcomeMessageLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel apiResponseHolidayLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel apiResponseNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel reportPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel workedHoursLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel workedDaysLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}