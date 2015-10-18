using Lottery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lottery.Web.Areas.Admin.Models
{
    public class AdminUserInfo
    {
        [Required(ErrorMessage="登录名不能为空")]
        public int AdminUserId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string AdminLoginName { get; set; }
        public string RealName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public bool IsLocked { get; set; }
        public int DeleteMark { get; set; }
        public virtual RoleInfo RoleInfo { get; set; }
    }
}