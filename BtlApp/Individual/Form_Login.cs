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

namespace BtlApp
{
    public partial class Form_Login : Form
    {
        private readonly DataProcesser Db = new DataProcesser();
        private string userId;
        public Form_Login()
        {
            InitializeComponent();
        }

        private bool isFullFill()
        {
            if(txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập email");
                txt_Email.Focus();
                return false;
            }
            return true;
        }

        public string getUserId()
        {
            return userId;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!isFullFill()) return;

            string query = "select userId from tblUser where email = @Email and passwordHash = @Password";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", txt_Email.Text),
                new SqlParameter("@Password", txt_Password.Text)
            };

            DataTable dt = Db.ReadTable(query, parameters);
            if(dt.Rows.Count <= 0)
            {
                MessageBox.Show("Sai email hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userId = dt.Rows[0]["userId"].ToString();
            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void link_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ForgetPassword formForget = new Form_ForgetPassword(this);
            this.Hide();
            formForget.Show();
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            Form_Register formRegister = new Form_Register(this);
            this.Hide();
            formRegister.Show();
        }
    }
}
