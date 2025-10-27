using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace BtlApp
{
    public partial class FormMyTask : Form
    {
        public FormMyTask()
        {
            InitializeComponent();
            createCalendar();
        }

// ====================== ... ======================
        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = date.DayOfWeek - DayOfWeek.Sunday;
            if (diff < 0) diff += 7;
            return date.AddDays(-diff).Date;
        }
// =====================================================================


// ====================== ... ======================
        private readonly int WEEK = 7, HOUR = 24;
        private readonly string[] DAY_NAMES = { "CN", "TH 2", "TH 3", "TH 4", "TH 5", "TH 6", "TH 7" };
        private readonly int TIMELIME_WIDTH = 40, TASK_CELL_HEIGHT = 60, BORDER = 2;
        private void createHeaderCalendar()
        {
            tlp_mainCalendarHeader.ColumnCount = DAY_NAMES.Length + 1;
            tlp_mainCalendarHeader.Controls.Clear();
            tlp_mainCalendarHeader.ColumnStyles.Clear();

            tlp_mainCalendarHeader.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            tlp_mainCalendarHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, TIMELIME_WIDTH));
            for (int i = 0; i < WEEK; ++i)
            {
                tlp_mainCalendarHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100/WEEK));
            }

            DateTime currentWeekStart = GetStartOfWeek(DateTime.Now);
            DateTime date;

            Label noneLabel = new Label
            {
                Margin = new Padding(0),
                Dock = DockStyle.Fill,
                BackColor = Color.Gray
            };
            tlp_mainCalendarHeader.Controls.Add(noneLabel);

            for (int i=0; i<WEEK; ++i)
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

                    BackColor = Color.Gray,
                    //Color.FromArgb(144, 202, 249) : Color.Gray,

                    ForeColor = date.Date == DateTime.Now.Date ? Color.FromArgb(144, 202, 249) : Color.White
                };
                tlp_mainCalendarHeader.Controls.Add(dayLabel, i + 1, 0);
            }
        }

        private void createTimeSlotCalendar()
        {
            int hour;
            for(int h=0; h<HOUR; ++h)
            {
                hour = (h == 12) ? h : h % 12;
                Label timeLabel = new Label
                {
                    Text = $"{hour} AM".Replace("AM", h >= 12 ? "PM" : "AM"),
                    Dock = DockStyle.Fill,
                    Font = new Font("Microsoft Sans Serif", 8F,FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Margin = new Padding(0, 0, 0, BORDER),
                    BackColor = Color.Gray,
                    ForeColor = Color.White,
                };
                tlp_mainCalendar.Controls.Add(timeLabel, 0, h);

                for(int d=0; d<WEEK; ++d)
                {
                    UIPanel panel = new UIPanel
                    {
                        Dock = DockStyle.Fill,
                        FillColor = Color.Gray,
                        RectColor = Color.Gray,
                        Radius = 0,
                        Margin = new Padding(BORDER, 0, 0, BORDER),
                        Tag = new { Day = d, Hour = hour }
                    };
                    //panel.MouseClick += Panel_MouseClick;
                    tlp_mainCalendar.Controls.Add(panel, d + 1, h);
                }
            }
        }

        private void createCalendar()
        {
            createHeaderCalendar();

            tlp_mainCalendar.ColumnCount = WEEK + 1;
            tlp_mainCalendar.RowCount = HOUR;

            tlp_mainCalendar.Controls.Clear();
            tlp_mainCalendar.ColumnStyles.Clear();
            tlp_mainCalendar.RowStyles.Clear();

            tlp_mainCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, TIMELIME_WIDTH));
            for(int i=0; i<WEEK; ++i)
            {
                tlp_mainCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100/WEEK));
            }

            for(int i=0; i<HOUR; ++i)
            {
                tlp_mainCalendar.RowStyles.Add(new RowStyle(SizeType.Absolute, TASK_CELL_HEIGHT));
            }

            createTimeSlotCalendar();
        }
// =====================================================================
    }
}
