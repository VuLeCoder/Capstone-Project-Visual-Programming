using Guna.UI2.WinForms.Suite;
using Syncfusion.Reflection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlApp.Database
{
    internal class DbTables
    {
        public static class tbl_TimeSLot
        {
            public const string Table = "tbl_TimeSlot";
            public const string TimeStr = "TimeStr";
            public const string TimeVal = "TimeVal";
        }

        public static class tbl_User 
        {
            public const string Table = "tbl_User"; 
            public const string Id = "UserId"; 
            public const string Name = "UserName"; 
            public const string Email = "Email"; 
            public const string Password = "PasswordHash"; 
        }

        public static class tbl_ScheduleType
        {
            public const string Table = "tbl_ScheduleType";
            public const string Id = "TypeId";
            public const string Name = "TypeName";
            public const string Description = "Description";
            public const string ColorCode = "ColorCode";
        }

        public static class tbl_Schedule
        {
            public const string Table = "tbl_Schedule";
            public const string IdUser = "UserId";
            public const string IdSchedule = "ScheduleId";
            public const string Title = "Title";
            public const string IdGroup = "GroupId";
            public const string IdType = "TypeId";
            public const string Date = "ScheduleDate";
            public const string Start = "StartTime";
            public const string End = "EndTime";
        }

        public static class tbl_Group
        {
            public const string Table = "tbl_Group";
            public const string Id = "GroupId";
            public const string GroupName = "GroupName";
            public const string Description = "Description";
            public const string CreatedBy = "CreatedBy";
        }

        public static class tbl_GroupMember
        {
            public const string Table = "tbl_GroupMember";
            public const string GroupId = "GroupId";
            public const string UserId = "UserId";
            public const string Role = "Role";
            public const string JoinedAt = "JoinedAt";
        }
    }
}
