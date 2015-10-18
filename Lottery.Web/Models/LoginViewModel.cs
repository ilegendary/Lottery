using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lottery.Web.Models
{
    /// <summary>
    /// 登录视图模型
    /// </summary>
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string LoginPwd { get; set; }
        public string Code { get; set; }
        public bool RemberMe { get; set; }

    }
}