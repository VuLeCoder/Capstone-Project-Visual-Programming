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
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_MySchedule = new Sunny.UI.UIButton();
            this.btn_MyTodolist = new Sunny.UI.UIButton();
            this.tlp_Group = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Group = new System.Windows.Forms.Panel();
            this.btn_CreateGroup = new Sunny.UI.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.uiButton3);
            this.panelHeader.Controls.Add(this.uiButton1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(5, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(739, 50);
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
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.White;
            this.uiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton3.ForeColor = System.Drawing.Color.Black;
            this.uiButton3.Location = new System.Drawing.Point(610, 5);
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
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiButton1.Location = new System.Drawing.Point(665, 5);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 40;
            this.uiButton1.Size = new System.Drawing.Size(40, 40);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "V";
            this.uiButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(5, 55);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(739, 333);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_MyTodolist);
            this.tabPage1.Controls.Add(this.btn_MySchedule);
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(534, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_CreateGroup);
            this.tabPage2.Controls.Add(this.panel_Group);
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(538, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhóm";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tlp_Group
            // 
            this.tlp_Group.ColumnCount = 3;
            this.tlp_Group.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.62295F));
            this.tlp_Group.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.37705F));
            this.tlp_Group.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlp_Group.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Group.Location = new System.Drawing.Point(3, 3);
            this.tlp_Group.Name = "tlp_Group";
            this.tlp_Group.RowCount = 2;
            this.tlp_Group.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Group.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Group.Size = new System.Drawing.Size(532, 100);
            this.tlp_Group.TabIndex = 0;
            // 
            // panel_Group
            // 
            this.panel_Group.Controls.Add(this.tlp_Group);
            this.panel_Group.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Group.Location = new System.Drawing.Point(0, 90);
            this.panel_Group.Name = "panel_Group";
            this.panel_Group.Padding = new System.Windows.Forms.Padding(3);
            this.panel_Group.Size = new System.Drawing.Size(538, 243);
            this.panel_Group.TabIndex = 1;
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CreateGroup.Location = new System.Drawing.Point(15, 16);
            this.btn_CreateGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(124, 35);
            this.btn_CreateGroup.TabIndex = 2;
            this.btn_CreateGroup.Text = "Tạo nhóm mới";
            this.btn_CreateGroup.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
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
            // Form_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(749, 393);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Manager";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Manager";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton btn_MyTodolist;
        private Sunny.UI.UIButton btn_MySchedule;
        private Sunny.UI.UIButton btn_CreateGroup;
        private System.Windows.Forms.Panel panel_Group;
        private System.Windows.Forms.TableLayoutPanel tlp_Group;
        private System.Windows.Forms.Label label2;
    }
}