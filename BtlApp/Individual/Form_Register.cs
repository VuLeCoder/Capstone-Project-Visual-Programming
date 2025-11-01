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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlApp.Individual
{
    public partial class Form_Register : Form
    {
        private readonly Form_Login formLogin;
        private readonly DataProcesser Db = new DataProcesser();

        public Form_Register(Form_Login formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        // ================= Hàm =====================
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private bool IsFullFill()
        {
            if (txtEmail.BackColor != Color.White)
            {
                txtEmail.Focus();
                return false;
            }

            if (lblPasswordError.Text.Trim().Length != 0)
            {
                txtPassword.Focus();
                return false;
            }
            if (lblConfirmError.Text.Trim().Length != 0)
            {
                txtRePassword.Focus();
                return false;
            }
            return true;
        }
        // ================ Sự kiện =====================
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(txtEmail.Text))
                txtEmail.BackColor = Color.White;
            else
                txtEmail.BackColor = Color.MistyRose;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            if (IsValidPassword(txtPassword.Text))
            {
                lblPasswordError.Text = "";
            }
            else
            {
                lblPasswordError.Text = "Ít nhất 8 ký tự, có chữ hoa, chữ thường, số và ký tự đặc biệt.";
                lblPasswordError.ForeColor = Color.Red;
            }
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            if (txtRePassword.Text == txtPassword.Text)
            {
                lblConfirmError.Text = "";
            }
            else
            {
                lblConfirmError.Text = "Mật khẩu nhập lại không khớp!";
                lblConfirmError.ForeColor = Color.Red;
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (!IsFullFill()) return;

            string query =
                $@"select {DbTables.tbl_User.Id}
                    from {DbTables.tbl_User.Table}
                    where {DbTables.tbl_User.Email} = @Email";

            SqlParameter[] parameters = {
                new SqlParameter("@Email", txtEmail.Text),
            };

            DataTable dt = Db.ReadTable(query, parameters);
            if(dt.Rows.Count > 0 )
            {
                MessageBox.Show("Email này đã được đăng ký tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            string username = txtUser.Text;
            if(username.Trim().Length == 0)
            {
                username = txtEmail.Text;
            }

            try
            {
                query =
                    $@"insert into {DbTables.tbl_User.Table} 
                        ({DbTables.tbl_User.Name}, {DbTables.tbl_User.Email}, {DbTables.tbl_User.Password})
                        values (@Username, @Email, @Password)";

                SqlParameter[] InsertParameters = {
                        new SqlParameter("@Username", username),
                        new SqlParameter("@Email", txtEmail.Text),
                        new SqlParameter("@Password", txtPassword.Text)
                    };

                int rowsAffected = Db.ExecuteNonQuery(query, InsertParameters);
                if (rowsAffected > 0)
                {
                    // cout << :)))
                    MessageBox.Show("Đăng ký thành công", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    // cout << :)))
                    MessageBox.Show("⚠️ Lỗi khi đăng ký", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            catch (Exception ex)
            {
                // cout << :)))
                MessageBox.Show("❌ Lỗi khi đăng ký:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_BackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Form_Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Show();
        }
    }
}
