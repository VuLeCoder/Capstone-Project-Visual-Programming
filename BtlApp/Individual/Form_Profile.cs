using BtlApp.Database;
using FormProduct.Classes;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlApp.Individual
{
    public partial class Form_Profile : Form
    {
        private readonly Form_Manager manager;
        private readonly DataProcesser Db = new DataProcesser();
        private readonly int id;
        private readonly string pass;

        public Form_Profile(Form_Manager form)
        {
            InitializeComponent();
            manager = form;
            PassCu.Hide();
            newPass.Hide();
            xnPass.Hide();
            text_passCu.Hide();
            text_newPass.Hide();
            text_xnPass.Hide();
            uiButton1.Hide();
            Pass.Hide();
            text_pass.Hide();
            text_email.Enabled = false;
            text_id.Enabled = false;
            text_name.Enabled = false;
            id = manager.getUserId();
            uiButton6.Hide();
            uiButton7.Hide();
            uiButton8.Hide();
            string query =
                $@"select *
                    from {DbTables.tbl_User.Table} 
                    where {DbTables.tbl_User.Id} = {id}
                ";
            DataTable dt = Db.ReadTable(query);

            if (dt.Rows.Count > 0)
            {
                text_email.Text = dt.Rows[0]["Email"].ToString();
                text_name.Text = dt.Rows[0]["UserName"].ToString();
                text_id.Text = dt.Rows[0]["UserId"].ToString();
                pass = dt.Rows[0]["PasswordHash"].ToString();
            }
            uiButton4.Hide();
            uiButton5.Hide();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void uiAvatar1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string query =
               $@"update {DbTables.tbl_User.Table} set
                    {DbTables.tbl_User.Password} = '{text_newPass.Text}'
                    where {DbTables.tbl_User.Id} = {id}
                ";
            if (IsValidPassword(text_newPass.Text) == false)
            {
                MessageBox.Show("Ít nhất 8 ký tự, có chữ hoa, chữ thường, số và ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                Db.ExecuteNonQuery(query);
            }
            text_passCu.Text = "";
            text_newPass.Text = "";
            text_xnPass.Text = "";
            uiButton3.Show();
            uiButton1.Hide();
            PassCu.Hide();
            newPass.Hide();
            xnPass.Hide();
            text_passCu.Hide();
            text_newPass.Hide();
            text_xnPass.Hide();
            uiButton8.Hide();

        }

        private void Form_Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.Show();
        }

        private void btn_Find_Click_1(object sender, EventArgs e)
        {
            btn_Find.Hide();
            text_name.Enabled = true;
            uiButton4.Show();
            uiButton6.Show();
        }

        private void Form_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn quay lại?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiButton2.Hide();
            text_email.Enabled = true;
            uiButton5.Show();
            uiButton7.Show();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            uiButton3.Hide();
            uiButton1.Show();
            PassCu.Show();
            newPass.Show();
            xnPass.Show();
            text_passCu.Show();
            text_newPass.Show();
            text_xnPass.Show();
            uiButton8.Show();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {

            string query =
               $@"update {DbTables.tbl_User.Table} 
                set {DbTables.tbl_User.Name} = '{text_name.Text}' 
               where {DbTables.tbl_User.Id} = {id}
             ";

            //MessageBox.Show(query);

            Db.ExecuteNonQuery(query);
            text_name.Enabled = false;
            uiButton4.Hide();
            btn_Find.Show();
            uiButton6.Hide();
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            string query =
               $@"update {DbTables.tbl_User.Table} set
                    {DbTables.tbl_User.Email} = '{text_email.Text}'
                    where {DbTables.tbl_User.Id} = {id}
                ";

            if (IsValidEmail(text_email.Text) == false)
            {
                MessageBox.Show("Email nhập sai", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Đổi email thành công!", "Thông báo", MessageBoxButtons.OK);
                Db.ExecuteNonQuery(query);
            }
            text_email.Enabled = false;
            uiButton5.Hide();
            uiButton2.Show();
            uiButton7.Hide();
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            string query =
                $@"select *
                    from {DbTables.tbl_User.Table} 
                    where {DbTables.tbl_User.Id} = {id}
                ";
            DataTable dt = Db.ReadTable(query);

            if (dt.Rows.Count > 0)
            {
                text_name.Text = dt.Rows[0]["UserName"].ToString();
            }
            text_name.Enabled = false;
            uiButton4.Hide();
            btn_Find.Show();
            uiButton6.Hide();
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            string query =
                $@"select *
                    from {DbTables.tbl_User.Table} 
                    where {DbTables.tbl_User.Id} = {id}
                ";
            DataTable dt = Db.ReadTable(query);

            if (dt.Rows.Count > 0)
            {
                text_email.Text = dt.Rows[0]["Email"].ToString();
            }
            text_email.Enabled = false;
            uiButton5.Hide();
            uiButton2.Show();
            uiButton7.Hide();
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            text_passCu.Text = "";
            text_newPass.Text = "";
            text_xnPass.Text = "";
            uiButton3.Show();
            uiButton1.Hide();
            PassCu.Hide();
            newPass.Hide();
            xnPass.Hide();
            text_passCu.Hide();
            text_newPass.Hide();
            text_xnPass.Hide();
            uiButton8.Hide();
        }
    }
}
