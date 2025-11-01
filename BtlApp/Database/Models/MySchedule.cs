using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlApp.Database.Models
{
    public class MySchedule
    {
        public int IdSchedule { get; set; }
        public int IdType {  get; set; }
        public string Title { get; set; }
        public DateTime ScheduleDate { get; set; }
        public float StartTime { get; set; }
        public float EndTime { get; set; }

        public MySchedule(int IdSchedule, string Title, DateTime ScheduleDate, float startTime, float EndTime)
        {
            this.IdSchedule = IdSchedule;
            this.Title = Title;
            this.ScheduleDate = ScheduleDate;
            this.StartTime = startTime;
            this.EndTime = EndTime;
        }

        public MySchedule(int IdSchedule, int IdType, string Title, DateTime ScheduleDate, float startTime, float EndTime)
        {
            this.IdSchedule = IdSchedule;
            this.IdType = IdType;
            this.Title = Title;
            this.ScheduleDate = ScheduleDate;
            this.StartTime = startTime;
            this.EndTime = EndTime;
        }
    }
}
