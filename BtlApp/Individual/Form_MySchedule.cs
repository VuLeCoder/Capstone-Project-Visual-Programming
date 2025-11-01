using BtlApp.Database;
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
        public Form_MySchedule(Form_Manager manager)
        {
            this.manager = manager;
            UserId = manager.getUserId();
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

        private readonly string NAME_CALENDAR_BLOCK = "Schedule_";

        // ==================== Các biến toàn cục ======================
        private readonly DataProcesser Db = new DataProcesser();
        private DateTime currentWeek;
        private readonly Form_Manager manager;
        private readonly int UserId;


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
        }


// =====================================================================

// =====================================================================

        // ====================== Database ======================
        private Color getColorFromScheduleType(int TypeId)
        {
            string query = $@"
                select {DbTables.tbl_ScheduleType.ColorCode} 
                from {DbTables.tbl_ScheduleType.Table} 
                where {DbTables.tbl_ScheduleType.Id} = @TypeId
            ";
            DataTable dt = Db.ReadTable(query, new SqlParameter[] { new SqlParameter("@TypeId", TypeId) });
            return ColorTranslator.FromHtml(dt.Rows[0][DbTables.tbl_ScheduleType.ColorCode].ToString());
        }

        private void LoadScheduleFromDB()
        {
            DateTime DayStart = currentWeek;
            DateTime DayEnd = currentWeek.AddDays(6);

            string query = $@"
                select 
                    s.{DbTables.tbl_Schedule.IdSchedule}, 
                    s.{DbTables.tbl_Schedule.Title}, 
                    s.{DbTables.tbl_Schedule.Date},  
                    s.{DbTables.tbl_Schedule.Start}, 
                    s.{DbTables.tbl_Schedule.End}, 
                    s.{DbTables.tbl_Schedule.IdType} 
                from {DbTables.tbl_Schedule.Table} s  
                where s.{DbTables.tbl_Schedule.IdUser} = @UserId and 
                    s.{DbTables.tbl_Schedule.Date} between @Start and @End 
                order by s.{DbTables.tbl_Schedule.Date}";

            SqlParameter[] parameters = {
                new SqlParameter("@UserId", UserId),
                new SqlParameter("@Start", DayStart.Date),
                new SqlParameter("@End", DayEnd.Date)
            };

            DataTable dt = Db.ReadTable(query, parameters);

            // cout << :)))
            //MessageBox.Show(dt.Rows.Count.ToString());

            foreach (DataRow row in dt.Rows)
            {
                DateTime scheduleDate = Convert.ToDateTime(row[DbTables.tbl_Schedule.Date]);
                int dayIndex = (scheduleDate - DayStart).Days;

                float startSchedule = Convert.ToSingle(row[DbTables.tbl_Schedule.Start]);
                float endSchedule = Convert.ToSingle(row[DbTables.tbl_Schedule.End]);

                string title = row[DbTables.tbl_Schedule.Title].ToString();
                int id = Convert.ToInt32(row[DbTables.tbl_Schedule.IdSchedule]);

                MySchedule schedule = new MySchedule(id, title,scheduleDate,startSchedule, endSchedule);

                id = Convert.ToInt32(row[DbTables.tbl_Schedule.IdType]);
                Color blockColor = getColorFromScheduleType(id); //Color.FromArgb(66, 165, 245);
                AddScheduleToCell(dayIndex, blockColor, schedule);
            }
        }


        private bool IsDuplicate(MySchedule schedule)
        {
            string query = $@"
                select {DbTables.tbl_Schedule.IdSchedule} 
                from {DbTables.tbl_Schedule.Table} 
                where {DbTables.tbl_Schedule.Date} = @Date 
                    and ({DbTables.tbl_Schedule.Start} < @End and {DbTables.tbl_Schedule.End} > @Start) 
                    and {DbTables.tbl_Schedule.IdSchedule} <> @ID";

            SqlParameter[] parameters = {
                new SqlParameter("@Date", schedule.ScheduleDate),
                new SqlParameter("@Start", schedule.StartTime),
                new SqlParameter("@End", schedule.EndTime),
                new SqlParameter("@ID", schedule.IdSchedule)
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
                string query = $@"
                    insert into {DbTables.tbl_Schedule.Table} 
                        ({DbTables.tbl_Schedule.IdUser}, {DbTables.tbl_Schedule.IdType},
                        {DbTables.tbl_Schedule.Title}, {DbTables.tbl_Schedule.Date}, 
                        {DbTables.tbl_Schedule.Start}, {DbTables.tbl_Schedule.End}) 
                    output inserted.{DbTables.tbl_Schedule.IdSchedule} 
                    values (@UserId, @TypeId, @Title, @ScheduleDate, @StartTime, @EndTime);
                ";

                SqlParameter[] InsertParameters = {
                    new SqlParameter("@UserId", UserId),
                    new SqlParameter("@TypeId", schedule.IdType),
                    new SqlParameter("@Title", schedule.Title),
                    new SqlParameter("@ScheduleDate", schedule.ScheduleDate),
                    new SqlParameter("@StartTime", schedule.StartTime),
                    new SqlParameter("@EndTime", schedule.EndTime)
                };

                object result = Db.ExecuteScalar(query, InsertParameters);
                if (result != null)
                {
                    schedule.IdSchedule = Convert.ToInt32(result);

                    // cout << :)))
                    MessageBox.Show($"✅ Thêm lịch thành công! ID mới: {schedule.IdSchedule}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Color blockColor = Color.FromArgb(66, 165, 245);
                    int dayIndex = (schedule.ScheduleDate - currentWeek).Days;
                    AddScheduleToCell(dayIndex, blockColor, schedule);
                    
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

            string query = $@"
                update {DbTables.tbl_Schedule.Table} 
                set 
                    {DbTables.tbl_Schedule.IdType} = @TypeId,
                    {DbTables.tbl_Schedule.Title} = @Title,
                    {DbTables.tbl_Schedule.Date} = @Date,
                    {DbTables.tbl_Schedule.Start} = @Start,
                    {DbTables.tbl_Schedule.End} = @End
                where {DbTables.tbl_Schedule.IdSchedule} = @ScheduleId";

            SqlParameter[] parameters = {
                new SqlParameter("@ScheduleId", schedule.IdSchedule),
                new SqlParameter("@TypeId", schedule.IdType),
                new SqlParameter("@Title", schedule.Title),
                new SqlParameter("@Date", schedule.ScheduleDate.Date),
                new SqlParameter("@Start", schedule.StartTime),
                new SqlParameter("@End", schedule.EndTime)
            };

            int rowsAffected = Db.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }


        public bool DeleteSchedule(int scheduleId)
        {
            string query = $@"delete from {DbTables.tbl_Schedule.Table} where {DbTables.tbl_Schedule.IdSchedule} = @IdSchedule";

            SqlParameter[] parameters = {
                new SqlParameter("@IdSchedule", scheduleId)
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

            if(sender is UIPanel panel)
            {
                dynamic tagData = panel.Tag;
                addSchedlueForm.setData(currentWeek.AddDays(tagData.Day), tagData.Hour);
            }

            DialogResult result = addSchedlueForm.ShowDialog();

            if (result == DialogResult.OK) // Them lich
            {
                AddScheduleToDB(addSchedlueForm.getData());
                return;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_MySchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            manager.Show();
        }

        private void ScheduleBlock_MouseClick(object sender, MouseEventArgs e)
        {
            int dayIndex;
            int scheduleId;
            if(sender is UIPanel panel)
            {
                dynamic tagData = panel.Tag;
                dayIndex = tagData.Day;
                scheduleId = tagData.ScheduleId;
            }
            else if(sender is Label lbl)
            {
                dynamic tagData = lbl.Tag;
                dayIndex = tagData.Day;
                scheduleId = tagData.ScheduleId;
            }
            else
            {
                // cout
                MessageBox.Show("Có lỗi gì đó khi bấm vào lịch");
                return;
            }

            string query = $@"
                select 
                    {DbTables.tbl_Schedule.IdType},
                    {DbTables.tbl_Schedule.Title},
                    {DbTables.tbl_Schedule.Date},
                    {DbTables.tbl_Schedule.Start},
                    {DbTables.tbl_Schedule.End} 
                from {DbTables.tbl_Schedule.Table} 
                where {DbTables.tbl_Schedule.IdSchedule} = @IdSchedule";

            DataTable dt = Db.ReadTable(query, new SqlParameter[] { new SqlParameter("@IdSchedule", scheduleId) });

            if (dt.Rows.Count == 0)
            {
                // cout 
                MessageBox.Show("Không tìm thấy lịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows[0];
            MySchedule schedule = new MySchedule(
                scheduleId,
                Convert.ToInt32(row[DbTables.tbl_Schedule.IdType]),
                row[DbTables.tbl_Schedule.Title].ToString(),
                Convert.ToDateTime(row[DbTables.tbl_Schedule.Date]),
                Convert.ToSingle(row[DbTables.tbl_Schedule.Start]),
                Convert.ToSingle(row[DbTables.tbl_Schedule.End])
            );

            Form_AddMySchedule addSchedlueForm = new Form_AddMySchedule();
            addSchedlueForm.formType(Form_AddMySchedule.TYPE_EDIT);

            addSchedlueForm.setData(schedule);

            DialogResult result = addSchedlueForm.ShowDialog();

            if(result == DialogResult.Yes)
            {
                schedule = addSchedlueForm.getData();
                schedule.IdSchedule = scheduleId;
                UpdateSchedule(schedule);

                RemoveSchedule(dayIndex, scheduleId);

                Color blockColor = getColorFromScheduleType(schedule.IdType);
                dayIndex = (schedule.ScheduleDate - currentWeek).Days;
                AddScheduleToCell(dayIndex, blockColor, schedule);

                return;
            }

            if(result == DialogResult.No)
            {
                DeleteSchedule(scheduleId);
                RemoveSchedule(dayIndex, scheduleId);
            }
        }


        // ====================== Hàm xử lý logic ======================
        private void AddScheduleToCell(int dayIndex, Color blockColor, MySchedule schedule)
        {
            if (dayIndex < 0 || dayIndex >= 7) return;

            int startHour = (int)schedule.StartTime;
            int endHour = (int)schedule.EndTime;
            float startMinute = schedule.StartTime - startHour;
            float endMinute = schedule.EndTime - endHour;

            Control cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, startHour);
            UIPanel scheduleBlockFirst = new UIPanel
            {
                Name = NAME_CALENDAR_BLOCK + (schedule.IdSchedule).ToString(),
                Margin = new Padding(0),
                BackColor = blockColor,
                FillColor = blockColor,
                Tag = new { Day = dayIndex, ScheduleId = schedule.IdSchedule }
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
                Text = $"{schedule.Title}",
                Dock = DockStyle.Fill,
                ForeColor = Color.White,
                Font = TITLE_FONT,
                TextAlign = ContentAlignment.TopLeft,
                BackColor = Color.Transparent,
                Tag = new { Day = dayIndex, ScheduleId = schedule.IdSchedule }
            };
            lblTitle.MouseClick += ScheduleBlock_MouseClick;
            scheduleBlockFirst.Controls.Add(lblTitle);

            cell.Controls.Add(scheduleBlockFirst);

            for (int h = startHour + 1; h < endHour; ++h)
            {
                cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, h);
                if (cell is UIPanel panel)
                {
                    UIPanel scheduleBlock = new UIPanel
                    {
                        Name = NAME_CALENDAR_BLOCK + (schedule.IdSchedule).ToString(),
                        Location = new Point(0, 0),
                        Size = new Size(width, panel.Height + 1),
                        BackColor = blockColor,
                        FillColor = blockColor,
                        Margin = new Padding(0),
                        Tag = new { Day = dayIndex, ScheduleId = schedule.IdSchedule }
                    };

                    panel.Controls.Add(scheduleBlock);
                    panel.Margin = new Padding(BORDER, 0, 0, 0);
                    scheduleBlock.MouseClick += ScheduleBlock_MouseClick;
                    scheduleBlock.BringToFront();
                }
            }

            if(startHour < endHour)
            {
                endHour = Math.Min(endHour, HOUR - 1);
                cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, endHour);
                UIPanel scheduleBlockEnd = new UIPanel
                {
                    Name = NAME_CALENDAR_BLOCK + (schedule.IdSchedule).ToString(),
                    Location = new Point(0, 0),
                    BackColor = blockColor,
                    FillColor = blockColor,
                    Margin = new Padding(0),
                    Tag = new { Day = dayIndex, ScheduleId = schedule.IdSchedule }
                };

                height = (int)(cell.Height * endMinute);
                scheduleBlockEnd.Size = new Size(width, height);
                scheduleBlockEnd.MouseClick += ScheduleBlock_MouseClick;
                cell.Controls.Add(scheduleBlockEnd);
            }
        }

        private void RemoveSchedule(int dayIndex, int ScheduleId)
        {
            if (dayIndex < 0 || dayIndex >= 7) return;
            string name = NAME_CALENDAR_BLOCK + ScheduleId.ToString();

            for (int h=0; h<HOUR; ++h)
            {
                Control cell = tlp_mainCalendar.GetControlFromPosition(dayIndex + 1, h);
                cell.Controls.RemoveByKey(name);

                if(cell.Controls.Count == 0)
                {
                    cell.Margin = new Padding(BORDER, 0, 0, BORDER);
                }
            }
        }


// =====================================================================
// =====================================================================
    }
}
