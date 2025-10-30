using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BtlApp.Database.Models;

namespace BtlApp.Individual
{
    public partial class Form_AddMySchedule : Form
    {
        public const int TYPE_ADD = 1;
        public const int TYPE_EDIT = 2;

        public MySchedule ScheduleResult { get; private set; }
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
                    btn_Delete.Enabled = true;
                    break;
            }
        }

        private void getData()
        {
            string title = txt_Title.Text;
            DateTime date = dtp_Date.Value.Date;
            //float startTime = float.Parse(cb_StartHour.SelectedValue.ToString()); // BUG bug Bug
            //float endTime = float.Parse(cb_EndHour.SelectedValue.ToString());

            float startTime = 4.5F;
            float endTime = 5.5F;

            ScheduleResult = new MySchedule("", title, date, startTime, endTime);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            getData();
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            getData();
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            getData();
            this.Close();
        }
    }
}
