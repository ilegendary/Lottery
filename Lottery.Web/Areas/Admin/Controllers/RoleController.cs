using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lottery.Web.Areas.Admin.Models;
using Lottery.Model;
using Lottery.BLL;
using Lottery.IBLL;

namespace Lottery.Web.Areas.Admin.Controllers
{
    public class RoleController : BaseController
    {


        IRoleInfoService RoleService = new RoleInfoService();
        public ActionResult Index()
        {
            int totalCount=0;
            List<RoleInfo> RoleList = RoleService.LoadPageEntities(1, 10,out totalCount,x=>x.RoleId!=0,x=>x.RoleId,true).ToList();
            return View(RoleList);
        }


        /// <summary>
        /// 获取角色分页数据
        /// </summary>
        /// <returns></returns>
        public JsonResult GetRoleInfoByPage()
        {
            int totalCount;     //总记录数
            int startRecord = Convert.ToInt32(Request.Params["iDisplayStart"]);             //开始记录数
            int pageSize = Convert.ToInt32(Request["iDisplayLength"]);     //页面偏移量
            int pageNum = startRecord == 0 ? 1 : (startRecord / pageSize)+1;


             List<RoleInfo> roleinfolist= RoleService.LoadPageEntities(pageNum,pageSize,out totalCount,x=>x.RoleId!=0,x=>x.RoleId,true).ToList();
            return Json(new
            {
                sEcho = Request.Params["sEcho"],
                iTotalRecords = totalCount,
                iTotalDisplayRecords = totalCount,
                aaData = roleinfolist
            }, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 添加角色表单
        /// </summary>
        /// <returns></returns>
        public ActionResult AddRole()
        {
            return View("RoleForm");
        }

        [HttpPost]
        public JsonResult AddRole(Role model)
        {
            if (ModelState.IsValid)
            {
                RoleInfo roleinfo = RoleService.AddEntity(new RoleInfo { RoleName = model.RoleName, RoleDesc = model.RoleDesc });
                if (roleinfo != null)
                {
                    return Json(new { succeed = "1", msg = "操作成功" });
                }
                else
                {
                    return Json(new { succeed = "-1", msg = "操作失败" });
                }
            }
            else
            {
                return Json(new { succeed = -2, msg = "角色名不能为空" });
            }
        }

        #region 修改角色

        public ActionResult Edit(int id)
        {
            RoleInfo roleinfo=RoleService.LoadEntities(x=>x.RoleId==id).FirstOrDefault();
            Role viewRole = new Role();

            if(roleinfo!=null)
            {
                viewRole.RoleId = roleinfo.RoleId;
                viewRole.RoleName = roleinfo.RoleName;
                viewRole.RoleDesc = roleinfo.RoleDesc;

                return View("Edit",viewRole);
            }
            else
            {
                return Content("请求有误");
            }
        }


        [HttpPost]
        public JsonResult Edit(Role model)
        {
            if (ModelState.IsValid)
            {
                if (RoleService.EditEntity(new RoleInfo { RoleId = model.RoleId, RoleDesc = model.RoleDesc, RoleName = model.RoleName }))
                {
                    return Json(new { succeed = 1, msg = "修改成功" });
                }
                else
                {
                    return Json(new { succeed = -2, msg = "修改失败" });
                }
            }
            else
            {
                return Json(new { succeed = -2, msg = "角色名不能为空" });
            }
        }

        #endregion

        [HttpPost]
        public JsonResult Delete(int id)
        {
            if (id != 0)
            {
                RoleInfo role = RoleService.LoadEntities(x=>x.RoleId==id).FirstOrDefault();
                if (role != null)
                {
                    if (RoleService.DeleteEntity(role))
                    {
                        return Json(new { succeed = "1", msg = "删除成功" });
                    }
                    else
                    {
                        return Json(new { succeed = "-1", msg = "删除失败" });
                    }
                }
                else
                {
                    return Json(new { succeed = "-2", msg = "删除失败" });
                }
            }
            else
            {
                return Json(new { succeed = "-3", msg = "请求有误" });
            }
        }

    }
}
