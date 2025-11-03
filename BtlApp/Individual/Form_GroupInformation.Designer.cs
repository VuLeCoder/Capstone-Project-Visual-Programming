namespace BtlApp.Individual
{
    partial class Form_GroupInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.gbDesc = new Sunny.UI.UIGroupBox();
            this.rtbDesc = new Sunny.UI.UIRichTextBox();
            this.dgvMember = new Sunny.UI.UIDataGridView();
            this.panFunction = new Sunny.UI.UIPanel();
            this.btnLeave = new Sunny.UI.UIButton();
            this.btnRemove = new Sunny.UI.UIButton();
            this.btnAdd = new Sunny.UI.UIButton();
            this.panLeaderInfor = new Sunny.UI.UIPanel();
            this.lblLeader = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.panAddMem = new Sunny.UI.UIPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMem = new System.Windows.Forms.TextBox();
            this.uiPanel1.SuspendLayout();
            this.gbDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.panFunction.SuspendLayout();
            this.panLeaderInfor.SuspendLayout();
            this.panAddMem.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.AutoSize = true;
            this.uiPanel1.Controls.Add(this.gbDesc);
            this.uiPanel1.Controls.Add(this.dgvMember);
            this.uiPanel1.Controls.Add(this.panFunction);
            this.uiPanel1.Controls.Add(this.panLeaderInfor);
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(2, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(725, 560);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbDesc
            // 
            this.gbDesc.Controls.Add(this.rtbDesc);
            this.gbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDesc.Location = new System.Drawing.Point(14, 114);
            this.gbDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDesc.MinimumSize = new System.Drawing.Size(1, 1);
            this.gbDesc.Name = "gbDesc";
            this.gbDesc.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gbDesc.RectColor = System.Drawing.Color.Black;
            this.gbDesc.Size = new System.Drawing.Size(707, 116);
            this.gbDesc.TabIndex = 3;
            this.gbDesc.Text = "Mô tả";
            this.gbDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbDesc
            // 
            this.rtbDesc.FillColor = System.Drawing.Color.White;
            this.rtbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDesc.Location = new System.Drawing.Point(16, 37);
            this.rtbDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbDesc.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Padding = new System.Windows.Forms.Padding(2);
            this.rtbDesc.Radius = 15;
            this.rtbDesc.RectColor = System.Drawing.Color.Transparent;
            this.rtbDesc.ShowText = false;
            this.rtbDesc.Size = new System.Drawing.Size(678, 74);
            this.rtbDesc.TabIndex = 0;
            this.rtbDesc.Text = "uiRichTextBox1";
            this.rtbDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMember
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMember.BackgroundColor = System.Drawing.Color.White;
            this.dgvMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMember.EnableHeadersVisualStyles = false;
            this.dgvMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvMember.GridColor = System.Drawing.Color.White;
            this.dgvMember.Location = new System.Drawing.Point(14, 238);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMember.RowHeadersVisible = false;
            this.dgvMember.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvMember.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.ScrollBarColor = System.Drawing.Color.Gray;
            this.dgvMember.ScrollBarRectColor = System.Drawing.Color.Gray;
            this.dgvMember.ScrollBarStyleInherited = false;
            this.dgvMember.SelectedIndex = -1;
            this.dgvMember.Size = new System.Drawing.Size(707, 309);
            this.dgvMember.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvMember.TabIndex = 2;
            this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
            // 
            // panFunction
            // 
            this.panFunction.Controls.Add(this.btnLeave);
            this.panFunction.Controls.Add(this.btnRemove);
            this.panFunction.Controls.Add(this.btnAdd);
            this.panFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panFunction.Location = new System.Drawing.Point(249, 14);
            this.panFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panFunction.MinimumSize = new System.Drawing.Size(1, 1);
            this.panFunction.Name = "panFunction";
            this.panFunction.Radius = 10;
            this.panFunction.RectColor = System.Drawing.Color.Black;
            this.panFunction.Size = new System.Drawing.Size(471, 90);
            this.panFunction.TabIndex = 1;
            this.panFunction.Text = null;
            this.panFunction.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeave
            // 
            this.btnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLeave.Location = new System.Drawing.Point(359, 22);
            this.btnLeave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Radius = 10;
            this.btnLeave.Size = new System.Drawing.Size(100, 35);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "Rời nhóm";
            this.btnLeave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemove.Location = new System.Drawing.Point(197, 22);
            this.btnRemove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Radius = 10;
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(34, 22);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panLeaderInfor
            // 
            this.panLeaderInfor.Controls.Add(this.lblLeader);
            this.panLeaderInfor.Controls.Add(this.lblGroupName);
            this.panLeaderInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panLeaderInfor.Location = new System.Drawing.Point(13, 14);
            this.panLeaderInfor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panLeaderInfor.MinimumSize = new System.Drawing.Size(1, 1);
            this.panLeaderInfor.Name = "panLeaderInfor";
            this.panLeaderInfor.Radius = 10;
            this.panLeaderInfor.RectColor = System.Drawing.Color.Black;
            this.panLeaderInfor.Size = new System.Drawing.Size(228, 90);
            this.panLeaderInfor.TabIndex = 0;
            this.panLeaderInfor.Text = null;
            this.panLeaderInfor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeader
            // 
            this.lblLeader.AutoSize = true;
            this.lblLeader.BackColor = System.Drawing.Color.Transparent;
            this.lblLeader.Location = new System.Drawing.Point(12, 55);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Size = new System.Drawing.Size(64, 25);
            this.lblLeader.TabIndex = 1;
            this.lblLeader.Text = "label2";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupName.Location = new System.Drawing.Point(12, 9);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(64, 25);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "label1";
            // 
            // panAddMem
            // 
            this.panAddMem.Controls.Add(this.txtIDMem);
            this.panAddMem.Controls.Add(this.label1);
            this.panAddMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panAddMem.Location = new System.Drawing.Point(757, 273);
            this.panAddMem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panAddMem.MinimumSize = new System.Drawing.Size(1, 1);
            this.panAddMem.Name = "panAddMem";
            this.panAddMem.Size = new System.Drawing.Size(235, 68);
            this.panAddMem.TabIndex = 1;
            this.panAddMem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panAddMem.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ID";
            // 
            // txtIDMem
            // 
            this.txtIDMem.Location = new System.Drawing.Point(85, 19);
            this.txtIDMem.Name = "txtIDMem";
            this.txtIDMem.Size = new System.Drawing.Size(147, 30);
            this.txtIDMem.TabIndex = 1;
            this.txtIDMem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIDMem_KeyDown);
            // 
            // Form_GroupInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1025, 559);
            this.Controls.Add(this.panAddMem);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Form_GroupInformation";
            this.Text = "Form_GroupInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_GroupInformation_FormClosed);
            this.Load += new System.EventHandler(this.Form_GroupInformation_Load);
            this.uiPanel1.ResumeLayout(false);
            this.gbDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.panFunction.ResumeLayout(false);
            this.panLeaderInfor.ResumeLayout(false);
            this.panLeaderInfor.PerformLayout();
            this.panAddMem.ResumeLayout(false);
            this.panAddMem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView dgvMember;
        private Sunny.UI.UIPanel panFunction;
        private Sunny.UI.UIPanel panLeaderInfor;
        private Sunny.UI.UIButton btnLeave;
        private Sunny.UI.UIButton btnRemove;
        private Sunny.UI.UIButton btnAdd;
        private System.Windows.Forms.Label lblLeader;
        private System.Windows.Forms.Label lblGroupName;
        private Sunny.UI.UIGroupBox gbDesc;
        private Sunny.UI.UIRichTextBox rtbDesc;
        private Sunny.UI.UIPanel panAddMem;
        private System.Windows.Forms.TextBox txtIDMem;
        private System.Windows.Forms.Label label1;
    }
}