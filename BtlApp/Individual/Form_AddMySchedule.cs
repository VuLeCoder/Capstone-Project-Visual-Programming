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
    public partial class Form_AddMySchedule : Form
    {
        public const int TYPE_ADD = 1;
        public const int TYPE_EDIT = 2;
        public Form_AddMySchedule()
        {
            InitializeComponent();
        }

        public void formType(int type)
        {
            switch(type)
            {
                case TYPE_ADD:
                    btn_Add.Enabled = true;
                    break;

                case TYPE_EDIT:
                    btn_Save.Enabled = true;
                    break;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
