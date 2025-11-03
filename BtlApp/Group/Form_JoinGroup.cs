using BtlApp.Database;
using BtlApp.Database.Models;
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
    public partial class Form_JoinGroup : Form
    {
        private readonly DataProcesser Db = new DataProcesser();
        private readonly int UserId;
        private int GroupId;

        public int GetGroupId() {  return GroupId; }

        public Form_JoinGroup(int UserId)
        {
            this.UserId = UserId;
            InitializeComponent();
        }

        private bool IsFill()
        {
            if(txtGroupId.Text.Trim().Length == 0)
            {
                lbl_Error.Text = "Please enter group Id";
                return false;
            }

            return true;
        }

        private bool IsExistId(int groupId)
        {
            string checkGroupQuery = $@"
                select {DbTables.tbl_Group.GroupName}
                from {DbTables.tbl_Group.Table} 
                where {DbTables.tbl_Group.Id} = @GroupId
            ";
            SqlParameter[] checkParams = {
                new SqlParameter("@GroupId", groupId)
            };

            DataTable dt = Db.ReadTable(checkGroupQuery, checkParams);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (!IsFill()) return;
            int groupId = Convert.ToInt32(txtGroupId.Text);
            if (!IsExistId(groupId))
            {
                MessageBox.Show("Group ID không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GroupId = groupId;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtGroupId_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Text = "";
        }
    }
}
