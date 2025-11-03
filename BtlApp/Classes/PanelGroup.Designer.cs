namespace BtlApp.Classes
{
    partial class PanelGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnMore = new Sunny.UI.UIButton();
            this.lblId = new Sunny.UI.UILabel();
            this.lblName = new Sunny.UI.UILabel();
            this.menu = new Sunny.UI.UIContextMenuStrip();
            this.smiInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiPanel1.Controls.Add(this.btnMore);
            this.uiPanel1.Controls.Add(this.lblId);
            this.uiPanel1.Controls.Add(this.lblName);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 10;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.uiPanel1.Size = new System.Drawing.Size(220, 120);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMore
            // 
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore.FillColor = System.Drawing.Color.Transparent;
            this.btnMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMore.Location = new System.Drawing.Point(180, 80);
            this.btnMore.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMore.Name = "btnMore";
            this.btnMore.Radius = 10;
            this.btnMore.RectColor = System.Drawing.Color.Transparent;
            this.btnMore.Size = new System.Drawing.Size(30, 30);
            this.btnMore.TabIndex = 2;
            this.btnMore.Text = "⋮";
            this.btnMore.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Gray;
            this.lblId.Location = new System.Drawing.Point(10, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(97, 31);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "uiLabel1";
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 67);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "uiLabel1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiInformation,
            this.smiLeave});
            this.menu.Name = "menu";
            this.menu.ShowImageMargin = false;
            this.menu.ShowItemToolTips = false;
            this.menu.Size = new System.Drawing.Size(142, 64);
            // 
            // smiInformation
            // 
            this.smiInformation.ForeColor = System.Drawing.Color.White;
            this.smiInformation.Name = "smiInformation";
            this.smiInformation.Size = new System.Drawing.Size(141, 30);
            this.smiInformation.Text = "Thông tin";
            this.smiInformation.Click += new System.EventHandler(this.smiInformation_Click);
            // 
            // smiLeave
            // 
            this.smiLeave.ForeColor = System.Drawing.Color.White;
            this.smiLeave.Name = "smiLeave";
            this.smiLeave.Size = new System.Drawing.Size(141, 30);
            this.smiLeave.Text = "Rời nhóm";
            this.smiLeave.Click += new System.EventHandler(this.smiLeave_Click);
            // 
            // PanelGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPanel1);
            this.Name = "PanelGroup";
            this.Size = new System.Drawing.Size(220, 120);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UILabel lblId;
        private Sunny.UI.UIContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem smiInformation;
        private System.Windows.Forms.ToolStripMenuItem smiLeave;
        private Sunny.UI.UIButton btnMore;
    }
}
