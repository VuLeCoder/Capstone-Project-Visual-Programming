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
    public partial class Form_JoinGroup : Form
    {   
        public int GroupId { get; set; }
        public Form_JoinGroup()
        {
            InitializeComponent();
        }

        private void Form_JoinGroup_Load(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            GroupId = int.Parse(txtGroupId.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtGroupId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtGroupId.Text))
            {
                lblGroupIdNull.Text = "Mã nhóm không được để trống!";
                lblGroupIdNull.ForeColor = Color.Red;
                btnJoin.Enabled = false;
            }
            else
            {
                lblGroupIdNull.Text = "";
                lblGroupIdNull.ForeColor = this.ForeColor;
                btnJoin.Enabled = true;
            }
        }
    }
}
