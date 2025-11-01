using System;
using System.Collections.Generic;
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

    }
}
