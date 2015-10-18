using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class NewsType
    {
        public NewsType()
        {
            this.NewsInfoes = new List<NewsInfo>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public int DeleteMark { get; set; }
        public virtual ICollection<NewsInfo> NewsInfoes { get; set; }
    }
}
