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
using BtlApp.Group;
using BtlApp.Database.Models;

namespace BtlApp.Individual
{
    public partial class Form_Manager : Form
    {
        // ================== slot group ====================
        private const int GROUP_WIDTH = 150;
        private const int GROUP_HEIGHT = 100;
        private const int NUM_GROUP = 4; // số nhóm 1 hàng
        private readonly int GROUP_GAP = (int)((650 - NUM_GROUP * GROUP_WIDTH) / (NUM_GROUP + 1)); //flp_group.Width = 650;

        private readonly Color GROUP_BACKCOLOR = Color.FromArgb(56,56, 56);
        private const string NAME = "Group_";

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
        private void addNewGroup(MyGroup group)
        {
            //UIPanel panel = new UIPanel
            //{
            //    Name = (NAME + group.GroupId.ToString()),
            //    Size = new Size(GROUP_WIDTH, GROUP_HEIGHT),
            //    FillColor = GROUP_BACKCOLOR,
            //    RectColor = GROUP_BACKCOLOR,
            //    Radius = 10,
            //    Margin = new Padding(GROUP_GAP, GROUP_GAP, 0, 0),
            //    Padding = new Padding(5),
            //    Tag = group.GroupId
            //};
            GroupPanel panel = new GroupPanel(group, new Size(GROUP_WIDTH, GROUP_HEIGHT), 
                new Padding(GROUP_GAP, GROUP_GAP, 0, 0), GROUP_BACKCOLOR);
            panel.OnLeaveGroup += () => { LeaveGroup(group.GroupId); };
            flp_group.Controls.Add(panel);
        }

        private void RemoveGroup(int groupId)
        {
            string name = NAME + groupId;
            flp_group.Controls.RemoveByKey(name);
        }

        // =============== Xử lý logic, truy vấn DB ================
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

        private void LoadGroupsFromDB()
        {
            flp_group.Controls.Clear();

            string query = $@"
                select * 
                from {DbTables.tbl_Group.Table} gr 
                join {DbTables.tbl_GroupMember.Table} gm on gm.{DbTables.tbl_GroupMember.GroupId} = gr.{DbTables.tbl_Group.Id} 
                where gm.{DbTables.tbl_GroupMember.UserId} = @UserId 
            ";
            SqlParameter[] parameters = {
                new SqlParameter("@UserId", UserId)
            };

            DataTable dt = Db.ReadTable(query, parameters);
            foreach (DataRow row in dt.Rows)
            {
                MyGroup group = new MyGroup(Convert.ToInt32(row[DbTables.tbl_Group.Id]), 
                    row[DbTables.tbl_Group.GroupName].ToString(), row[DbTables.tbl_Group.Description].ToString());

                addNewGroup(group);
            }
        }

        private void LeaveGroup(int groupId)
        {
            string roleQuery = $@"
                select {DbTables.tbl_GroupMember.Role} 
                from {DbTables.tbl_GroupMember.Table} 
                where {DbTables.tbl_GroupMember.GroupId} = @GroupId and {DbTables.tbl_GroupMember.UserId} = @UserId
            ";
            SqlParameter[] parameters = {
                new SqlParameter("@GroupId", groupId),
                new SqlParameter("@UserId", UserId)
            };

            string myRole = Db.ReadTable(roleQuery, parameters).Rows[0][DbTables.tbl_GroupMember.Role].ToString();
            if (myRole == "Leader")
            {
                DialogResult confirm = MessageBox.Show(
                    "Bạn là nhóm trưởng, nếu rời sẽ xóa nhóm",
                    "Xác nhận rời nhóm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirm == DialogResult.Yes)
                {
                    // Xóa lịch
                    string queryDeleteSchedules = $@"
                        delete from {DbTables.tbl_Schedule.Table} 
                        where {DbTables.tbl_Schedule.IdGroup} = @GroupId
                    ";
                    Db.ExecuteNonQuery(queryDeleteSchedules, parameters);

                    // Xóa thành viên trong nhóm
                    string queryDeleteMembers = $@"
                        delete from {DbTables.tbl_GroupMember.Table} 
                        where {DbTables.tbl_GroupMember.GroupId} = @GroupId
                    ";
                    Db.ExecuteNonQuery(queryDeleteMembers, parameters);

                    // Xóa nhóm
                    string queryDeleteGroup = $@"
                        DELETE FROM {DbTables.tbl_Group.Table}
                        WHERE {DbTables.tbl_Group.Id} = @GroupId
                    ";
                    Db.ExecuteNonQuery(queryDeleteGroup, parameters);

                    MessageBox.Show("Nhóm đã bị xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RemoveGroup(groupId);
                }
            }
            else
            {
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn rời nhóm này không?",
                    "Xác nhận rời nhóm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirm == DialogResult.Yes)
                {
                    //Xóa lịch
                    string queryDeleteSchedules = $@"
                        delete from {DbTables.tbl_Schedule.Table} 
                        where {DbTables.tbl_Schedule.IdGroup} = @GroupId
                            and {DbTables.tbl_Schedule.IdUser} = @UserId
                    ";
                    Db.ExecuteNonQuery(queryDeleteSchedules, parameters);

                    string queryLeave = $@"
                        delete from {DbTables.tbl_GroupMember.Table} 
                        where {DbTables.tbl_GroupMember.GroupId} = @GroupId 
                            and {DbTables.tbl_GroupMember.UserId} = @UserId
                    ";
                    Db.ExecuteNonQuery(queryLeave, parameters);
                    
                    MessageBox.Show("Bạn đã rời nhóm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemoveGroup(groupId);
                }
            }
        }


// =====================================================================
// =====================================================================
        // ================== Sự kiện form ===================
        private void Form_Manager_Load(object sender, EventArgs e)
        {
            LoadGroupsFromDB();
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
            Form_CreateGroup formCreateGroup = new Form_CreateGroup(UserId);
            DialogResult result = formCreateGroup.ShowDialog();


            if (result == DialogResult.OK)
            {
                addNewGroup(formCreateGroup.GetDetailGroup());
            }
        }

        private void btn_Participate_Click(object sender, EventArgs e)
        {
            //bug;
            Form_JoinGroup formJoinGroup = new Form_JoinGroup();

            DialogResult result = formJoinGroup.ShowDialog();

            if (result == DialogResult.OK) {
                int groupId = formJoinGroup.GroupId;
                JoinGroup(groupId);
            }
        }
    }
}
