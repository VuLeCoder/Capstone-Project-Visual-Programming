using BtlApp.Database.Models;
using BtlApp.Individual;
using FormProduct.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlApp.Individual
{
    public partial class Form_TodoList : Form
    {
        #region Fields
        private readonly DataProcesser Db = new DataProcesser();
        private readonly Form_Manager manager;
        private int editingId = 0;
        private string userId;
        #endregion

        // ---

        #region Constructor
        public Form_TodoList(Form_Manager manager, string currentUserId)
        {
            this.manager = manager;
            this.userId = currentUserId;
            InitializeComponent();
        }
        #endregion

        // ---

        #region Form Event Handlers
        private void Form_TodoList_Load(object sender, EventArgs e)
        {
            dgvTodo.Columns.Clear();
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "ToDoId", Visible = false });
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Title", HeaderText = "Title", DataPropertyName = "Title", Width = 300 });
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Description", DataPropertyName = "Description", Width = 360 });
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Priority", HeaderText = "Priority", DataPropertyName = "Priority", Width = 90 });
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status", Width = 90 });
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "DueDate", HeaderText = "Due Date", DataPropertyName = "DueDate", Width = 120 });
            dgvTodo.Columns.Add(new DataGridViewTextBoxColumn { Name = "CreatedAt", HeaderText = "Created At", DataPropertyName = "CreatedAt", Width = 140 });
            // Cột nút Xóa
            var deleteCol = new DataGridViewButtonColumn();
            deleteCol.Name = "Delete";
            deleteCol.HeaderText = "";
            deleteCol.Text = "🗑️ Delete";
            deleteCol.UseColumnTextForButtonValue = true;
            deleteCol.Width = 100;
            deleteCol.DefaultCellStyle.BackColor = Color.FromArgb(244, 67, 54);
            deleteCol.DefaultCellStyle.ForeColor = Color.Red;
            deleteCol.DefaultCellStyle.SelectionBackColor = Color.FromArgb(211, 47, 47);
            deleteCol.FlatStyle = FlatStyle.Flat;

            dgvTodo.Columns.Add(deleteCol);

            cbStatusFilter.SelectedIndex = 0;
            cbPriorityFilter.SelectedIndex = 0;
            RefreshGrid();
        }

        private void Form_TodoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.Show();
        }
        #endregion

        // ---

        #region Control Event Handlers

        // Toolbar & Filter Events
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ShowDetailPanelForAdd();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();

        }
        

        private void cbPriorityFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    
        // Grid Events
        private void dgvTodo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTodo.Rows[e.RowIndex];
            string status = row.Cells["Status"].Value?.ToString() ?? "";

            switch (status)
            {
                case "Pending":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 249, 196);
                    break;
                case "InProgress":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(197, 225, 180);
                    break;
                case "Done":
                    row.DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201);
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                    break;
            }
        }
        private void dgvTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTodo.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = Convert.ToInt32(dgvTodo.Rows[e.RowIndex].Cells["Id"].Value);
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa công việc này không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    string query = "DELETE FROM tblToDoList WHERE ToDoId = @id";
                    Db.ExecuteNonQuery(query, new SqlParameter[] { new SqlParameter("@id", id) });
                    RefreshGrid();
                }
            }
        }
        private void dgvTodo_DoubleClick_1(object sender, EventArgs e)
        {
            if (dgvTodo.CurrentRow == null) return;

            editingId = Convert.ToInt32(dgvTodo.CurrentRow.Cells["Id"].Value);
            LoadDetail(editingId);
            pnlDetail.Visible = true;
        }

        // Detail Panel Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == 0)
            {
                InsertTask();
            }
            else
            {
                UpdateTask(editingId);
            }

            ClearDetailInputs();
            pnlDetail.Visible = false;
            RefreshGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearDetailInputs();
            pnlDetail.Visible = false;
            editingId = 0;
        }
        #endregion

        // ---

        #region Private Helper Methods

        // ============== CRUD helpers ==========================
        private void RefreshGrid()
        {
            string keyword = txtSearch.Text.Trim();
            string statusFilter = cbStatusFilter.SelectedIndex > 0 ? cbStatusFilter.Text : "All";
            string priorityFilter = cbPriorityFilter.SelectedIndex > 0 ? cbPriorityFilter.Text : "All";

            string query = @"SELECT ToDoId, Title, Description, Priority, Status, DueDate, CreatedAt
                           FROM tblToDoList
                           WHERE 1=1";

            query += " AND UserId = @userId";

            if (!string.IsNullOrEmpty(keyword))
                query += " AND Title LIKE @kw";

            if (statusFilter != "All")
                query += " AND Status = @status";

            if (priorityFilter != "All")
                query += " AND Priority = @priority";

            query += @" ORDER BY
                      CASE WHEN DueDate IS NULL THEN 1 ELSE 0 END,
                      DueDate ASC,
                      CreatedAt DESC";

            var parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userId", this.userId));
            if (!string.IsNullOrEmpty(keyword))
                parameters.Add(new SqlParameter("@kw", "%" + keyword + "%"));
            if (statusFilter != "All")
                parameters.Add(new SqlParameter("@status", statusFilter));
            if (priorityFilter != "All")
                parameters.Add(new SqlParameter("@priority", priorityFilter));

            DataTable dt = Db.ReadTable(query, parameters.Count == 0 ? null : parameters.ToArray());
            dgvTodo.DataSource = dt;
        }

        private void InsertTask()
        {
            string query = "INSERT INTO tblToDoList (UserId, Title, Description, Priority, Status, CreatedAt, DueDate) " +
                           "VALUES (@user, @title, @desc, @prio, @status, GETDATE(), @due)";


            var prms = new SqlParameter[]
            {
                new SqlParameter("@user", this.userId),
                new SqlParameter("@title", txtTitle.Text.Trim()),
                new SqlParameter("@desc", txtDescription.Text.Trim()),
                new SqlParameter("@prio", string.IsNullOrWhiteSpace(cbPriority.Text) ? "Normal" : cbPriority.Text),
                new SqlParameter("@status", string.IsNullOrWhiteSpace(cbStatus.Text) ? "Pending" : cbStatus.Text),
                new SqlParameter("@due", (object)dtDueDate.Value.Date ?? DBNull.Value)
            };

            Db.ExecuteNonQuery(query, prms);
        }

        private void UpdateTask(int id)
        {
            string query = "UPDATE tblToDoList SET Title=@title, Description=@desc, Priority=@prio, Status=@status, DueDate=@due WHERE ToDoId=@id";
            var prms = new SqlParameter[]
            {
                new SqlParameter("@title", txtTitle.Text.Trim()),
                new SqlParameter("@desc", txtDescription.Text.Trim()),
                new SqlParameter("@prio", string.IsNullOrWhiteSpace(cbPriority.Text) ? "Normal" : cbPriority.Text),
                new SqlParameter("@status", string.IsNullOrWhiteSpace(cbStatus.Text) ? "Pending" : cbStatus.Text),
                new SqlParameter("@due", (object)dtDueDate.Value.Date ?? DBNull.Value),
                new SqlParameter("@id", id)
            };

            Db.ExecuteNonQuery(query, prms);
        }

        private void LoadDetail(int id)
        {
            string query = "SELECT * FROM tblToDoList WHERE ToDoId = @id AND UserId = @userId";
            var prms = new SqlParameter[]
            {
            new SqlParameter("@id", id),
            new SqlParameter("@userId", this.userId)
            };

            DataTable dt = Db.ReadTable(query, prms);
            if (dt.Rows.Count == 0) return;
            var row = dt.Rows[0];
            txtTitle.Text = row["Title"].ToString();
            txtDescription.Text = row["Description"].ToString();
            cbPriority.Text = row["Priority"].ToString();
            cbStatus.Text = row["Status"].ToString();
            if (row["DueDate"] != DBNull.Value)
            {
                dtDueDate.Value = Convert.ToDateTime(row["DueDate"]);
            }
            pnlDetail.Visible = true;
        }

        // ============== UI Helpers ============================
        private void ShowDetailPanelForAdd()
        {
            editingId = 0;
            ClearDetailInputs();
            pnlDetail.Visible = true;
            txtTitle.Focus();
        }

        private void ClearDetailInputs()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            cbPriority.SelectedIndex = -1; // -1 để xóa lựa chọn
            cbStatus.SelectedIndex = -1;   // -1 để xóa lựa chọn
            dtDueDate.Value = DateTime.Now;
        }



        #endregion

        
    }  
}