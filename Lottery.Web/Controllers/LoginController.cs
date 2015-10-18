using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lottery.Web.Models;
using Lottery.IBLL;
using Lottery.BLL;
using Lottery.Common;



namespace Lottery.Web.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        IUserInfoService userservice = new UserInfoService();        //此处可以使用IOC容器进行解耦，从而使表现层只依赖于IBLL层和IOC容器
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            //如果模型通过验证
            if (ModelState.IsValid)
            {
                return Content("");
                //if (userservice.Login(model.UserName, model.LoginPwd, ""))
                //{
                //    return Content("登录成功!");
                //}
                //else
                //{
                //    return Content("账号或密码错误！");
                //}
            }
            else
            {
                return Content("账号或密码输入有误！");
            }
        }

    }
}
