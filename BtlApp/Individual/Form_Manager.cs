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
    public partial class Form_Manager : Form
    {
        private readonly string userId;
        private bool isLogout = false;

        public Form_Manager(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        public bool IsLogout()
        {
            return isLogout == true;
        }

        private void Form_Manager_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLogout = true;
            this.Close();
        }
    }
}
