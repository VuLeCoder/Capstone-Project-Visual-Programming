namespace BtlApp
{
    partial class FormMyTask
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_createTask = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tlp_mainCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_mainCalendarHeader = new System.Windows.Forms.TableLayoutPanel();
            this.uiGroupBox1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Black;
            this.monthCalendar1.ForeColor = System.Drawing.Color.White;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 101);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btn_createTask
            // 
            this.btn_createTask.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_createTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.btn_createTask.FillColor2 = System.Drawing.Color.White;
            this.btn_createTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_createTask.Location = new System.Drawing.Point(62, 35);
            this.btn_createTask.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_createTask.Name = "btn_createTask";
            this.btn_createTask.Radius = 20;
            this.btn_createTask.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.btn_createTask.Size = new System.Drawing.Size(128, 36);
            this.btn_createTask.TabIndex = 1;
            this.btn_createTask.Text = "Tạo";
            this.btn_createTask.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.monthCalendar1);
            this.uiGroupBox1.Controls.Add(this.btn_createTask);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiGroupBox1.FillColor = System.Drawing.Color.White;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(10, 10);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.White;
            this.uiGroupBox1.Size = new System.Drawing.Size(255, 591);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Controls.Add(this.tlp_mainCalendarHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(265, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(909, 591);
            this.panelMain.TabIndex = 3;
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.tlp_mainCalendar);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 53);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(909, 538);
            this.panelBody.TabIndex = 1;
            // 
            // tlp_mainCalendar
            // 
            this.tlp_mainCalendar.AutoSize = true;
            this.tlp_mainCalendar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp_mainCalendar.ColumnCount = 2;
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_mainCalendar.Location = new System.Drawing.Point(0, 0);
            this.tlp_mainCalendar.Name = "tlp_mainCalendar";
            this.tlp_mainCalendar.RowCount = 3;
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_mainCalendar.Size = new System.Drawing.Size(909, 24);
            this.tlp_mainCalendar.TabIndex = 1;
            // 
            // tlp_mainCalendarHeader
            // 
            this.tlp_mainCalendarHeader.ColumnCount = 2;
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendarHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_mainCalendarHeader.Location = new System.Drawing.Point(0, 0);
            this.tlp_mainCalendarHeader.Name = "tlp_mainCalendarHeader";
            this.tlp_mainCalendarHeader.RowCount = 1;
            this.tlp_mainCalendarHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendarHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_mainCalendarHeader.Size = new System.Drawing.Size(909, 53);
            this.tlp_mainCalendarHeader.TabIndex = 0;
            // 
            // FormMyTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMyTask";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyTask";
            this.uiGroupBox1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Sunny.UI.UIButton btn_createTask;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tlp_mainCalendarHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TableLayoutPanel tlp_mainCalendar;
    }
}

