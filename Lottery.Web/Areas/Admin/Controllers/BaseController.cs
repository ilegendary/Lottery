using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Lottery.Model;

namespace Lottery.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
       //重写JsonResult，防止循环引用
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }

        public AdminInfo AdminUserInfo{get;set;}

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if(Session["AdminUserInfo"]!=null)
            {
                AdminUserInfo=(AdminInfo)Session["AdminUserInfo"];
            }
            else
            {
                filterContext.HttpContext.Response.Redirect("/Admin/Login/Index");
            }
        }
    }
}
