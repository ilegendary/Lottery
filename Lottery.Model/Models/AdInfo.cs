using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class AdInfo
    {
        public int AdId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string LinkUrl { get; set; }
        public string ImgUrl { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public string CreatetUserName { get; set; }
        public int SortNum { get; set; }
        public int IsDelete { get; set; }
        public virtual AdType AdType { get; set; }
    }
}
