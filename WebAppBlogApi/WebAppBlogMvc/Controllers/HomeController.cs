using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebAppBlogMvc.Models;

namespace WebAppBlogMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        [HttpGet]
        public ActionResult AdminLogin() 
        {
            return View(new AdminInfo());
        }
        [HttpPost]
        public ActionResult AdminLogin(AdminInfo sign)
        {
            if (ModelState.IsValid)
            {
                if ((sign.EmailId == "pravin@gmail.com") && (sign.Password == "pravin@12"))
                {

                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("EmployeeList", "AdminInfoes");
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(sign);

                }
            }
            else
            {
                return View(sign);
            }
        }

        [HttpGet]
        public ActionResult EmpLogin()
        {
            return View(new EmpInfo());
        }
        [HttpPost]
        public ActionResult EmpLogin(EmpInfo sign)
        {
            if (ModelState.IsValid)
            {
                if ((sign.EmailId == "aishu@gmail.com") && (sign.PassCode == 1234))
                {

                    Session["EmailId"] = Guid.NewGuid();
                    return RedirectToAction("SaveBlog", "EmpInfoes");
                }
                else
                {
                    ModelState.AddModelError("", "Either EmailId or Passcode Incorrect!!!");
                    return View(sign);

                }
            }
            else
            {
                return View(sign);
            }
        }
    }
}
