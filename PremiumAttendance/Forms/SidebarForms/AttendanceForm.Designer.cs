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
            this.monthLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.previousMonthBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // attendanceTableLayoutPanel
            // 
            this.attendanceTableLayoutPanel.AutoScroll = true;
            this.attendanceTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1245F));
            this.attendanceTableLayoutPanel.Location = new System.Drawing.Point(12, 143);
            this.attendanceTableLayoutPanel.MaximumSize = new System.Drawing.Size(1260, 580);
            this.attendanceTableLayoutPanel.Name = "attendanceTableLayoutPanel";
            this.attendanceTableLayoutPanel.Size = new System.Drawing.Size(1245, 580);
            this.attendanceTableLayoutPanel.TabIndex = 0;
            // 
            // monthLabel
            // 
            this.monthLabel.Location = new System.Drawing.Point(48, 12);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(141, 31);
            this.monthLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Values.Text = "Month Year";
            // 
            // previousMonthBtn
            // 
            this.previousMonthBtn.Location = new System.Drawing.Point(48, 66);
            this.previousMonthBtn.Name = "previousMonthBtn";
            this.previousMonthBtn.Size = new System.Drawing.Size(141, 45);
            this.previousMonthBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.previousMonthBtn.StateCommon.Border.Rounding = 20;
            this.previousMonthBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previousMonthBtn.StatePressed.Back.Color1 = System.Drawing.Color.Gray;
            this.previousMonthBtn.StatePressed.Back.Color2 = System.Drawing.Color.Gray;
            this.previousMonthBtn.StatePressed.Border.Color1 = System.Drawing.Color.Gray;
            this.previousMonthBtn.StatePressed.Border.Color2 = System.Drawing.Color.Gray;
            this.previousMonthBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.previousMonthBtn.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.previousMonthBtn.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.previousMonthBtn.StateTracking.Border.Color1 = System.Drawing.Color.Silver;
            this.previousMonthBtn.StateTracking.Border.Color2 = System.Drawing.Color.Silver;
            this.previousMonthBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.previousMonthBtn.TabIndex = 2;
            this.previousMonthBtn.Values.Text = "<< Previous";
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 734);
            this.Controls.Add(this.previousMonthBtn);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.attendanceTableLayoutPanel);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel attendanceTableLayoutPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel monthLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton previousMonthBtn;
    }
}