namespace BtlApp.Group
{
    partial class Form_GroupSchedule
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
            this.menu_Group = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Notification = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Group = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_GroupName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAside = new System.Windows.Forms.Panel();
            this.dgv_Infor = new System.Windows.Forms.DataGridView();
            this.btn_Return = new Sunny.UI.UIButton();
            this.monthCalendar = new Krypton.Toolkit.KryptonMonthCalendar();
            this.btn_AddSchedule = new Sunny.UI.UIButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMainBody = new System.Windows.Forms.Panel();
            this.tlp_mainCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_mainCalendarHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.menu_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Infor)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelMainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelHeader.Controls.Add(this.menu_Group);
            this.panelHeader.Controls.Add(this.lbl_GroupName);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // menu_Group
            // 
            this.menu_Group.BackColor = System.Drawing.Color.Black;
            this.menu_Group.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_Group.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_Group.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu_Group.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_Group.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Notification,
            this.MenuItem_Group});
            this.menu_Group.Location = new System.Drawing.Point(1016, 9);
            this.menu_Group.Name = "menu_Group";
            this.menu_Group.Padding = new System.Windows.Forms.Padding(0);
            this.menu_Group.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_Group.Size = new System.Drawing.Size(172, 40);
            this.menu_Group.TabIndex = 7;
            this.menu_Group.Text = "menuStrip1";
            // 
            // MenuItem_Notification
            // 
            this.MenuItem_Notification.AutoSize = false;
            this.MenuItem_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MenuItem_Notification.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuItem_Notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MenuItem_Notification.Name = "MenuItem_Notification";
            this.MenuItem_Notification.Size = new System.Drawing.Size(80, 40);
            this.MenuItem_Notification.Text = "Notification";
            // 
            // MenuItem_Group
            // 
            this.MenuItem_Group.AutoSize = false;
            this.MenuItem_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MenuItem_Group.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.toolStripMenuItem2});
            this.MenuItem_Group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MenuItem_Group.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MenuItem_Group.Name = "MenuItem_Group";
            this.MenuItem_Group.Size = new System.Drawing.Size(80, 40);
            this.MenuItem_Group.Text = "Group";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.AutoSize = false;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem2.Text = "Setting";
            // 
            // lbl_GroupName
            // 
            this.lbl_GroupName.AutoSize = true;
            this.lbl_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GroupName.Location = new System.Drawing.Point(258, 20);
            this.lbl_GroupName.Name = "lbl_GroupName";
            this.lbl_GroupName.Size = new System.Drawing.Size(88, 20);
            this.lbl_GroupName.TabIndex = 6;
            this.lbl_GroupName.Text = "Tên nhóm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BtlApp.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Btl_Schedule";
            // 
            // panelAside
            // 
            this.panelAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelAside.Controls.Add(this.dgv_Infor);
            this.panelAside.Controls.Add(this.btn_Return);
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
            // dgv_Infor
            // 
            this.dgv_Infor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Infor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Infor.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Infor.Location = new System.Drawing.Point(5, 322);
            this.dgv_Infor.Name = "dgv_Infor";
            this.dgv_Infor.RowHeadersWidth = 51;
            this.dgv_Infor.RowTemplate.Height = 24;
            this.dgv_Infor.Size = new System.Drawing.Size(230, 206);
            this.dgv_Infor.TabIndex = 4;
            // 
            // btn_Return
            // 
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Return.Location = new System.Drawing.Point(42, 266);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Return.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Radius = 15;
            this.btn_Return.Size = new System.Drawing.Size(153, 35);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "Quay về trang chủ";
            this.btn_Return.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(5, 80);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Size = new System.Drawing.Size(230, 182);
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
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
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
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
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
            // Form_GroupSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GroupSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupTask";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_GroupSchedule_FormClosed);
            this.Load += new System.EventHandler(this.Form_GroupSchedule_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.menu_Group.ResumeLayout(false);
            this.menu_Group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Infor)).EndInit();
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
        private Sunny.UI.UIButton btn_AddSchedule;
        private Krypton.Toolkit.KryptonMonthCalendar monthCalendar;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btn_Return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_GroupName;
        private System.Windows.Forms.MenuStrip menu_Group;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Notification;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Group;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgv_Infor;
    }
}

