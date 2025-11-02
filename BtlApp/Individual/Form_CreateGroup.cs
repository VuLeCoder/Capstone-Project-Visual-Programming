using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtlApp.Individual
{
    public partial class Form_CreateGroup : Form
    {
        public String GroupName { get; set; }
        public String Description { get; set; }
        public Form_CreateGroup()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {  
            GroupName = txtName.Text;
            Description = rtb_Description.Text;



            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void Form_CreateGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                lblNameNull.Text = "Tên group không được để trống!";
                lblNameNull.ForeColor = Color.Red;
                btnCreate.Enabled = false;
            }
            else
            {
                lblNameNull.Text = "";
                lblNameNull.ForeColor = this.ForeColor;
                btnCreate.Enabled = true;
            }
        }

        private void rtb_Description_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(rtb_Description.Text))
            {
                lblDescriptionNull.Text = "Mô tả không được để trống!";
                lblDescriptionNull.ForeColor = Color.Red;
                btnCreate.Enabled = false;
            }
            else
            {
                lblDescriptionNull.Text = "";
                lblDescriptionNull.ForeColor = this.ForeColor;
                btnCreate.Enabled = true;
            }
        }
    }
}
