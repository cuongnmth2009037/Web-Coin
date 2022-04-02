using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCoin.Data;

namespace WebCoin.Controllers
{
    public class UserController : Controller
    {
        private WebCoinContext db = new WebCoinContext();
        // GET: User
        public ActionResult Index()
        {
            var coint = db.Coins.ToList();
            return View(coint);
        }
    }
}