using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlApp.Database.Models
{
    internal class MySchedule
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime ScheduleDate { get; set; }
        public float StartTime { get; set; }
        public float EndTime { get; set; }
        public string Description { get; set; }

        public MySchedule(string Id, string Title, DateTime ScheduleDate, float startTime, float EndTime, string Description)
        {
            this.Id = Id;
            this.Title = Title;
            this.ScheduleDate = ScheduleDate;
            this.StartTime = startTime;
            this.EndTime = EndTime;
            this.Description = Description;
        }
    }
}
