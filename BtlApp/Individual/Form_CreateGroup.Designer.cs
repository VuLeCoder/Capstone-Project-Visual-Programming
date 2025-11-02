namespace BtlApp.Individual
{
    partial class Form_CreateGroup
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new Sunny.UI.UIButton();
            this.lblNameNull = new System.Windows.Forms.Label();
            this.lblDescriptionNull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.txtName.Location = new System.Drawing.Point(346, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 27);
            this.txtName.TabIndex = 0;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(346, 132);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(296, 161);
            this.rtb_Description.TabIndex = 1;
            this.rtb_Description.Text = "";
            this.rtb_Description.Leave += new System.EventHandler(this.rtb_Description_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(165, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(165, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreate.Location = new System.Drawing.Point(324, 352);
            this.btnCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Radius = 20;
            this.btnCreate.Size = new System.Drawing.Size(153, 35);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblNameNull
            // 
            this.lblNameNull.AutoSize = true;
            this.lblNameNull.Location = new System.Drawing.Point(346, 91);
            this.lblNameNull.Name = "lblNameNull";
            this.lblNameNull.Size = new System.Drawing.Size(0, 16);
            this.lblNameNull.TabIndex = 5;
            // 
            // lblDescriptionNull
            // 
            this.lblDescriptionNull.AutoSize = true;
            this.lblDescriptionNull.Location = new System.Drawing.Point(346, 300);
            this.lblDescriptionNull.Name = "lblDescriptionNull";
            this.lblDescriptionNull.Size = new System.Drawing.Size(0, 16);
            this.lblDescriptionNull.TabIndex = 6;
            // 
            // Form_CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDescriptionNull);
            this.Controls.Add(this.lblNameNull);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.txtName);
            this.Name = "Form_CreateGroup";
            this.Text = "Create Group";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CreateGroup_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIButton btnCreate;
        private System.Windows.Forms.Label lblNameNull;
        private System.Windows.Forms.Label lblDescriptionNull;
    }
}