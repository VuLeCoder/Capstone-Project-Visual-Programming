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

namespace BtlApp.Individual
{
    public partial class Form_ForgetPassword : Form
    {
        private readonly DataProcesser Db = new DataProcesser();
        private readonly Form_Login formLogin;

        public Form_ForgetPassword(Form_Login formLogin)
        {
            this.formLogin = formLogin;
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string query = 
                $@"select {DbTables.tbl_User.Password} 
                    from {DbTables.tbl_User.Table} 
                    where {DbTables.tbl_User.Email} = @Email";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", txt_Email.Text)
            };

            DataTable dt = Db.ReadTable(query, parameters);
            if(dt.Rows.Count == 0 )
            {
                lbl_Notification.Text = "Không tìm thấy tài khoản nào tương ứng";
                return;
            }

            string text = "Mật khẩu: ";
            text += dt.Rows[0][DbTables.tbl_User.Password].ToString();
            lbl_Notification.Text = text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            lbl_Notification.Text = "";
        }

        private void Form_ForgetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Show();
        }
    }
}
