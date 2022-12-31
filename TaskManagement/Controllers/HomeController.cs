using BL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskManagement.Controllers
{
    public class HomeController : Controller
    {
       [Authorize]
        public ActionResult Index(string CC)
        {
            TaskBL bL = new TaskBL();
            string UserId=User.Identity.GetUserId();
            EmployeeModel Model = new EmployeeModel();
            Model=bL.CheckEmpRole(UserId);
            Session["Role"] = Model.Role;
            ViewBag.Role = Session["Role"].ToString();
            return View(Model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}