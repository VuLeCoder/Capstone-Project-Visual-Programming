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
    public partial class Form_Register : Form
    {
        private readonly Form_Login formLogin;

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

        public Form_Register(Form_Login formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void linkAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            formLogin.Show();
            this.Close();
        }

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
    }
}
