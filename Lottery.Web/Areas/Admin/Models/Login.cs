using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lottery.Web.Areas.Admin.Models
{
    public class Login
    {
        [Required(ErrorMessage="登录名不能为空")]
        public string AdminLoginName { get; set; }

       [Required(ErrorMessage="密码不能为空")]
        public string LoginPwd { get; set; }

       [Required(ErrorMessage="验证码不能为空")]
       public string Captcha { get; set; }
    }
}