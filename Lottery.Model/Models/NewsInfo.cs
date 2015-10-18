using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class NewsInfo
    {
        public int NewsId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string TypeName { get; set; }
        public string NewsContent { get; set; }
        public string NewsTitle { get; set; }
        public string NewsAuthor { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public int SortNum { get; set; }
        public int DeleteMark { get; set; }
        public virtual NewsType NewsType { get; set; }
    }
}
