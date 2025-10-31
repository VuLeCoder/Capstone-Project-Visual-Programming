using BtlApp.Database.Models;
using BtlApp.Individual;
using FormProduct.Classes;
using Krypton.Toolkit;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BtlApp
{
    public partial class Form_MySchedule : Form
    {
        public Form_MySchedule()
        {
            InitializeComponent();
            createCalendar();
        }
        // ========================= Các hằng ==========================
        private readonly Color TASK_COLOR = Color.FromArgb(168, 199, 250);
        private readonly int WEEK = 7, HOUR = 24;
        private readonly string[] DAY_NAMES = { "CN", "TH 2", "TH 3", "TH 4", "TH 5", "TH 6", "TH 7" };
        private readonly int TIMELIME_WIDTH = 40, TASK_CELL_HEIGHT = 60, BORDER = 1;
        private readonly Color CALENDAR_BACKCOLOR = Color.FromArgb(19, 19, 20);

        private readonly float WIDTH_PERCENT = 0.7F;
        private readonly Font TITLE_FONT = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

        // ==================== Các biến toàn cục ======================
        private readonly DataProcesser Db = new DataProcesser();
        private DateTime currentWeek;



// =====================================================================
        // ====================== ... ======================
        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = date.DayOfWeek - DayOfWeek.Sunday;
            if (diff < 0) diff += 7;
            return date.AddDays(-diff).Date;
        }

        private void updateHeaderCalendar(DateTime week)
        {
            if (week == currentWeek) { return; }
            currentWeek = week;

            DateTime date;
            for (int i = 0; i < WEEK; ++i)
            {
                date = week.AddDays(i);
                Control cell = tlp_mainCalendarHeader.GetControlFromPosition(i + 1, 0);
                if(cell is Label dayLabel)
                {
                    dayLabel.Text = $"{DAY_NAMES[(int)date.DayOfWeek]}\n{date:dd/MM/yyyy}";
                    dayLabel.ForeColor = date.Date == DateTime.Now.Date ? Color.FromArgb(144, 202, 249) : Color.White;
                }
            }

            updateCalendar();
        }

        private void updateCalendar()
        {
            for (int h = 0; h < HOUR; ++h)
            {
                for (int d = 0; d < WEEK; ++d)
                {
                    Control cell = tlp_mainCalendar.GetControlFromPosition(d + 1, h);
                    if (cell.Controls.Count == 0) continue;

                    if (cell is UIPanel panel)
                    {
                        panel.Margin = new Padding(BORDER, 0, 0, BORDER);
                        panel.FillColor = CALENDAR_BACKCOLOR;
                        panel.Controls.Clear();
                    }

                    LoadScheduleFromDB();
                }
            }
        }
// =====================================================================

// =====================================================================

        // ====================== Giao diện lịch ======================
        private void createHeaderCalendar()
        {
            tlp_mainCalendarHeader.ColumnCount = DAY_NAMES.Length + 1;
            tlp_mainCalendarHeader.Controls.Clear();
            tlp_mainCalendarHeader.ColumnStyles.Clear();

            tlp_mainCalendarHeader.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            tlp_mainCalendarHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, TIMELIME_WIDTH));
            for (int i = 0; i < WEEK; ++i)
            {
                tlp_mainCalendarHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / WEEK));
            }

            DateTime currentWeekStart = GetStartOfWeek(DateTime.Now);
            currentWeek = currentWeekStart;
            DateTime date;

            Label noneLabel = new Label
            {
                Margin = new Padding(0),
                Dock = DockStyle.Fill,
                BackColor = CALENDAR_BACKCOLOR
            };
            tlp_mainCalendarHeader.Controls.Add(noneLabel);

            for (int i = 0; i < WEEK; ++i)
            {
                date = currentWeekStart.AddDays(i);
                Label dayLabel = new Label
                {
                    Text = $"{DAY_NAMES[(int)date.DayOfWeek]}\n{date:dd/MM/yyyy}",
                    Margin = new Padding(0),
                    Padding = new Padding(BORDER, 0, 0, 0),
                    Dock = DockStyle.Fill,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,

                    BackColor = CALENDAR_BACKCOLOR,

                    ForeColor = date.Date == DateTime.Now.Date ? Color.FromArgb(144, 202, 249) : Color.White
                };
                tlp_mainCalendarHeader.Controls.Add(dayLabel, i + 1, 0);
            }
        }

        private void createTimeSlotCalendar()
        {
            int hour;
            for (int h = 0; h < HOUR; ++h)
            {
                hour = (h == 12) ? h : h % 12;
                Label timeLabel = new Label
                {
                    Text = $"{hour} AM".Replace("AM", h >= 12 ? "PM" : "AM"),
                    Dock = DockStyle.Fill,
                    Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(0, 0, 0, BORDER),
                    BackColor = CALENDAR_BACKCOLOR,
                    ForeColor = Color.White,
                };
                tlp_mainCalendar.Controls.Add(timeLabel, 0, h);

                for (int d = 0; d < WEEK; ++d)
                {
                    UIPanel panel = new UIPanel
                    {
                        Dock = DockStyle.Fill,
                        FillColor = CALENDAR_BACKCOLOR,
                        RectColor = CALENDAR_BACKCOLOR,
                        Radius = 0,
                        Margin = new Padding(BORDER, 0, 0, BORDER),
                        Padding = new Padding(0),
                        Tag = new { Day = d, Hour = h }
                    };
                    panel.MouseClick += TimeSlot_MouseClick;
                    tlp_mainCalendar.Controls.Add(panel, d + 1, h);
                }
            }
        }

        private void createCalendar()
        {
            createHeaderCalendar();
            panelMain.BackColor = CALENDAR_BACKCOLOR;

            tlp_mainCalendar.ColumnCount = WEEK + 1;
            tlp_mainCalendar.RowCount = HOUR;

            tlp_mainCalendar.Controls.Clear();
            tlp_mainCalendar.ColumnStyles.Clear();
            tlp_mainCalendar.RowStyles.Clear();

            tlp_mainCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, TIMELIME_WIDTH));
            for (int i = 0; i < WEEK; ++i)
            {
                tlp_mainCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / WEEK));
            }

            for (int i = 0; i < HOUR; ++i)
            {
                tlp_mainCalendar.RowStyles.Add(new RowStyle(SizeType.Absolute, TASK_CELL_HEIGHT));
            }

            createTimeSlotCalendar();
            LoadScheduleFromDB();

            AddScheduleToCell(1, 7.25F, 10.5F, "Lịch học Toán", Color.FromArgb(66, 165, 245), "1");
        }


// =====================================================================

// =====================================================================

        // ====================== Database ======================
        private void LoadScheduleFromDB()
        {
            DateTime DayStart = currentWeek;
            DateTime DayEnd = currentWeek.AddDays(6);

            string query = "select * from MySchedule where ScheduleDate between @Start and @End order by ScheduleDate";
            SqlParameter[] parameters = {
                new SqlParameter("@Start", DayStart.Date),
                new SqlParameter("@End", DayEnd.Date)
            };

            DataTable dt = Db.ReadTable(query, parameters);

            // cout << :)))
            //MessageBox.Show(dt.Rows.Count.ToString());

            foreach (DataRow row in dt.Rows)
            {
                DateTime scheduleDate = Convert.ToDateTime(row["ScheduleDate"]);
                int dayIndex = (scheduleDate - DayStart).Days;

                float startSchedule = Convert.ToSingle(row["StartTime"]);
                float endSchedule = Convert.ToSingle(row["EndTime"]);

                string title = row["Title"].ToString();
                Color blockColor = Color.FromArgb(66, 165, 245);
                string id = row["ID"].ToString();

                AddScheduleToCell(dayIndex, startSchedule, endSchedule, title, blockColor, id);
            }
        }


        private bool IsDuplicate(MySchedule schedule)
        {
            string query = "select * from MySchedule where ScheduleDate = @Date and (StartTime < @End and EndTime > @Start) and ID <> @ID";
            SqlParameter[] parameters = {
                new SqlParameter("@Date", schedule.ScheduleDate),
                new SqlParameter("@Start", schedule.StartTime),
                new SqlParameter("@End", schedule.EndTime),
                new SqlParameter("@ID", schedule.Id)
            };

            DataTable dt = Db.ReadTable(query, parameters);
            return dt.Rows.Count > 0;
        }

        private void AddScheduleToDB(MySchedule schedule)
        {
            if(IsDuplicate(schedule))
            {
                MessageBox.Show("Lịch bị trùng thời gian");
                return;
            }

            try
            {
                string query = @"
                    insert into MySchedule (Title, ScheduleDate, StartTime, EndTime)
                    output inserted.ID
                    values (@Title, @ScheduleDate, @StartTime, @EndTime);
                ";

                SqlParameter[] InsertParameters = {
                    new SqlParameter("@Title", schedule.Title),
                    new SqlParameter("@ScheduleDate", schedule.ScheduleDate),
                    new SqlParameter("@StartTime", schedule.StartTime),
                    new SqlParameter("@EndTime", schedule.EndTime)
                };

                object result = Db.ExecuteScalar(query, InsertParameters);

                if (result != null)
                {
                    // cout << :)))
                    string newId = Convert.ToInt32(result).ToString();
                    schedule.Id = newId;
                    MessageBox.Show($"✅ Thêm lịch thành công! ID mới: {newId}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int dayIndex = (schedule.ScheduleDate - currentWeek).Days;
                    if(dayIndex >= 0 && dayIndex < 7)
                    {
                        AddScheduleToCell(dayIndex, schedule.StartTime, schedule.EndTime, schedule.Title, Color.Red, schedule.Id);
                    }
                }
                else
                {
                    // cout << :)))
                    MessageBox.Show("⚠️ Không lấy được ID mới.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // cout << :)))
                MessageBox.Show("❌ Lỗi khi thêm lịch:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool UpdateSchedule(MySchedule schedule)
        {
            if (IsDuplicate(schedule))
            {
                MessageBox.Show("Lịch bị trùng thời gian");
                return false;
            }

            string query = @"
                UPDATE MySchedule
                SET 
                    Title = @Title,
                    ScheduleDate = @Date,
                    StartTime = @Start,
                    EndTime = @End
                WHERE ID = @ID";

            SqlParameter[] parameters = {
                new SqlParameter("@ID", schedule.Id),
                new SqlParameter("@Title", schedule.Title),
                new SqlParameter("@Date", schedule.ScheduleDate.Date),
                new SqlParameter("@Start", schedule.StartTime),
                new SqlParameter("@End", schedule.EndTime)
            };

            int rowsAffected = Db.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }


        public bool DeleteSchedule(string scheduleId)
        {
            string query = "DELETE FROM MySchedule WHERE ID = @ID";

            SqlParameter[] parameters = {
                new SqlParameter("@ID", scheduleId)
            };

            int rowsAffected = Db.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }





        // ====================== Các sự kiện ======================

        private void btn_AddSchedule_Click(object sender, EventArgs e)
        {
            Form_AddMySchedule addSchedlueForm = new Form_AddMySchedule();
            addSchedlueForm.formType(Form_AddMySchedule.TYPE_ADD);
            DialogResult result = addSchedlueForm.ShowDialog();

            if (result == DialogResult.OK) // Them lich
            {
                AddScheduleToDB(addSchedlueForm.getData());
                return;
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDay = monthCalendar.SelectionStart;
            updateHeaderCalendar(GetStartOfWeek(selectedDay));
        }

        private void TimeSlot_MouseClick(object sender, MouseEventArgs e)
        {
            Form_AddMySchedule addSchedlueForm = new Form_AddMySchedule();
            addSchedlueForm.formType(Form_AddMySchedule.TYPE_ADD);
            DialogResult result = addSchedlueForm.ShowDialog();

            if (result == DialogResult.OK) // Them lich
            {
                AddScheduleToDB(addSchedlueForm.getData());
                return;
            }
        }

        private void ScheduleBlock_MouseClick(object sender, MouseEventArgs e)
        {
            UIPanel panel = sender as UIPanel;
            dynamic tagData = panel.Tag;
            string id = tagData.Id;

            DataTable dt = Db.ReadTable("SELECT * FROM MySchedule WHERE ID = @ID",
                new SqlParameter[] { new SqlParameter("@ID", id) });

            if (dt.Rows.Count == 0)
            {
                // cout 
                MessageBox.Show("Không tìm thấy lịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows[0];
            MySchedule schedule = new MySchedule(
                row["ID"].ToString(),
                row["Title"].ToString(),
                Convert.ToDateTime(row["ScheduleDate"]),
                Convert.ToSingle(row["StartTime"]),
                Convert.ToSingle(row["EndTime"])
            );

            Form_AddMySchedule addSchedlueForm = new Form_AddMySchedule();
            addSchedlueForm.formType(Form_AddMySchedule.TYPE_EDIT);
            addSchedlueForm.setData(schedule);
            DialogResult result = addSchedlueForm.ShowDialog();

            if(result == DialogResult.Yes)
            {
                schedule = addSchedlueForm.getData();
                schedule.Id = id;
                UpdateSchedule(schedule);
                return;
            }

            if(result == DialogResult.No)
            {
                DeleteSchedule(id);
            }
        }



        /*
         * 
         * private void ScheduleBlock_MouseClick(object sender, MouseEventArgs e)
{
    UIPanel panel = sender as UIPanel;
    if (panel == null) return;

    // Lấy thông tin từ Tag
    dynamic tagData = panel.Tag;
    int dayIndex = tagData.Day;
    string scheduleId = tagData.Id;

    // Lấy dữ liệu lịch hiện tại từ Db để gửi sang Form chỉnh sửa
    DataTable dt = Db.ReadTable("SELECT * FROM MySchedule WHERE ID = @ID", 
        new SqlParameter[] { new SqlParameter("@ID", scheduleId) });

    if (dt.Rows.Count == 0)
    {
        MessageBox.Show("Không tìm thấy lịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    DataRow row = dt.Rows[0];
    MySchedule schedule = new MySchedule(
        row["ID"].ToString(),
        row["Title"].ToString(),
        Convert.ToDateTime(row["ScheduleDate"]),
        Convert.ToSingle(row["StartTime"]),
        Convert.ToSingle(row["EndTime"])
    );

    // Mở Form chỉnh sửa
    Form_AddMySchedule addScheduleForm = new Form_AddMySchedule();
    addScheduleForm.formType(Form_AddMySchedule.TYPE_EDIT);
    addScheduleForm.SetScheduleData(schedule); // truyền dữ liệu cũ sang Form
    DialogResult result = addScheduleForm.ShowDialog();

    if (result == DialogResult.Yes) // Chỉnh sửa
    {
        // Lấy dữ liệu mới từ Form
        MySchedule updatedSchedule = addScheduleForm.GetScheduleData();

        // Kiểm tra trùng lịch trước khi cập nhật
        if (IsTimeSlotAvailable(updatedSchedule, scheduleId))
        {
            bool updated = UpdateSchedule(updatedSchedule);
            if (updated)
            {
                MessageBox.Show("Cập nhật lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCalendar(); // vẽ lại lịch
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("Thời gian trùng với lịch khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        return;
    }

    if (result == DialogResult.No) // Xóa
    {
        DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa lịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirm == DialogResult.Yes)
        {
            bool deleted = DeleteSchedule(scheduleId);
            if (deleted)
            {
                MessageBox.Show("Xóa lịch thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCalendar(); // vẽ lại lịch
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

         */


        // ====================== Hàm xử lý logic ======================


        private void AddScheduleToCell(int dayIndex, float startSchedule, float endSchedule, string title, Color blockColor, string id)
        {
            int startHour = (int)startSchedule;
            int endHour = (int)endSchedule;
            float startMinute = startSchedule - startHour;
            float endMinute = endSchedule - endHour;

            Control cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, startHour);
            UIPanel scheduleBlockFirst = new UIPanel
            {
                Name = id,
                Margin = new Padding(0),
                BackColor = blockColor,
                FillColor = blockColor,
                Tag = new { Day = dayIndex, Id = id }
            };

            int height = (int)((1 - startMinute) * cell.Height);
            int width = (int)(cell.Width * WIDTH_PERCENT);
            scheduleBlockFirst.Location = new Point(0, cell.Height - height);

            if (startHour == endHour)
            {
                height = (int)((endMinute - startMinute) * cell.Height);
            } 
            else
            {
                cell.Margin = new Padding(BORDER, 0, 0, 0);
            }
            scheduleBlockFirst.Size = new Size(width, height + 1);
            scheduleBlockFirst.MouseClick += ScheduleBlock_MouseClick;

            Label lblTitle = new Label
            {
                Text = $"{title}",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = TITLE_FONT,
                TextAlign = ContentAlignment.TopLeft,
                BackColor = Color.Transparent
            };
            scheduleBlockFirst.Controls.Add(lblTitle);

            cell.Controls.Add(scheduleBlockFirst);

            for (int h = startHour + 1; h < endHour; ++h)
            {
                cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, h);
                if (cell is UIPanel panel)
                {
                    UIPanel scheduleBlock = new UIPanel
                    {
                        Name = id,
                        Location = new Point(0, 0),
                        Size = new Size(width, panel.Height + 1),
                        BackColor = blockColor,
                        FillColor = blockColor,
                        Margin = new Padding(0),
                        Tag = new { Day = dayIndex, Id = id }
                    };

                    panel.Controls.Add(scheduleBlock);
                    panel.Margin = new Padding(BORDER, 0, 0, 0);
                    scheduleBlock.MouseClick += ScheduleBlock_MouseClick;
                    scheduleBlock.BringToFront();
                }
            }

            if(startHour < endHour)
            {
                cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, endHour);
                UIPanel scheduleBlockEnd = new UIPanel
                {
                    Name = id,
                    Location = new Point(0, 0),
                    BackColor = blockColor,
                    FillColor = blockColor,
                    Margin = new Padding(0),
                    Tag = new { Day = dayIndex, Id = id }
                };

                height = (int)(cell.Height * endMinute);
                scheduleBlockEnd.Size = new Size(width, height);
                scheduleBlockEnd.MouseClick += ScheduleBlock_MouseClick;
                cell.Controls.Add(scheduleBlockEnd);
            }
        }

        private void RemoveSchedule(int dayIndex, string id)
        {
            for(int h=0; h<HOUR; ++h)
            {
                Control cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, h);
                cell.Controls.RemoveByKey(id);

                if(cell.Controls.Count == 0 )
                {
                    cell.Margin = new Padding(BORDER, 0, 0, BORDER);
                }
            }
        }


// =====================================================================
// =====================================================================
    }
}
