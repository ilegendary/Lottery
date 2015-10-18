using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lottery.Web.Areas.Admin.Models;
using Lottery.BLL;
using Lottery.IBLL;
using Lottery.Model;
using Lottery.Common;

namespace Lottery.Web.Areas.Admin.Controllers
{

    public class LoginController : Controller
    {
        IAdminInfoService AdminInfoService = new AdminInfoService();
        //
        // GET: /Admin/Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [CaptchaVerify]
        public JsonResult Index(Login model)
        {
            //返回的结果
            JsonResult result = new JsonResult();
            if (ModelState.IsValid)
            {
                AdminInfo admininfo = AdminInfoService.LoadEntities(x => x.AdminLoginName == model.AdminLoginName & x.LoginPwd == model.LoginPwd).FirstOrDefault();
                if (admininfo != null)
                {
                    //把登录信息写到Session中
                    Session["AdminUserInfo"] = admininfo;
                    result.Data = new { succeed = 1, msg = "登录成功" };
                    return result;
                }
                else
                {
                    result.Data = new { succeed = -1, msg = "用户名或密码错误" };
                    return result;
                }
            }
            else
            {
                result.Data = new { succeed = -2, msg = "信息填写有误" };
                return result;
            }
        }
    }
}
