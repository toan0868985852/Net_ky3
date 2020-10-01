using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Movie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "this is my <b> default</b> action...";
        }

        
        public string Welcome(int id)
        {
            return "<h1>nguyen huy toan";
        }


        //GET: HElloWorld/SayHello?name=toan&numTimes=10
        //query string ?
        public string SayHello(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("<h1>Hello</h1>" + name + ", NumTimes = " + numTimes);
        }

        //GET: HElloWorld/Welcome2/10?name=toan
        //route parameter & query string
        public string Welcome2(string name, int id)
        {
            return HttpUtility.HtmlEncode("<h1>Hello</h1>" + name + ", ID = " + id);
        }


        //GET: HElloWorld/SayHello2/toan/10
        //controller/action/name/id
        public string SayHello2(string name, int num)
        {
            return HttpUtility.HtmlEncode("<h1>Hello</h1>" + name + ", NumTimes = " + num);
        }
    }
}