using BtlApp.Classes;
using BtlApp.Database;
using FormProduct.Classes;
using Guna.UI2.WinForms.Suite;
using Sunny.UI;
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
    public partial class Form_Manager : Form
    {
        // ================== slot group ====================
        private const int GROUP_WIDTH = 150;
        private const int GROUP_HEIGHT = 60;
        private const int NUM_GROUP = 4; // số nhóm 1 hàng
        private readonly int GROUP_GAP = (int)((650 - NUM_GROUP * GROUP_WIDTH) / 5); //flp_group.Width = 650;

        private readonly Color GROUP_BACKCOLOR = Color.FromArgb(56,56, 56);

        // ====================== Biến ======================
        private readonly int UserId;
        private bool isLogout = false;

        private readonly DataProcesser Db = new DataProcesser();

        public Form_Manager(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
            GROUP_GAP -= SystemInformation.VerticalScrollBarWidth / 5;
        }
// =====================================================================
// =====================================================================
        // ====================== Hàm ======================
        public bool IsLogout() { return isLogout; }

        public int getUserId() { return UserId; }


        // ============= Giao diện tab: Nhóm ===============
        private void addNewGroup(string groupName, string Desc)
        {

            // Thêm nhóm vào database
            try
            {
                string query =
                    $@"insert into {DbTables.tbl_Group.Table}
                        ({DbTables.tbl_Group.GroupName},
                         {DbTables.tbl_Group.Description},{DbTables.tbl_Group.CreatedBy})
                      values
                        (@GroupName,
                         @Description, @CreatedBy);
                    select scope_identity();";
                SqlParameter[] parameters = {
                    new SqlParameter("@GroupName", groupName),
                    new SqlParameter("@Description", Desc),
                    new SqlParameter("@CreatedBy", UserId)
                };
                object newId = Db.ExecuteScalar(query, parameters);

                GroupPanel panel = new GroupPanel(groupName, Convert.ToString(newId));
                flp_group.Controls.Add(panel);
                panel.OnLeaveGroup += () =>
                {
                    LeaveGroup(Convert.ToInt32(newId));
                };

                if (newId != null)
                {
                    MessageBox.Show("Tạo nhóm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo nhóm thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                query = 
                    $@"insert into tbl_GroupMember
                        (GroupId, UserId, Role)
                      values
                        (@GroupId,@UserId, @Role)";
                SqlParameter[] parameters1 = {
                    new SqlParameter("@GroupId", newId),
                    new SqlParameter("@Role", "Leader"),
                    new SqlParameter("@UserId", UserId)
                };
                Db.ExecuteNonQuery(query, parameters1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo nhóm:\n" + ex.Message, "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void JoinGroup(int groupId)
        {
            try
            {
                string query =
                    $@"insert into tbl_GroupMember
                        (GroupId, UserId, Role)
                      values
                        (@GroupId,@UserId, @Role)";
                SqlParameter[] parameters = {
                    new SqlParameter("@GroupId", groupId),
                    new SqlParameter("@Role", "Member"),
                    new SqlParameter("@UserId", UserId)
                };
                Db.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tham gia nhóm:\n" + ex.Message, "SQL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGroups()
        {
            flp_group.Controls.Clear();

            string query = @"
            select *
            from tbl_GroupMember gm
            join tbl_Group g on gm.GroupId = g.GroupId
            where gm.UserId = @UserId";

            SqlParameter[] parameters = {
            new SqlParameter("@UserId", UserId)
            };

            DataTable dt = Db.ReadTable(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                string line = "";
                foreach (DataColumn col in dt.Columns)
                    line += $"{col.ColumnName}: {row[col]} | ";

                Console.WriteLine(line);
                Console.WriteLine("-----");

                string groupId = row["GroupId"].ToString();
                string groupName = row["GroupName"].ToString();
                string role = row["Role"].ToString();

                GroupPanel panel = new GroupPanel(groupName, groupId);

                //Gắn thêm tooltip hoặc chi tiết nhỏ nếu muốn
               ToolTip tip = new ToolTip();
                tip.SetToolTip(panel, $"Vai trò: {role}");

                // Gắn event khi click “Rời nhóm”
                panel.OnLeaveGroup += () =>
                {
                    LeaveGroup((int)row["GroupId"]);

                };

                flp_group.Controls.Add(panel);
            }
        }

        private void LeaveGroup(int groupId)
        {
            DialogResult confirm = MessageBox.Show(
            "Bạn có chắc chắn muốn rời nhóm này không?",
            "Xác nhận rời nhóm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            
            if (confirm == DialogResult.Yes) {
                string query = "delete from tbl_GroupMember where GroupId = @GroupId and UserId = @UserId";
                SqlParameter[] parameters = {
                    new SqlParameter("@GroupId", groupId),
                    new SqlParameter("@UserId", UserId)
                };

                int result = Db.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Bạn đã rời nhóm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGroups(); // reload lại danh sách
                }
            }
        }


        // =====================================================================
        // =====================================================================
        // ================== Sự kiện form ===================
        private void Form_Manager_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }

        private void btn_MySchedule_Click(object sender, EventArgs e)
        {
            Form_MySchedule formMySchedule = new Form_MySchedule(this);
            formMySchedule.Show();
            this.Hide();
        }

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {
            Form_CreateGroup formCreateGroup = new Form_CreateGroup();

            DialogResult result = formCreateGroup.ShowDialog();


            if (result == DialogResult.OK)
            {
                string groupName = formCreateGroup.GroupName;
                string description = formCreateGroup.Description;
                
                addNewGroup(groupName, description);
            }
        }

        private void btn_Participate_Click(object sender, EventArgs e)
        {
            Form_JoinGroup formJoinGroup = new Form_JoinGroup();

            DialogResult result = formJoinGroup.ShowDialog();

            if (result == DialogResult.OK) {
                int groupId = formJoinGroup.GroupId;
                JoinGroup(groupId);
                LoadGroups();
            }
        }
    }
}
