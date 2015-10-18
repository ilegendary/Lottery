using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class NavInfo
    {
        public int NavInfoId { get; set; }
        public string NavName { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<int> Type { get; set; }
        public string LinkUrl { get; set; }
        public Nullable<int> SortNum { get; set; }
        public Nullable<bool> IsNav { get; set; }
        public Nullable<int> DeleteStates { get; set; }
    }
}
