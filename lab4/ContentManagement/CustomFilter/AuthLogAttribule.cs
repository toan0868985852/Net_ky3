using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ContentManagement.CustomFilter
{
    public class AuthLogAttribule : AuthorizeAttribute
    {
        public AuthLogAttribule()
        {
           View = "AuthorizeAttribute Failed";
        }

        public string View { get; set; }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            IsUserAuthorized(filterContext);
        }

        private void IsUserAuthorized(AuthorizationContext filterContext)
        {
            if (filterContext.Result == null)
                return;
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var vr = new ViewResult();
                vr.ViewName = View;

                ViewDataDictionary dict = new ViewDataDictionary();
                dict.Add("Message", "Sorry you are not authorized to view this page");

                vr.ViewData = dict;
                var result = vr;
                filterContext.Result = result;
            }
        }
    }
}