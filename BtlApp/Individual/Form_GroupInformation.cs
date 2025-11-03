using BtlApp.Database;
using FormProduct.Classes;
using Sunny.UI.Win32;
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
    public partial class Form_GroupInformation : Form
    {
        private int GroupId;
        private int UserId;
        private bool isLeader = false;
        private Form_Manager form_Manager;
        DataProcesser db = new DataProcesser();
        public Form_GroupInformation(int GroupId, Form_Manager form_Manager)
        {
            InitializeComponent();
            this.GroupId = GroupId;
            this.UserId = form_Manager.getUserId();
            this.form_Manager = form_Manager;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (isLeader == true)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy nhóm này? Tất cả thành viên sẽ bị xóa khỏi nhóm.",
                                                    "Xác nhận",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Xóa lịch nhóm
                        string delScheduleQuery = $@"delete from {DbTables.tbl_Schedule.Table}
                                            where {DbTables.tbl_Schedule.IdGroup} = @GroupId";
                        SqlParameter[] delScheduleParams =
                        {
                            new SqlParameter("@GroupId", GroupId)
                        };
                        db.ExecuteNonQuery(delScheduleQuery, delScheduleParams);

                        //Xóa thành viên nhóm
                        string deleteMemQuery = $@"delete from {DbTables.tbl_GroupMember.Table}
                                            where {DbTables.tbl_GroupMember.GroupId} = @GroupId";
                        SqlParameter[] deleteMemParams =
                        {
                            new SqlParameter("@GroupId", GroupId)
                        };
                        db.ExecuteNonQuery(deleteMemQuery, deleteMemParams);

                        //Xóa nhóm
                        string deleteGroupQuery = $@"delete from {DbTables.tbl_Group.Table}
                                            where {DbTables.tbl_Group.Id} = @GroupId";
                        SqlParameter[] delGroupParams =
                        {
                            new SqlParameter("@GroupId", GroupId)
                        };
                        int rowsAffected = db.ExecuteNonQuery(deleteGroupQuery, delGroupParams);

                        //Check xóa được chưa
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nhóm đã được hủy thành công.", "Thành công",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Hủy nhóm thất bại.", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi hủy nhóm:\n" + ex.Message, "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn rời nhóm này?",
                                                     "Xác nhận",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string deleteQuery = $@"delete from {DbTables.tbl_GroupMember.Table}
                                            where {DbTables.tbl_GroupMember.GroupId} = @GroupId
                                            and {DbTables.tbl_GroupMember.UserId} = @UserId";
                        SqlParameter[] deleteParams =
                        {
                            new SqlParameter("@GroupId", GroupId),
                            new SqlParameter("@UserId", UserId)
                        };
                        int rowsAffected = db.ExecuteNonQuery(deleteQuery, deleteParams);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rời nhóm thành công.", "Thành công",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Rời nhóm thất bại.", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi rời nhóm:\n" + ex.Message, "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form_GroupInformation_Load(object sender, EventArgs e)
        {
            string query = $@"select {DbTables.tbl_Group.GroupName}, {DbTables.tbl_Group.Description}
                              from {DbTables.tbl_Group.Table}
                              where {DbTables.tbl_Group.Id} = @GroupId";
            SqlParameter[] parameters = {
                new SqlParameter("@GroupId", GroupId)
            };

            DataTable dt = db.ReadTable(query, parameters);
            if (dt.Rows.Count > 0)
            {
                lblGroupName.Text = dt.Rows[0][DbTables.tbl_Group.GroupName].ToString();
                rtbDesc.Text = dt.Rows[0][DbTables.tbl_Group.Description].ToString();
            }

            string memberQuery = $@"select u.{DbTables.tbl_User.Id}, u.{DbTables.tbl_User.Name}, u.{DbTables.tbl_User.Email},
                                     gm.{DbTables.tbl_GroupMember.Role}, gm.{DbTables.tbl_GroupMember.JoinedAt}   
                                     from {DbTables.tbl_User.Table} u
                                     join {DbTables.tbl_GroupMember.Table} gm
                                     on u.{DbTables.tbl_User.Id} = gm.{DbTables.tbl_GroupMember.UserId}
                                     where gm.{DbTables.tbl_GroupMember.GroupId} = @GroupId";
            SqlParameter[] memberPara =
            {
                new SqlParameter("@GroupId", GroupId)
            };
            DataTable memberDt = db.ReadTable(memberQuery, memberPara);
            if (memberDt.Rows.Count > 0)
            {
                lblLeader.Text = memberDt.Rows[0][DbTables.tbl_User.Name].ToString();
            }
            foreach (DataColumn col in memberDt.Columns)
            {
                Console.WriteLine(col.ColumnName);
            }
            dgvMember.DataSource = memberDt;
            dgvMember.Columns[DbTables.tbl_User.Id].HeaderText = "ID";
            dgvMember.Columns[DbTables.tbl_User.Name].HeaderText = "Member Name";
            dgvMember.Columns[DbTables.tbl_User.Email].HeaderText = "Email";
            dgvMember.Columns[DbTables.tbl_GroupMember.Role].HeaderText = "Role";
            dgvMember.Columns[DbTables.tbl_GroupMember.JoinedAt].HeaderText = "Joined At";

            dgvMember.Columns[DbTables.tbl_User.Id].Width = 50;
            dgvMember.Columns[DbTables.tbl_User.Email].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMember.Rows[0].ReadOnly = true;

            if (this.UserId == Convert.ToInt32(memberDt.Rows[0][DbTables.tbl_User.Id]))
            {
                btnAdd.Visible = true;
                btnRemove.Visible = true;
                btnLeave.Text = "Hủy nhóm";
                isLeader = true;
                btnRemove.Enabled = false;
            }
            else 
            {
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                btnLeave.Text = "Rời nhóm";
            }
        }

        private void Form_GroupInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_Manager.Enabled = true;
            form_Manager.Reload();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 0)
            {
                dgvMember.ClearSelection();
                btnRemove.Enabled = false;
                return;
            }
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (dgvMember.CurrentRow == null || dgvMember.CurrentRow.Index == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên hợp lệ.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thành viên này khỏi nhóm?", 
                                                "Xác nhận", 
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int selectedUserId = Convert.ToInt32(dgvMember.CurrentRow.Cells[DbTables.tbl_User.Id].Value);
                    string deleteQuery = $@"delete from {DbTables.tbl_GroupMember.Table}
                                        where {DbTables.tbl_GroupMember.GroupId} = @GroupId
                                        and {DbTables.tbl_GroupMember.UserId} = @UserId";
                    SqlParameter[] deleteParams =
                    {
                        new SqlParameter("@GroupId", GroupId),
                        new SqlParameter("@UserId", selectedUserId)
                    };
                    int rowsAffected = db.ExecuteNonQuery(deleteQuery, deleteParams);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành viên khỏi nhóm thành công.", "Thành công",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Tải lại danh sách thành viên
                        Form_GroupInformation_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thành viên khỏi nhóm thất bại.", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thành viên:\n" + ex.Message, "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Point loc = btnAdd.Location;
            panAddMem.Location = new Point(loc.X, loc.Y + btnAdd.Height);
            panAddMem.Visible = true;
        }

        private void txtIDMem_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                string queryCheck = $@"select count(*) from {DbTables.tbl_User.Table}
                                    where {DbTables.tbl_User.Id} = @UserId";
                SqlParameter[] parametersCheck =
                {
                    new SqlParameter("@UserId", Convert.ToInt32(txtIDMem.Text))
                };
                object check = db.ExecuteScalar(queryCheck, parametersCheck);
                if(Convert.ToInt32(check) == 0)
                {
                    MessageBox.Show("Người dùng không tồn tại. Vui lòng kiểm tra lại.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string queryIsAdded = $@"select count(*) from {DbTables.tbl_GroupMember.Table}
                                        where {DbTables.tbl_GroupMember.UserId} = @UserId 
                                        and {DbTables.tbl_GroupMember.GroupId} = @GroupId";
                SqlParameter[] isAddedParams =
                {
                    new SqlParameter("@UserId", Convert.ToInt32(txtIDMem.Text)),
                    new SqlParameter("@GroupId", GroupId)
                };
                object isAdded = db.ExecuteScalar(queryIsAdded, isAddedParams);
                if (Convert.ToInt32(isAdded) != 0)
                {
                    MessageBox.Show("Thành viên đã ở trong nhóm. Vui lòng kiểm tra lại.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm thành viên này vào nhóm?",
                                                "Xác nhận",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        string query = $@"insert into {DbTables.tbl_GroupMember.Table}
                                    ({DbTables.tbl_GroupMember.GroupId}, {DbTables.tbl_GroupMember.UserId}, {DbTables.tbl_GroupMember.Role})
                                    values
                                    (@GroupId, @UserId, @Role)";
                        SqlParameter[] parameters =
                        {
                            new SqlParameter("@GroupId", GroupId),
                            new SqlParameter("@UserId", Convert.ToInt32(txtIDMem.Text)),
                            new SqlParameter("@Role", "Member")
                        };
                        int checkAdd = db.ExecuteNonQuery(query, parameters);
                        if (checkAdd > 0)
                        {
                            MessageBox.Show("Thêm thành viên vào nhóm thành công.", "Thành công",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panAddMem.Visible = false;
                            txtIDMem.Clear();
                            // Tải lại danh sách thành viên
                            Form_GroupInformation_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thành viên vào nhóm thất bại. Vui lòng kiểm tra lại ID.", "Lỗi",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm thành viên:\n" + ex.Message, "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
