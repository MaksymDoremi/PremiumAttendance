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
            this.colleaguesAtWorkFlowLayoutPanel.Location = new System.Drawing.Point(12, 408);
            this.colleaguesAtWorkFlowLayoutPanel.Name = "colleaguesAtWorkFlowLayoutPanel";
            this.colleaguesAtWorkFlowLayoutPanel.Size = new System.Drawing.Size(1245, 283);
            this.colleaguesAtWorkFlowLayoutPanel.TabIndex = 1;
            // 
            // MyDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1269, 703);
            this.Controls.Add(this.colleaguesAtWorkFlowLayoutPanel);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "MyDashboardForm";
            this.Text = "MyDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.FlowLayoutPanel colleaguesAtWorkFlowLayoutPanel;
    }
}