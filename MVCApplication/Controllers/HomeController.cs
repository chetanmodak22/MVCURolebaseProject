using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.Models;
using System.Data.SqlClient;
using System.Configuration;
using IBusiness;
using System.Data;
using IEntity;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr;
        // GET: Home

        CommonUI cm = new CommonUI();

        [HttpGet]
        public ViewResult Index()
        {
            if (Convert.ToString(Session["UserId"]) == "" || Session["UserId"] == null)
            {
                return View();
            }
            else
            {
                var table = new MenuAndUserMLst
                {
                    dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),

                };

                return View("WelcomeScreen", table);
            }
        }
        public ActionResult About()
        {
            if (Convert.ToString(Session["UserId"]) == "" || Session["UserId"] == null)
            {
                return View("Index");
            }
            else
            {
                var table = new MenuAndUserMLst
                {
                    dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),

                };
                return View(table);
            }

        }
        public ActionResult Forget()
        {
            return View();
        }
        public ActionResult Reset()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult ErrorPage()
        {
            if (Convert.ToString(Session["UserId"]) == "" || Session["UserId"] == null)
            {
                return View("Index");
            }
            else
            {

                return View();
            }
        }
        public ActionResult ContactUs()
        {
            if (Convert.ToString(Session["UserId"]) == "" || Session["UserId"] == null)
            {
                return View("Index");
            }
            else
            {
                var table = new MenuAndUserMLst
                {
                    dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),

                };
                return View(table);
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return View();

        }


        [HttpPost]
        public ActionResult ValidateLogin(FormCollection form, UserDetails ud)
        {
            ud.EmailId = form["Username"];
            ud.Password = form["Password"];

            Session["RoleId"] =cm.GetUserRole(ud.EmailId);
            try
            {
                //con.ConnectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
                //con.Open();
                //cmd.Connection = con;
                //cmd.CommandText = "select * from tblUserDetail where UserName='"+ud.Username+"' and UserPassword='"+ud.Password+"'";
                //dr = cmd.ExecuteReader();
                BAUserMaster objUserM = new BAUserMaster();
                DataTable dt = new DataTable();


                dt = objUserM.GetLoginDetails(ud);
                if (dt.Rows.Count > 0)
                {
                    Session["UserId"] = dt.Rows[0][0].ToString();
                    ViewBag.Username = dt.Rows[0][1].ToString();
                    var table = new MenuAndUserMLst
                    {
                        dtMenus = cm.getMenus(Convert.ToInt32(Session["RoleId"])),

                    };
                    return View("WelcomeScreen", table);
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid User Name and Password.";
                    return View("Index");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}