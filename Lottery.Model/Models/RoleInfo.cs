using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class RoleInfo
    {
        public RoleInfo()
        {
            //this.AdminInfoes = new List<AdminInfo>();
            this.RoleRights = new List<RoleRight>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public int DeleteMark { get; set; }
        public virtual ICollection<AdminInfo> AdminInfoes { get; set; }
        public virtual ICollection<RoleRight> RoleRights { get; set; }
    }
}
