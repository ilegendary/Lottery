using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class AdminInfo
    {
        public AdminInfo()
        {
            this.AdminUserRights = new List<AdminUserRight>();
        }

        public int AdminUserId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string AdminLoginName { get; set; }
        public string LoginPwd { get; set; }
        public Nullable<int> AdminLevel { get; set; }
        public string RealName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public bool IsLocked { get; set; }
        public int DeleteMark { get; set; }
        public virtual RoleInfo RoleInfo { get; set; }
        public virtual ICollection<AdminUserRight> AdminUserRights { get; set; }
    }
}
