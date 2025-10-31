namespace BtlApp
{
    partial class Form_Login
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new Sunny.UI.UIButton();
            this.link_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.btn_CreateAcc = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(201, 56);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(195, 26);
            this.txt_Email.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(201, 105);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '.';
            this.txt_Password.Size = new System.Drawing.Size(195, 26);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(121, 165);
            this.btn_Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Radius = 20;
            this.btn_Login.Size = new System.Drawing.Size(275, 35);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // link_ForgotPass
            // 
            this.link_ForgotPass.AutoSize = true;
            this.link_ForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_ForgotPass.Location = new System.Drawing.Point(198, 213);
            this.link_ForgotPass.Name = "link_ForgotPass";
            this.link_ForgotPass.Size = new System.Drawing.Size(121, 17);
            this.link_ForgotPass.TabIndex = 6;
            this.link_ForgotPass.TabStop = true;
            this.link_ForgotPass.Text = "Forgot password?";
            this.link_ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ForgotPass_LinkClicked);
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAcc.Location = new System.Drawing.Point(149, 258);
            this.btn_CreateAcc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Radius = 20;
            this.btn_CreateAcc.Size = new System.Drawing.Size(216, 37);
            this.btn_CreateAcc.TabIndex = 7;
            this.btn_CreateAcc.Text = "Create a new account";
            this.btn_CreateAcc.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAcc.Click += new System.EventHandler(this.btn_CreateAcc_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.btn_CreateAcc);
            this.Controls.Add(this.link_ForgotPass);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private Sunny.UI.UIButton btn_Login;
        private System.Windows.Forms.LinkLabel link_ForgotPass;
        private Sunny.UI.UIButton btn_CreateAcc;
    }
}