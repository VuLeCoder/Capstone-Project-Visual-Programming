namespace BtlApp.Individual
{
    partial class Form_Register
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btn_Register = new Sunny.UI.UIButton();
            this.link_BackLogin = new System.Windows.Forms.LinkLabel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblConfirmError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(78, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(78, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(78, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re-Password";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Location = new System.Drawing.Point(234, 44);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 26);
            this.txtUser.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(234, 90);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(234, 134);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRePassword.Location = new System.Drawing.Point(234, 180);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(209, 26);
            this.txtRePassword.TabIndex = 7;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.TextChanged += new System.EventHandler(this.txtRePassword_TextChanged);
            // 
            // btn_Register
            // 
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Register.Location = new System.Drawing.Point(179, 237);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Register.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Radius = 20;
            this.btn_Register.Size = new System.Drawing.Size(157, 39);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "Create Account";
            this.btn_Register.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // link_BackLogin
            // 
            this.link_BackLogin.AutoSize = true;
            this.link_BackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.link_BackLogin.Location = new System.Drawing.Point(195, 278);
            this.link_BackLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_BackLogin.Name = "link_BackLogin";
            this.link_BackLogin.Size = new System.Drawing.Size(124, 17);
            this.link_BackLogin.TabIndex = 9;
            this.link_BackLogin.TabStop = true;
            this.link_BackLogin.Text = "Have an Account?";
            this.link_BackLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_BackLogin_LinkClicked);
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Location = new System.Drawing.Point(234, 162);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordError.TabIndex = 10;
            // 
            // lblConfirmError
            // 
            this.lblConfirmError.AutoSize = true;
            this.lblConfirmError.Location = new System.Drawing.Point(234, 210);
            this.lblConfirmError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmError.Name = "lblConfirmError";
            this.lblConfirmError.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmError.TabIndex = 11;
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 334);
            this.Controls.Add(this.lblConfirmError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.link_BackLogin);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Register";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private Sunny.UI.UIButton btn_Register;
        private System.Windows.Forms.LinkLabel link_BackLogin;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblConfirmError;
    }
}