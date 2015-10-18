using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class RightsInfo
    {
        public RightsInfo()
        {
            this.RoleRights = new List<RoleRight>();
        }

        public int RightId { get; set; }
        public string RightName { get; set; }
        public string LinkUrl { get; set; }
        public string RightDesc { get; set; }
        public Nullable<int> ParentId { get; set; }
        public virtual ICollection<RoleRight> RoleRights { get; set; }
    }
}
