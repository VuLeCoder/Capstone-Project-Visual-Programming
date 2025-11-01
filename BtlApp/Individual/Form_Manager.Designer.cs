namespace BtlApp.Individual
{
    partial class Form_Manager
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu_User = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Notification = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_User = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CreateGroup = new Sunny.UI.UIButton();
            this.panel_group = new System.Windows.Forms.Panel();
            this.flp_group = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_MyTodolist = new Sunny.UI.UIButton();
            this.btn_MySchedule = new Sunny.UI.UIButton();
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.btn_Participate = new Sunny.UI.UIButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu_User.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_group.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.uiTabControlMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.menu_User);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(5, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(817, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BtlApp.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 5);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Btl_Schedule";
            // 
            // menu_User
            // 
            this.menu_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.menu_User.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_User.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu_User.GripMargin = new System.Windows.Forms.Padding(0);
            this.menu_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Notification,
            this.MenuItem_User});
            this.menu_User.Location = new System.Drawing.Point(634, 5);
            this.menu_User.Name = "menu_User";
            this.menu_User.Padding = new System.Windows.Forms.Padding(0);
            this.menu_User.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_User.Size = new System.Drawing.Size(172, 40);
            this.menu_User.TabIndex = 2;
            this.menu_User.Text = "menuStrip1";
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
            // MenuItem_User
            // 
            this.MenuItem_User.AutoSize = false;
            this.MenuItem_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.MenuItem_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem});
            this.MenuItem_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MenuItem_User.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MenuItem_User.Name = "MenuItem_User";
            this.MenuItem_User.Size = new System.Drawing.Size(80, 40);
            this.MenuItem_User.Text = "User";
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
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.AutoSize = false;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.BarName = "parentBarItem1";
            this.parentBarItem1.Manager = null;
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.SizeToFit = true;
            this.parentBarItem1.WrapLength = 20;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.BarName = "parentBarItem2";
            this.parentBarItem2.Manager = null;
            this.parentBarItem2.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem2.ShowToolTipInPopUp = false;
            this.parentBarItem2.SizeToFit = true;
            this.parentBarItem2.WrapLength = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Participate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_CreateGroup);
            this.tabPage2.Controls.Add(this.panel_group);
            this.tabPage2.Location = new System.Drawing.Point(161, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(656, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Các nhóm đã tham gia";
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CreateGroup.Location = new System.Drawing.Point(15, 16);
            this.btn_CreateGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(130, 35);
            this.btn_CreateGroup.TabIndex = 2;
            this.btn_CreateGroup.Text = "Tạo nhóm mới";
            this.btn_CreateGroup.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_CreateGroup.Click += new System.EventHandler(this.btn_CreateGroup_Click);
            // 
            // panel_group
            // 
            this.panel_group.AutoScroll = true;
            this.panel_group.Controls.Add(this.flp_group);
            this.panel_group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_group.Location = new System.Drawing.Point(0, 90);
            this.panel_group.Name = "panel_group";
            this.panel_group.Padding = new System.Windows.Forms.Padding(3);
            this.panel_group.Size = new System.Drawing.Size(656, 243);
            this.panel_group.TabIndex = 1;
            // 
            // flp_group
            // 
            this.flp_group.AutoSize = true;
            this.flp_group.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_group.Location = new System.Drawing.Point(3, 3);
            this.flp_group.Name = "flp_group";
            this.flp_group.Size = new System.Drawing.Size(650, 0);
            this.flp_group.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_MyTodolist);
            this.tabPage1.Controls.Add(this.btn_MySchedule);
            this.tabPage1.Location = new System.Drawing.Point(161, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(656, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_MyTodolist
            // 
            this.btn_MyTodolist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MyTodolist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_MyTodolist.Location = new System.Drawing.Point(28, 70);
            this.btn_MyTodolist.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_MyTodolist.Name = "btn_MyTodolist";
            this.btn_MyTodolist.Size = new System.Drawing.Size(163, 35);
            this.btn_MyTodolist.TabIndex = 1;
            this.btn_MyTodolist.Text = "Xem việc cần làm";
            this.btn_MyTodolist.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btn_MySchedule
            // 
            this.btn_MySchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MySchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_MySchedule.Location = new System.Drawing.Point(28, 19);
            this.btn_MySchedule.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_MySchedule.Name = "btn_MySchedule";
            this.btn_MySchedule.Size = new System.Drawing.Size(163, 35);
            this.btn_MySchedule.TabIndex = 0;
            this.btn_MySchedule.Text = "Xem lịch cá nhân";
            this.btn_MySchedule.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_MySchedule.Click += new System.EventHandler(this.btn_MySchedule_Click);
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(160, 40);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(5, 55);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(817, 333);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 5;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.BarName = "parentBarItem3";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3});
            this.parentBarItem3.Manager = null;
            this.parentBarItem3.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem3.ShowToolTipInPopUp = false;
            this.parentBarItem3.SizeToFit = true;
            this.parentBarItem3.WrapLength = 20;
            // 
            // barItem1
            // 
            this.barItem1.BarName = "barItem1";
            this.barItem1.ShowToolTipInPopUp = false;
            this.barItem1.SizeToFit = true;
            // 
            // barItem2
            // 
            this.barItem2.BarName = "barItem2";
            this.barItem2.ShowToolTipInPopUp = false;
            this.barItem2.SizeToFit = true;
            // 
            // barItem3
            // 
            this.barItem3.BarName = "barItem3";
            this.barItem3.ShowToolTipInPopUp = false;
            this.barItem3.SizeToFit = true;
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.BarName = "parentBarItem4";
            this.parentBarItem4.Manager = null;
            this.parentBarItem4.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem4.ShowToolTipInPopUp = false;
            this.parentBarItem4.SizeToFit = true;
            this.parentBarItem4.WrapLength = 20;
            // 
            // btn_Participate
            // 
            this.btn_Participate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Participate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Participate.Location = new System.Drawing.Point(167, 16);
            this.btn_Participate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Participate.Name = "btn_Participate";
            this.btn_Participate.Size = new System.Drawing.Size(130, 35);
            this.btn_Participate.TabIndex = 4;
            this.btn_Participate.Text = "Tham gia nhóm";
            this.btn_Participate.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(827, 393);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MainMenuStrip = this.menu_User;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Manager";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Form_Manager_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu_User.ResumeLayout(false);
            this.menu_User.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_group.ResumeLayout(false);
            this.panel_group.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UIButton btn_MyTodolist;
        private Sunny.UI.UIButton btn_MySchedule;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btn_CreateGroup;
        private System.Windows.Forms.Panel panel_group;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private System.Windows.Forms.MenuStrip menu_User;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Notification;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_User;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flp_group;
        private Sunny.UI.UIButton btn_Participate;
    }
}