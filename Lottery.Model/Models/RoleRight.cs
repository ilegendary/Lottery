using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class RoleRight
    {
        public int RoleRightsId { get; set; }
        public Nullable<int> RightId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public virtual RightsInfo RightsInfo { get; set; }
        public virtual RoleInfo RoleInfo { get; set; }
    }
}
