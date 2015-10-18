using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> ParentId { get; set; }
    }
}
