namespace BtlApp
{
    partial class Form_MySchedule
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.panelAside = new System.Windows.Forms.Panel();
            this.monthCalendar = new Krypton.Toolkit.KryptonMonthCalendar();
            this.btn_AddSchedule = new Sunny.UI.UIButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainBody = new System.Windows.Forms.Panel();
            this.tlp_mainCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_mainCalendarHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelAside.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelHeader.Controls.Add(this.uiButton3);
            this.panelHeader.Controls.Add(this.uiButton2);
            this.panelHeader.Controls.Add(this.uiButton1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.White;
            this.uiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton3.ForeColor = System.Drawing.Color.Black;
            this.uiButton3.Location = new System.Drawing.Point(1029, 9);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Radius = 40;
            this.uiButton3.RectColor = System.Drawing.Color.Silver;
            this.uiButton3.Size = new System.Drawing.Size(40, 40);
            this.uiButton3.TabIndex = 2;
            this.uiButton3.Text = "🔔";
            this.uiButton3.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.White;
            this.uiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton2.ForeColor = System.Drawing.Color.Black;
            this.uiButton2.Location = new System.Drawing.Point(1084, 9);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 40;
            this.uiButton2.RectColor = System.Drawing.Color.Silver;
            this.uiButton2.Size = new System.Drawing.Size(40, 40);
            this.uiButton2.TabIndex = 1;
            this.uiButton2.Text = "⚙️";
            this.uiButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.Location = new System.Drawing.Point(1138, 9);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 40;
            this.uiButton1.Size = new System.Drawing.Size(40, 40);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "V";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // panelAside
            // 
            this.panelAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelAside.Controls.Add(this.monthCalendar);
            this.panelAside.Controls.Add(this.btn_AddSchedule);
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAside.Location = new System.Drawing.Point(0, 60);
            this.panelAside.Margin = new System.Windows.Forms.Padding(0);
            this.panelAside.Name = "panelAside";
            this.panelAside.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelAside.Size = new System.Drawing.Size(240, 540);
            this.panelAside.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(5, 80);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Size = new System.Drawing.Size(293, 218);
            this.monthCalendar.StateCheckedNormal.Day.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.monthCalendar.StateCheckedNormal.Day.Border.Color1 = System.Drawing.Color.LightSkyBlue;
            this.monthCalendar.StateCheckedTracking.Day.Back.Color1 = System.Drawing.Color.Gray;
            this.monthCalendar.StateCheckedTracking.Day.Border.Color1 = System.Drawing.Color.Gray;
            this.monthCalendar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.monthCalendar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.monthCalendar.StateNormal.Day.Back.Color1 = System.Drawing.Color.Black;
            this.monthCalendar.StateNormal.Day.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.monthCalendar.StateNormal.DayOfWeek.Back.Color1 = System.Drawing.Color.Black;
            this.monthCalendar.StateNormal.DayOfWeek.Border.Color1 = System.Drawing.Color.Black;
            this.monthCalendar.StateNormal.DayOfWeek.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.monthCalendar.StateNormal.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.monthCalendar.StateNormal.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.monthCalendar.StateNormal.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.monthCalendar.StatePressed.Day.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.monthCalendar.StatePressed.Day.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.monthCalendar.StateTracking.Day.Back.Color1 = System.Drawing.Color.Gray;
            this.monthCalendar.StateTracking.Day.Border.Color1 = System.Drawing.Color.Gray;
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // btn_AddSchedule
            // 
            this.btn_AddSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AddSchedule.Location = new System.Drawing.Point(50, 21);
            this.btn_AddSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddSchedule.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_AddSchedule.Name = "btn_AddSchedule";
            this.btn_AddSchedule.Radius = 15;
            this.btn_AddSchedule.Size = new System.Drawing.Size(130, 35);
            this.btn_AddSchedule.TabIndex = 1;
            this.btn_AddSchedule.Text = "Tạo lịch mới";
            this.btn_AddSchedule.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_AddSchedule.Click += new System.EventHandler(this.btn_AddSchedule_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.panelMainBody);
            this.panelMain.Controls.Add(this.tlp_mainCalendarHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(240, 60);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelMain.Size = new System.Drawing.Size(960, 540);
            this.panelMain.TabIndex = 2;
            // 
            // panelMainBody
            // 
            this.panelMainBody.AutoScroll = true;
            this.panelMainBody.Controls.Add(this.tlp_mainCalendar);
            this.panelMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBody.Location = new System.Drawing.Point(10, 56);
            this.panelMainBody.Name = "panelMainBody";
            this.panelMainBody.Size = new System.Drawing.Size(950, 484);
            this.panelMainBody.TabIndex = 2;
            // 
            // tlp_mainCalendar
            // 
            this.tlp_mainCalendar.AutoSize = true;
            this.tlp_mainCalendar.BackColor = System.Drawing.Color.White;
            this.tlp_mainCalendar.ColumnCount = 8;
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.33758F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.66242F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlp_mainCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_mainCalendar.Location = new System.Drawing.Point(0, 0);
            this.tlp_mainCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_mainCalendar.Name = "tlp_mainCalendar";
            this.tlp_mainCalendar.RowCount = 3;
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.Size = new System.Drawing.Size(950, 20);
            this.tlp_mainCalendar.TabIndex = 2;
            // 
            // tlp_mainCalendarHeader
            // 
            this.tlp_mainCalendarHeader.BackColor = System.Drawing.Color.White;
            this.tlp_mainCalendarHeader.ColumnCount = 3;
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.33758F));
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.66242F));
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 389F));
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_mainCalendarHeader.Location = new System.Drawing.Point(10, 0);
            this.tlp_mainCalendarHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_mainCalendarHeader.Name = "tlp_mainCalendarHeader";
            this.tlp_mainCalendarHeader.RowCount = 1;
            this.tlp_mainCalendarHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendarHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendarHeader.Size = new System.Drawing.Size(950, 56);
            this.tlp_mainCalendarHeader.TabIndex = 1;
            // 
            // Form_MySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_MySchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTask";
            this.panelHeader.ResumeLayout(false);
            this.panelAside.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMainBody.ResumeLayout(false);
            this.panelMainBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelAside;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMainBody;
        private System.Windows.Forms.TableLayoutPanel tlp_mainCalendar;
        private System.Windows.Forms.TableLayoutPanel tlp_mainCalendarHeader;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton btn_AddSchedule;
        private Krypton.Toolkit.KryptonMonthCalendar monthCalendar;
    }
}

