using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog3.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return Content("Admin Areas Users Controller Index Action:");
        }
            public ActionResult List()
        {
            return Content("Auth Controller List Action:");
        }
        public ActionResult Edit(int id=0)
        {
            return Content("Auth Controller Edit Action:");
        }
    }
    }