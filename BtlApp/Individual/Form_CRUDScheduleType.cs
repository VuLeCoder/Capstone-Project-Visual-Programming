using BtlApp.Database;
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
    public partial class Form_CRUDScheduleType : Form
    {
        private readonly Form_AddMySchedule formAddSchedule;
        private readonly DataProcesser Db = new DataProcesser();

        public Form_CRUDScheduleType(Form_AddMySchedule formAddSchedule)
        {
            this.formAddSchedule = formAddSchedule;
            InitializeComponent();
        }

        // =============== Các hàm ==================
        private void setButtonState(bool isEnable)
        {
            btn_AddNewType.Enabled = !isEnable;

            btn_Save.Enabled = isEnable;
            btn_Delete.Enabled = isEnable;
            btn_Cancel.Enabled = isEnable;
        }

        private void LoadScheduleType()
        {
            string query = $@"
                select 
                    {DbTables.tbl_ScheduleType.Name}, {DbTables.tbl_ScheduleType.Description}, 
                    {DbTables.tbl_ScheduleType.ColorCode} as Color 
                from {DbTables.tbl_ScheduleType.Table}
            ";    
            DataTable dt = Db.ReadTable(query);
            dgv_ScheduleType.DataSource = dt;

            dgv_ScheduleType.Columns[DbTables.tbl_ScheduleType.Name].Width = 150;
            dgv_ScheduleType.Columns[DbTables.tbl_ScheduleType.Description].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_ScheduleType.Columns["Color"].Width = 100;
        }

        // ============= Sự kiện form ================

        private void Form_CRUDScheduleType_Load(object sender, EventArgs e)
        {
            setButtonState(false);
            LoadScheduleType();
            dgv_ScheduleType.CellFormatting += dgv_ScheduleType_CellFormatting;
        }

        private void Form_CRUDScheduleType_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAddSchedule.Show();
        }

        private void btn_AddNewType_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            setButtonState(false);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            setButtonState(false);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setButtonState(false);
        }

        private void dgv_ScheduleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setButtonState(true);
        }

        private void dgv_ScheduleType_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_ScheduleType.Columns[e.ColumnIndex].Name == "Color" && e.Value != null)
            {
                try
                {
                    Color color = ColorTranslator.FromHtml(e.Value.ToString());

                    e.CellStyle.BackColor = color;
                }
                catch {}
            }

        }
    }
}
