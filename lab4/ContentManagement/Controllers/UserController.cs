using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContentManagement.CustomFilter;

namespace ContentManagement.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [AuthLogAttribule(Roles = "User")]
        public ActionResult Index()
        {
            return View();
        }
    }
}