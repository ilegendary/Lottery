using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class AdminUserRight
    {
        public int RightId { get; set; }
        public string RightName { get; set; }
        public string LinkUrl { get; set; }
        public Nullable<int> AdminUserId { get; set; }
        public string AdminUserName { get; set; }
        public virtual AdminInfo AdminInfo { get; set; }
    }
}
