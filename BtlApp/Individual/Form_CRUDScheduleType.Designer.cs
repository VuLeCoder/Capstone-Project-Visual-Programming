namespace BtlApp.Individual
{
    partial class Form_CRUDScheduleType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cp_Color = new Sunny.UI.UIColorPicker();
            this.dgv_ScheduleType = new System.Windows.Forms.DataGridView();
            this.btn_AddNewType = new Sunny.UI.UIButton();
            this.btn_Save = new Sunny.UI.UIButton();
            this.btn_Delete = new Sunny.UI.UIButton();
            this.btn_Cancel = new Sunny.UI.UIButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cp_Color);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule type detail";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(63, 35);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(160, 26);
            this.txt_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(349, 35);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(227, 90);
            this.txt_Description.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color";
            // 
            // cp_Color
            // 
            this.cp_Color.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cp_Color.FillColor = System.Drawing.Color.White;
            this.cp_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cp_Color.Location = new System.Drawing.Point(63, 81);
            this.cp_Color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cp_Color.MinimumSize = new System.Drawing.Size(63, 0);
            this.cp_Color.Name = "cp_Color";
            this.cp_Color.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cp_Color.Size = new System.Drawing.Size(113, 26);
            this.cp_Color.SymbolSize = 24;
            this.cp_Color.TabIndex = 5;
            this.cp_Color.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cp_Color.Watermark = "";
            // 
            // dgv_ScheduleType
            // 
            this.dgv_ScheduleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ScheduleType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ScheduleType.Location = new System.Drawing.Point(22, 154);
            this.dgv_ScheduleType.Name = "dgv_ScheduleType";
            this.dgv_ScheduleType.Size = new System.Drawing.Size(566, 157);
            this.dgv_ScheduleType.TabIndex = 1;
            this.dgv_ScheduleType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ScheduleType_CellClick);
            this.dgv_ScheduleType.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ScheduleType_CellFormatting);
            // 
            // btn_AddNewType
            // 
            this.btn_AddNewType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNewType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_AddNewType.Location = new System.Drawing.Point(22, 335);
            this.btn_AddNewType.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_AddNewType.Name = "btn_AddNewType";
            this.btn_AddNewType.Radius = 15;
            this.btn_AddNewType.Size = new System.Drawing.Size(112, 35);
            this.btn_AddNewType.TabIndex = 2;
            this.btn_AddNewType.Text = "Add";
            this.btn_AddNewType.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_AddNewType.Click += new System.EventHandler(this.btn_AddNewType_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Save.Location = new System.Drawing.Point(171, 335);
            this.btn_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Radius = 15;
            this.btn_Save.Size = new System.Drawing.Size(112, 35);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Delete.Location = new System.Drawing.Point(322, 335);
            this.btn_Delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Radius = 15;
            this.btn_Delete.Size = new System.Drawing.Size(112, 35);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(476, 335);
            this.btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Radius = 15;
            this.btn_Cancel.Size = new System.Drawing.Size(112, 35);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form_CRUDScheduleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 394);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_AddNewType);
            this.Controls.Add(this.dgv_ScheduleType);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CRUDScheduleType";
            this.Text = "ScheduleType";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CRUDScheduleType_FormClosed);
            this.Load += new System.EventHandler(this.Form_CRUDScheduleType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIColorPicker cp_Color;
        private System.Windows.Forms.DataGridView dgv_ScheduleType;
        private Sunny.UI.UIButton btn_AddNewType;
        private Sunny.UI.UIButton btn_Save;
        private Sunny.UI.UIButton btn_Delete;
        private Sunny.UI.UIButton btn_Cancel;
    }
}