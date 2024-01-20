using IBusiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;

namespace MVCApplication.Controllers
{
    public class UserController : Controller
    {
        CommonUI cm = new CommonUI();
        BAUserMaster objUserM = new BAUserMaster();
        UserMaster userM = new UserMaster();

        [HttpGet]
        public ActionResult UserMaster()
        {
            try
            {
                if (Convert.ToString(Session["UserId"]) == "" || Session["UserId"] == null)
                {
                    return View("~/Views/Home/Index.cshtml");
                }
                else
                {

                    //DataTable dt = new DataTable();
                    var table = new MenuAndUserMLst
                    {
                        dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),
                        dtUserM = objUserM.GetUserMaster()

                    };
                    //dt = objUserM.GetUserMaster();
                    return View(table);
                }


            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        //public ActionResult AddUser()
        //{
        //    try
        //    {
        //        if (Convert.ToString(Session["UserId"]) == "" || Session["UserId"] == null)
        //        {
        //            return View("~/Views/Home/Index.cshtml");
        //        }
        //        else
        //        {
        //            var table = new MenuAndUserMLst
        //            {
        //                dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),
        //                //dtUserM = objUserM.GetUserMaster()
        //                UM = userM.;

        //            };
        //            return View(table);
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;

        //   }
        //}
    }
}