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
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Group";
            // 
            // txtGroupId
            // 
            this.txtGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGroupId.Location = new System.Drawing.Point(157, 52);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(170, 26);
            this.txtGroupId.TabIndex = 1;
            this.txtGroupId.TextChanged += new System.EventHandler(this.txtGroupId_TextChanged);
            // 
            // btnJoin
            // 
            this.btnJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnJoin.Location = new System.Drawing.Point(218, 106);
            this.btnJoin.MinimumSize = new System.Drawing.Size(2, 2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Radius = 20;
            this.btnJoin.Size = new System.Drawing.Size(109, 34);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join";
            this.btnJoin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblGroupIdNull
            // 
            this.lblGroupIdNull.AutoSize = true;
            this.lblGroupIdNull.Location = new System.Drawing.Point(393, 203);
            this.lblGroupIdNull.Name = "lblGroupIdNull";
            this.lblGroupIdNull.Size = new System.Drawing.Size(0, 20);
            this.lblGroupIdNull.TabIndex = 3;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(154, 81);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 15);
            this.lbl_Error.TabIndex = 4;
            // 
            // Form_JoinGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 174);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lblGroupIdNull);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtGroupId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Form_JoinGroup";
            this.Text = "JoinGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupId;
        private Sunny.UI.UIButton btnJoin;
        private System.Windows.Forms.Label lblGroupIdNull;
        private System.Windows.Forms.Label lbl_Error;
    }
}