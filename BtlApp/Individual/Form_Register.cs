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
    public partial class Form_Register : Form
    {
        private readonly Form_Login formLogin;

        public Form_Register(Form_Login formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
