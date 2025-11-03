using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlApp.Database.Models
{
    public class MyGroup
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }

        public MyGroup(int GroupId, string GroupName, string Description)
        {
            this.GroupId = GroupId;
            this.GroupName = GroupName;
            this.Description = Description;
        }
    }
}
