using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class AdType
    {
        public AdType()
        {
            this.AdInfoes = new List<AdInfo>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDesc { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public int DeleteMark { get; set; }
        public virtual ICollection<AdInfo> AdInfoes { get; set; }
    }
}
