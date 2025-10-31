namespace BtlApp.Individual
{
    partial class Form_AddMySchedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_StartHour = new System.Windows.Forms.ComboBox();
            this.cb_EndHour = new System.Windows.Forms.ComboBox();
            this.btn_Add = new Sunny.UI.UIButton();
            this.btn_Save = new Sunny.UI.UIButton();
            this.btn_Cancel = new Sunny.UI.UIButton();
            this.btn_Delete = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ bắt đầu";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Location = new System.Drawing.Point(202, 129);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(317, 30);
            this.dtp_Date.TabIndex = 1;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(202, 72);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(317, 30);
            this.txt_Title.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ kết thúc";
            // 
            // cb_StartHour
            // 
            this.cb_StartHour.DropDownHeight = 120;
            this.cb_StartHour.FormattingEnabled = true;
            this.cb_StartHour.IntegralHeight = false;
            this.cb_StartHour.Location = new System.Drawing.Point(204, 186);
            this.cb_StartHour.MaxDropDownItems = 5;
            this.cb_StartHour.Name = "cb_StartHour";
            this.cb_StartHour.Size = new System.Drawing.Size(134, 33);
            this.cb_StartHour.TabIndex = 2;
            // 
            // cb_EndHour
            // 
            this.cb_EndHour.DropDownHeight = 120;
            this.cb_EndHour.FormattingEnabled = true;
            this.cb_EndHour.IntegralHeight = false;
            this.cb_EndHour.Location = new System.Drawing.Point(204, 247);
            this.cb_EndHour.MaxDropDownItems = 5;
            this.cb_EndHour.Name = "cb_EndHour";
            this.cb_EndHour.Size = new System.Drawing.Size(134, 33);
            this.cb_EndHour.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Enabled = false;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Add.Location = new System.Drawing.Point(90, 340);
            this.btn_Add.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Radius = 20;
            this.btn_Add.Size = new System.Drawing.Size(144, 43);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Save.Location = new System.Drawing.Point(375, 340);
            this.btn_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Radius = 20;
            this.btn_Save.Size = new System.Drawing.Size(144, 43);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(375, 416);
            this.btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Radius = 20;
            this.btn_Cancel.Size = new System.Drawing.Size(144, 43);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Delete.Location = new System.Drawing.Point(90, 416);
            this.btn_Delete.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Radius = 20;
            this.btn_Delete.Size = new System.Drawing.Size(144, 43);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Form_AddMySchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 508);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cb_EndHour);
            this.Controls.Add(this.cb_StartHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddMySchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddMySchedule";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_AddMySchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_StartHour;
        private System.Windows.Forms.ComboBox cb_EndHour;
        private Sunny.UI.UIButton btn_Add;
        private Sunny.UI.UIButton btn_Save;
        private Sunny.UI.UIButton btn_Cancel;
        private Sunny.UI.UIButton btn_Delete;
    }
}