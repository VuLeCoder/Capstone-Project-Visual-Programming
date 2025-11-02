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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BtlApp.Individual
{
    public partial class Form_CRUDScheduleType : Form
    {
        private readonly Form_AddMySchedule formAddSchedule;
        private readonly DataProcesser Db = new DataProcesser();

        private bool isAdding = false;
        private int selectedTypeId = -1;

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
                    {DbTables.tbl_ScheduleType.Id},
                    {DbTables.tbl_ScheduleType.Name}, {DbTables.tbl_ScheduleType.Description}, 
                    {DbTables.tbl_ScheduleType.ColorCode} as Color 
                from {DbTables.tbl_ScheduleType.Table}
            ";    
            DataTable dt = Db.ReadTable(query);
            dgv_ScheduleType.DataSource = dt;

            dgv_ScheduleType.Columns[DbTables.tbl_ScheduleType.Id].Visible = false;
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
            //formAddSchedule.Show();
        }

        private void btn_AddNewType_Click(object sender, EventArgs e)
        {
            btn_AddNewType.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;

            isAdding = true;
            selectedTypeId = -1;

            txt_Name.Clear();
            txt_Description.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text.Trim();
            string desc = txt_Description.Text.Trim();
            string color = ColorTranslator.ToHtml(cp_Color.Value);

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Tên loại và mã màu không được để trống!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isAdding)
            {
                string query = $@"
                    insert into {DbTables.tbl_ScheduleType.Table} 
                        ({DbTables.tbl_ScheduleType.Name}, {DbTables.tbl_ScheduleType.Description}, {DbTables.tbl_ScheduleType.ColorCode}) 
                    values (N'{name}', N'{desc}', '{color}');
                ";
                Db.ExecuteNonQuery(query);
                MessageBox.Show("Đã thêm loại lịch mới!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = $@"
                    update {DbTables.tbl_ScheduleType.Table} 
                    set 
                        {DbTables.tbl_ScheduleType.Name} = N'{name}',
                        {DbTables.tbl_ScheduleType.Description} = N'{desc}',
                        {DbTables.tbl_ScheduleType.ColorCode} = '{color}'
                    where {DbTables.tbl_ScheduleType.Id} = {selectedTypeId};
                ";
                Db.ExecuteNonQuery(query);
                MessageBox.Show("Đã cập nhật loại lịch!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadScheduleType();
            setButtonState(false);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // Xác nhận xóa
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa loại lịch này?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            // Check có lịch nào dùng không
            string checkQuery = $@"
                select count(*) 
                from {DbTables.tbl_Schedule.Table} 
                where {DbTables.tbl_Schedule.IdType} = {selectedTypeId}";
            int count = Convert.ToInt32(Db.ExecuteScalar(checkQuery));

            if (count > 0)
            {
                MessageBox.Show("Không thể xóa loại lịch này vì đang được sử dụng trong bảng Lịch.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Xóa
            string deleteQuery = $@"
                delete from {DbTables.tbl_ScheduleType.Table} 
                where {DbTables.tbl_ScheduleType.Id} = {selectedTypeId}";
            Db.ExecuteNonQuery(deleteQuery);

            MessageBox.Show("Đã xóa loại lịch.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadScheduleType();
            setButtonState(false);
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            setButtonState(false);
        }

        private void dgv_ScheduleType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            isAdding = false;
            DataGridViewRow row = dgv_ScheduleType.Rows[e.RowIndex];
            selectedTypeId = Convert.ToInt32(row.Cells[DbTables.tbl_ScheduleType.Id].Value);

            txt_Name.Text = row.Cells[DbTables.tbl_ScheduleType.Name].Value.ToString();
            txt_Description.Text = row.Cells[DbTables.tbl_ScheduleType.Description].Value.ToString();

            string hex = row.Cells["Color"].Value.ToString();
            cp_Color.Value = ColorTranslator.FromHtml(hex);

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
