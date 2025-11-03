namespace BtlApp.Individual
{
    partial class Form_TodoList
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.cbStatusFilter = new Sunny.UI.UIComboBox();
            this.cbPriorityFilter = new Sunny.UI.UIComboBox();
            this.pnlDetail = new Sunny.UI.UIPanel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.lbl100 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtDescription = new Sunny.UI.UITextBox();
            this.txtTitle = new Sunny.UI.UITextBox();
            this.dtDueDate = new Sunny.UI.UIDatePicker();
            this.cbPriority = new Sunny.UI.UIComboBox();
            this.cbStatus = new Sunny.UI.UIComboBox();
            this.btnCancel = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.dgvTodo = new Sunny.UI.UIDataGridView();
            this.pnlDetail.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(32, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(386, 35);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "Search by title..";
            this.txtSearch.WatermarkActiveColor = System.Drawing.Color.Silver;
            this.txtSearch.WatermarkColor = System.Drawing.Color.Silver;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DataSource = null;
            this.cbStatusFilter.FillColor = System.Drawing.Color.White;
            this.cbStatusFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatusFilter.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "InProgress",
            "Completed"});
            this.cbStatusFilter.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbStatusFilter.Location = new System.Drawing.Point(437, 13);
            this.cbStatusFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatusFilter.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatusFilter.Size = new System.Drawing.Size(150, 35);
            this.cbStatusFilter.SymbolSize = 24;
            this.cbStatusFilter.TabIndex = 1;
            this.cbStatusFilter.Text = "Status";
            this.cbStatusFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatusFilter.Watermark = "";
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilter_SelectedIndexChanged);
            // 
            // cbPriorityFilter
            // 
            this.cbPriorityFilter.DataSource = null;
            this.cbPriorityFilter.FillColor = System.Drawing.Color.White;
            this.cbPriorityFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPriorityFilter.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbPriorityFilter.Items.AddRange(new object[] {
            "All",
            "Low",
            "Normal",
            "High"});
            this.cbPriorityFilter.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbPriorityFilter.Location = new System.Drawing.Point(629, 13);
            this.cbPriorityFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriorityFilter.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPriorityFilter.Name = "cbPriorityFilter";
            this.cbPriorityFilter.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPriorityFilter.Size = new System.Drawing.Size(150, 35);
            this.cbPriorityFilter.SymbolSize = 24;
            this.cbPriorityFilter.TabIndex = 2;
            this.cbPriorityFilter.Text = "Priority";
            this.cbPriorityFilter.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPriorityFilter.Watermark = "";
            this.cbPriorityFilter.SelectedIndexChanged += new System.EventHandler(this.cbPriorityFilter_SelectedIndexChanged);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.uiLabel5);
            this.pnlDetail.Controls.Add(this.uiLabel4);
            this.pnlDetail.Controls.Add(this.uiLabel3);
            this.pnlDetail.Controls.Add(this.lbl100);
            this.pnlDetail.Controls.Add(this.uiLabel1);
            this.pnlDetail.Controls.Add(this.txtDescription);
            this.pnlDetail.Controls.Add(this.txtTitle);
            this.pnlDetail.Controls.Add(this.dtDueDate);
            this.pnlDetail.Controls.Add(this.cbPriority);
            this.pnlDetail.Controls.Add(this.cbStatus);
            this.pnlDetail.Controls.Add(this.btnCancel);
            this.pnlDetail.Controls.Add(this.btnSave);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlDetail.Location = new System.Drawing.Point(10, 399);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.pnlDetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1253, 236);
            this.pnlDetail.TabIndex = 5;
            this.pnlDetail.Text = null;
            this.pnlDetail.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlDetail.Visible = false;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(638, 51);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(105, 23);
            this.uiLabel5.TabIndex = 13;
            this.uiLabel5.Text = "Date";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(432, 141);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "Priority";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(432, 54);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "Status";
            // 
            // lbl100
            // 
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl100.Location = new System.Drawing.Point(13, 141);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(123, 23);
            this.lbl100.TabIndex = 10;
            this.lbl100.Text = "Description";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(13, 54);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 9;
            this.uiLabel1.Text = "Title";
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescription.Location = new System.Drawing.Point(13, 173);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(5);
            this.txtDescription.ShowText = false;
            this.txtDescription.Size = new System.Drawing.Size(338, 35);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescription.Watermark = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.Location = new System.Drawing.Point(13, 79);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(5);
            this.txtTitle.ShowText = false;
            this.txtTitle.Size = new System.Drawing.Size(338, 36);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTitle.Watermark = "";
            // 
            // dtDueDate
            // 
            this.dtDueDate.FillColor = System.Drawing.Color.White;
            this.dtDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDueDate.Location = new System.Drawing.Point(638, 79);
            this.dtDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDueDate.MaxLength = 10;
            this.dtDueDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dtDueDate.Size = new System.Drawing.Size(220, 36);
            this.dtDueDate.SymbolDropDown = 61555;
            this.dtDueDate.SymbolNormal = 61555;
            this.dtDueDate.SymbolSize = 24;
            this.dtDueDate.TabIndex = 6;
            this.dtDueDate.Text = "2025-11-01";
            this.dtDueDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtDueDate.Value = new System.DateTime(2025, 11, 1, 20, 25, 9, 612);
            this.dtDueDate.Watermark = "";
            // 
            // cbPriority
            // 
            this.cbPriority.DataSource = null;
            this.cbPriority.FillColor = System.Drawing.Color.White;
            this.cbPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPriority.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.cbPriority.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbPriority.Location = new System.Drawing.Point(433, 173);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriority.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbPriority.Size = new System.Drawing.Size(150, 35);
            this.cbPriority.SymbolSize = 24;
            this.cbPriority.TabIndex = 3;
            this.cbPriority.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbPriority.Watermark = "";
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = null;
            this.cbStatus.FillColor = System.Drawing.Color.White;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "InProgress",
            "Completed"});
            this.cbStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbStatus.Location = new System.Drawing.Point(433, 79);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbStatus.Size = new System.Drawing.Size(150, 36);
            this.cbStatus.SymbolSize = 24;
            this.cbStatus.TabIndex = 2;
            this.cbStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbStatus.Watermark = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(955, 173);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(955, 73);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.btnAdd);
            this.uiPanel2.Controls.Add(this.txtSearch);
            this.uiPanel2.Controls.Add(this.cbStatusFilter);
            this.uiPanel2.Controls.Add(this.cbPriorityFilter);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(10, 10);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Radius = 1;
            this.uiPanel2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPanel2.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel2.Size = new System.Drawing.Size(1253, 79);
            this.uiPanel2.TabIndex = 6;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(955, 13);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 35);
            this.btnAdd.Symbol = 61543;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTodo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodo.EnableHeadersVisualStyles = false;
            this.dgvTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvTodo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvTodo.Location = new System.Drawing.Point(10, 89);
            this.dgvTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTodo.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvTodo.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTodo.RowTemplate.Height = 24;
            this.dgvTodo.SelectedIndex = -1;
            this.dgvTodo.Size = new System.Drawing.Size(1253, 310);
            this.dgvTodo.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvTodo.TabIndex = 7;
            this.dgvTodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellContentClick);
            this.dgvTodo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellDoubleClick);
            this.dgvTodo.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTodo_RowPrePaint);
            // 
            // Form_TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1273, 645);
            this.Controls.Add(this.dgvTodo);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.pnlDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_TodoList";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form_TodoList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_TodoList_FormClosed);
            this.Load += new System.EventHandler(this.Form_TodoList_Load);
            this.pnlDetail.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.ResumeLayout(false);

        }

        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIComboBox cbStatusFilter;
        private Sunny.UI.UIComboBox cbPriorityFilter;
        private Sunny.UI.UIPanel pnlDetail;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIComboBox cbPriority;
        private Sunny.UI.UIComboBox cbStatus;
        private Sunny.UI.UITextBox txtDescription;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UIDatePicker dtDueDate;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel lbl100;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgvTodo;
        private Sunny.UI.UISymbolButton btnAdd;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // Form_TodoList
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(1110, 576);
        //    this.Name = "Form_TodoList";
        //    this.Text = "Form_TodoList";
        //    this.ResumeLayout(false);

        //}

    }
}