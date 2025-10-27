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
        private void createHeaderCalendar()
        {
            tlp_mainCalendarHeader.ColumnCount = DAY_NAMES.Length + 1;
            tlp_mainCalendarHeader.Controls.Clear();
            tlp_mainCalendarHeader.ColumnStyles.Clear();

            tlp_mainCalendarHeader.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);

            tlp_mainCalendarHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            for (int i = 0; i < WEEK; ++i)
            {
                tlp_mainCalendarHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            }

            DateTime currentWeekStart = GetStartOfWeek(DateTime.Now);
            DateTime date;
            
            for (int i=0; i<WEEK; ++i)
            {
                date = currentWeekStart.AddDays(i);
                Label dayLabel = new Label
                {
                    Text = $"{DAY_NAMES[(int)date.DayOfWeek]}\n{date:dd/MM/yyyy}",
                    Margin = new Padding(0),
                    Dock = DockStyle.Fill,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = date.Date == DateTime.Now.Date ?
                    Color.FromArgb(144, 202, 249) : Color.FromArgb(240, 240, 240),
                    ForeColor = date.Date == DateTime.Now.Date ? Color.White : Color.Black
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
                    Font = new Font("Microsoft Sans Serif", 8F),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Padding = new Padding(5),
                    BackColor = Color.FromArgb(250, 250, 250),
                    ForeColor = Color.Black
                };
                tlp_mainCalendar.Controls.Add(timeLabel, 0, h);

                for(int d=0; d<WEEK; ++d)
                {
                    UIPanel panel = new UIPanel
                    {
                        Dock = DockStyle.Fill,
                        FillColor = Color.White,
                        RectColor = Color.FromArgb(230, 230, 230),
                        Radius = 10,
                        Margin = new Padding(0),
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

            tlp_mainCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));
            for(int i=0; i<WEEK; ++i)
            {
                tlp_mainCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            }

            //tlp_mainCalendar.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            for(int i=0; i<HOUR; ++i)
            {
                tlp_mainCalendar.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }

            createTimeSlotCalendar();
        }
// =====================================================================
    }
}
