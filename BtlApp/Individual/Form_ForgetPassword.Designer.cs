namespace BtlApp.Individual
{
    partial class Form_ForgetPassword
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
            this.btn_Find = new Sunny.UI.UIButton();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new Sunny.UI.UIButton();
            this.lbl_Notification = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Find
            // 
            this.btn_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(238, 120);
            this.btn_Find.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Radius = 20;
            this.btn_Find.Size = new System.Drawing.Size(128, 35);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Tìm kiếm";
            this.btn_Find.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(157, 70);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(209, 26);
            this.txt_Email.TabIndex = 1;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(143, 120);
            this.btn_Cancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Radius = 20;
            this.btn_Cancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.btn_Cancel.Size = new System.Drawing.Size(76, 35);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Notification
            // 
            this.lbl_Notification.AutoSize = true;
            this.lbl_Notification.Location = new System.Drawing.Point(87, 174);
            this.lbl_Notification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Notification.Name = "lbl_Notification";
            this.lbl_Notification.Size = new System.Drawing.Size(0, 20);
            this.lbl_Notification.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập email để lấy lại mật khẩu";
            // 
            // Form_ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Notification);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ForgetPassword";
            this.Text = "ForgetPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_ForgetPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btn_Find;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIButton btn_Cancel;
        private System.Windows.Forms.Label lbl_Notification;
        private System.Windows.Forms.Label label2;
    }
}