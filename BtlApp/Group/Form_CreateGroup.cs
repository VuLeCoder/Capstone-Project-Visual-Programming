using BtlApp.Database;
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
using BtlApp.Database.Models;

namespace BtlApp.Group
{
    public partial class Form_CreateGroup : Form
    {
        private readonly DataProcesser Db = new DataProcesser();
        private readonly int UserId;
        private MyGroup group;

        public Form_CreateGroup(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        public MyGroup GetDetailGroup() { return group; }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $@"
                    insert into {DbTables.tbl_Group.Table} 
                    ({DbTables.tbl_Group.GroupName}, {DbTables.tbl_Group.Description}, {DbTables.tbl_Group.CreatedBy}) 
                    output inserted.{DbTables.tbl_Group.Id}
                    values 
                    (@GroupName, @Description, @CreatedBy) 
                ";
                SqlParameter[] parameters = {
                    new SqlParameter("@GroupName", txt_GroupName.Text),
                    new SqlParameter("@Description", txt_Description.Text),
                    new SqlParameter("@CreatedBy", UserId)
                };

                object res = Db.ExecuteScalar(query, parameters);
                if (res != null)
                {
                    // cout << :)))
                    MessageBox.Show("Tạo nhóm thành công", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int ID = Convert.ToInt32(res);
                    group = new MyGroup(ID, txt_GroupName.Text, txt_Description.Text);

                    string insertMemberQuery = $@"
                        INSERT INTO {DbTables.tbl_GroupMember.Table} 
                        ({DbTables.tbl_GroupMember.GroupId}, {DbTables.tbl_GroupMember.UserId}, {DbTables.tbl_GroupMember.Role})
                        VALUES (@GroupId, @UserId, @Role)
                    ";
                    SqlParameter[] memberParams = {
                        new SqlParameter("@GroupId", ID),
                        new SqlParameter("@UserId", UserId),
                        new SqlParameter("@Role", "Leader")
                    };
                    Db.ExecuteNonQuery(insertMemberQuery, memberParams);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // cout << :)))
                    MessageBox.Show("⚠️ Lỗi khi Tạo nhóm", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // cout << :)))
                MessageBox.Show("❌ Lỗi khi tạo nhóm:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Description_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_Create.PerformClick();
            }
        }

        private void btn_Create_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btn_Create.PerformClick();
            }
        }
    }
}
