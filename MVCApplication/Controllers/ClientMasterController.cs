using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;
using IBusiness;

namespace MVCApplication.Controllers
{
    public class ClientMasterController : Controller
    {
        CommonUI cm = new CommonUI();
        //BAUserMaster objUserM = new BAUserMaster();
        // GET: ClientMaster
        public ActionResult ClientMaster()
        {
            var table = new MenuAndUserMLst
            {
                dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),
                //dtUserM = objUserM.GetUserMaster()

            };
            return View(table);
        }
    }
}