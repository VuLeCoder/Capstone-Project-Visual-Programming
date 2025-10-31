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

        public Form_Manager(string userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
