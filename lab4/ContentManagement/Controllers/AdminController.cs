using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContentManagement.CustomFilter;

namespace ContentManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [AuthLogAttribule(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}