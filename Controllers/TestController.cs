using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo7_2.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Single(FormCollection f)
        { 
            if (f["q1"] == "1")
            {
                ViewBag.ans1 = "第一題:太陽由東邊出現，正確答案";
            }
            else
                ViewBag.ans1 = "第一題:答案錯誤";

            if (f["q2"] == "2")
            {
                ViewBag.ans2 = "第二題: MVC 任課教師為蘇建郡，正確答案";
            }
            else
                ViewBag.ans2 = "第二題:答案錯誤";
            return View();
        }

        public ActionResult Multiple()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Multiple(FormCollection f)
        {

            if ((f["c11"].IndexOf("true") == 0) && (f["c12"].IndexOf("true") == 0) && (f["c13"].IndexOf("true") == 0) && (f["c14"].IndexOf("true") != 0))
                ViewBag.ans1 = "第一題:答案正確";
            else
                ViewBag.ans1 = "第一題:答案錯誤";

            if ((f["c21"].IndexOf("true") == 0) && (f["c22"].IndexOf("true") == 0) && (f["c23"].IndexOf("true") != 0) && (f["c24"].IndexOf("true") == 0))
                ViewBag.ans2 = "第二題:答案正確";
            else
                ViewBag.ans2 = "第二題:答案錯誤";

            return View();
        }

    }
}
