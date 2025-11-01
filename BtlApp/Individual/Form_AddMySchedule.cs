using BtlApp.Database;
using BtlApp.Database.Models;
using FormProduct.Classes;
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

        private readonly DataProcesser Db = new DataProcesser();

        public Form_AddMySchedule()
        {
            InitializeComponent();
        }

        // ===================================================================================
        // ======================== Hàm hỗ trợ ========================
        private void FillComboBox(ComboBox comboBox, string table, string display, string val)
        {
            if (comboBox.Items.Count > 0) return;

            string query = $@"
                select {display}, {val} 
                from {table} 
                order by {val}";
            DataTable dt = Db.ReadTable(query);

            comboBox.DataSource = dt;
            comboBox.DisplayMember = display;
            comboBox.ValueMember = val;
        }

        private bool IsValid()
        {
            float startTime = Convert.ToSingle(cb_StartHour.SelectedValue);
            float endTime = Convert.ToSingle(cb_EndHour.SelectedValue);
            if (startTime >= endTime)
            {
                MessageBox.Show("Thời gian bắt đầu < thời gian kết thúc");
                cb_EndHour.Focus();
                return false;
            }
            return true;
        }

        private void FillAllComboBox()
        {
            FillComboBox(cb_StartHour, DbTables.tbl_TimeSLot.Table, DbTables.tbl_TimeSLot.TimeStr, DbTables.tbl_TimeSLot.TimeVal);
            FillComboBox(cb_EndHour, DbTables.tbl_TimeSLot.Table, DbTables.tbl_TimeSLot.TimeStr, DbTables.tbl_TimeSLot.TimeVal);
            FillComboBox(cb_TypeSchedule, DbTables.tbl_ScheduleType.Table, DbTables.tbl_ScheduleType.Name, DbTables.tbl_ScheduleType.Id);
        }

        // ================ Tương tác với form ngoài ==================
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

        public MySchedule getData()
        {
            int typeId = Convert.ToInt32(cb_TypeSchedule.SelectedValue);
            string title = txt_Title.Text;
            DateTime date = dtp_Date.Value.Date;
            float startTime = Convert.ToSingle(cb_StartHour.SelectedValue); // BUG bug Bug
            float endTime = Convert.ToSingle(cb_EndHour.SelectedValue);

            return new MySchedule(-1, typeId, title, date, startTime, endTime);
        }

        public void setData(DateTime currDay, float currHour)
        {
            FillAllComboBox();

            dtp_Date.Value = currDay;
            cb_StartHour.SelectedValue = Convert.ToDecimal(currHour);
            cb_EndHour.SelectedValue = Convert.ToDecimal(Math.Min(currHour + 1, 24));
        }

        public void setData(MySchedule schedule)
        {
            FillAllComboBox();

            txt_Title.Text = schedule.Title;
            dtp_Date.Value = schedule.ScheduleDate;
            cb_StartHour.SelectedValue = Convert.ToDecimal(schedule.StartTime);
            cb_EndHour.SelectedValue = Convert.ToDecimal(schedule.EndTime);
        }

        // ======================== Các sự kiện =======================

        private void Form_AddMySchedule_Load(object sender, EventArgs e)
        {
            FillAllComboBox();
            if(cb_StartHour.SelectedIndex == cb_EndHour.SelectedIndex) cb_EndHour.SelectedIndex = 2;
        }
        private void btn_AddTypeSchedule_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            this.DialogResult = DialogResult.Yes;
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
            this.Close();
        }
    }
}
