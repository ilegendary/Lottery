using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lottery.Model;
using Lottery.BLL;
using Lottery.IBLL;
using Lottery.Web.Areas.Admin.Models;

namespace Lottery.Web.Areas.Admin.Controllers
{
    public class AdminUserInfoController : BaseController
    {
        IAdminInfoService AdminService = new AdminInfoService();
        IRoleInfoService RoleService = new RoleInfoService();

        //列表页
        public ActionResult Index()
        {
            return View();
        }

        //添加管理员Get方法
        public ActionResult Add()
        {
            ViewData["RoleList"] = GenerateList();
            return View();
        }

        /// <summary>
        /// 获取角色分页数据
        /// </summary>
        /// <returns></returns>
        public JsonResult GetListByPage()
        {
            int totalCount;     //总记录数
            int startRecord = Convert.ToInt32(Request.Params["iDisplayStart"]);             //开始记录数
            int pageSize = Convert.ToInt32(Request["iDisplayLength"]);     //页面偏移量
            int pageNum = startRecord == 0 ? 1 : (startRecord / pageSize) + 1;


            List<AdminInfo> adminUserInfolist = AdminService.LoadPageEntities(pageNum, pageSize, out totalCount, x => x.AdminUserId != 0, x => x.AdminUserId, true).ToList();
            //List<AdminInfo> aaDataList=new List<AdminInfo>();
            //foreach (var item in adminUserInfolist)
            //{
            //    aaDataList.Add(item);
            //}

            return Json(new
            {
                sEcho = Request.Params["sEcho"],
                iTotalRecords = totalCount,
                iTotalDisplayRecords = totalCount,
                aaData = adminUserInfolist
            }, JsonRequestBehavior.AllowGet);
        }


        //添加管理员Post方法
        [HttpPost]
        public JsonResult Add(AdminUserInfo model)
        {
            if (ModelState.IsValid)
            {

                AdminInfo adminInfo = AdminService.AddEntity(new AdminInfo { AdminLoginName = model.AdminLoginName, Email = model.Email, RealName = model.RealName, PhoneNo = model.PhoneNo, RoleId = model.RoleId, LoginPwd = "123456" });
                if (adminInfo != null)
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

        /// <summary>
        /// 生成角色选择列表
        /// </summary>
        /// <returns></returns>
        public SelectList GenerateList()
        {
            List<SelectListItem> itemList = new List<SelectListItem>();
            List<RoleInfo> roleInfoList = RoleService.LoadEntities(x => x.DeleteMark == 0).ToList();
            if (roleInfoList != null)
            {
                foreach (RoleInfo item in roleInfoList)
                {
                    itemList.Add(new SelectListItem() { Text = item.RoleName, Value = item.RoleId.ToString() });
                }
            }
            SelectList generateList = new SelectList(itemList, "Value", "Text");
            return generateList;
        }

        #region 修改管理员信息

        //编辑Get方法
        public ActionResult Edit(int id)
        {
            AdminInfo adminInfo = AdminService.LoadEntities(x => x.AdminUserId == id).FirstOrDefault();
            AdminUserInfo viewRole = new AdminUserInfo();

            if (adminInfo != null)
            {
                viewRole.AdminUserId = adminInfo.AdminUserId;
                viewRole.AdminLoginName = adminInfo.AdminLoginName;
                viewRole.Email = adminInfo.Email;
                viewRole.PhoneNo = adminInfo.PhoneNo;
                viewRole.RealName = adminInfo.RealName;
                viewRole.RoleId = adminInfo.RoleId;

                ViewData["RoleList"] = GenerateList();

                return View("Edit", viewRole);
            }
            else
            {
                return Content("请求有误");
            }
        }

        //Post方法
        [HttpPost]
        public JsonResult Edit(AdminUserInfo model)
        {
            if (ModelState.IsValid)
            {
                if (AdminService.EditEntity(new AdminInfo { AdminUserId = model.AdminUserId, AdminLoginName = model.AdminLoginName, Email = model.Email, RealName = model.RealName, PhoneNo = model.PhoneNo, RoleId = model.RoleId, LoginPwd = "123456" }))
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

    }
}
