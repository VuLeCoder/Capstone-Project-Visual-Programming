namespace BtlApp.Individual
{
    partial class Form_JoinGroup
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
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.btnJoin = new Sunny.UI.UIButton();
            this.lblGroupIdNull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(220, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Group";
            // 
            // txtGroupId
            // 
            this.txtGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGroupId.Location = new System.Drawing.Point(352, 130);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(266, 30);
            this.txtGroupId.TabIndex = 1;
            this.txtGroupId.TextChanged += new System.EventHandler(this.txtGroupId_TextChanged);
            // 
            // btnJoin
            // 
            this.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnJoin.Location = new System.Drawing.Point(352, 275);
            this.btnJoin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Radius = 20;
            this.btnJoin.Size = new System.Drawing.Size(100, 35);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join";
            this.btnJoin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnJoin.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // lblGroupIdNull
            // 
            this.lblGroupIdNull.AutoSize = true;
            this.lblGroupIdNull.Location = new System.Drawing.Point(349, 163);
            this.lblGroupIdNull.Name = "lblGroupIdNull";
            this.lblGroupIdNull.Size = new System.Drawing.Size(0, 16);
            this.lblGroupIdNull.TabIndex = 3;
            // 
            // Form_JoinGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGroupIdNull);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.label1);
            this.Name = "Form_JoinGroup";
            this.Text = "Form_JoinGroup";
            this.Load += new System.EventHandler(this.Form_JoinGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupId;
        private Sunny.UI.UIButton btnJoin;
        private System.Windows.Forms.Label lblGroupIdNull;
    }
}