using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lottery.Web.Areas.Admin.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required(ErrorMessage="角色名不能为空")]
        public string RoleName { get; set; }

        public string RoleDesc { get; set; }
    }
}