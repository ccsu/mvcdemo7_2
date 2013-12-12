using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDemo7_2.Models;

namespace MvcDemo7_2.Controllers
{
    public class Test2Controller : Controller
    {

        //
        // GET: /Test2/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View(GetData());
        }

        [HttpPost]
        public ActionResult Single(List<SingleQ> qList)
        {
            //if (f["[0].id"] == "A")
            //    ViewBag.Ans = "OK";
            //else
            //    ViewBag.Ans = "NO";

            //ViewBag.Ans = qList[0].SelectedAns.ToString() + ", ___  " + qList[1].SelectedAns.ToString();

            if (qList[0].SelectedAns == "A")
                ViewBag.Ans1 = "第一題 答對";
            else
                ViewBag.Ans1 = "第一題 答錯";

            if (qList[1].SelectedAns == "C")
                ViewBag.Ans2 = "第二題 答對";
            else
                ViewBag.Ans2 = "第二題 答錯";

            return View(GetData());
        }

        public List<SingleQ> GetData()
        {
            List<SingleQ> qList = new List<SingleQ>();

            SingleQ s1 = new SingleQ();
            s1.Id = 33;
            s1.Question = "太陽由哪邊出現?";
            s1.A = "東邊";
            s1.B = "西邊";
            s1.C = "南邊";
            s1.D = "北邊";
            s1.Ans = "A";
            s1.SelectedAns = "";          
            qList.Add(s1);

            s1 = new SingleQ();
            s1.Id = 66;
            s1.Question = "那位是南台現任校長?";
            s1.A = "馬英九";
            s1.B = "陳水扁";
            s1.C = "戴謙";
            s1.D = "賴清德";
            s1.Ans = "C";
            s1.SelectedAns = "";      
            qList.Add(s1);

            return qList;
        }

        public List<MultipleQ> GetMultipleData()
        {
            List<MultipleQ> qList = new List<MultipleQ>();

            MultipleQ s1 = new MultipleQ();
            s1.Id = 33;
            s1.Question = "太陽由哪邊出現?";
            s1.A = "東邊";
            s1.B = "西邊";
            s1.C = "南邊";
            s1.D = "北邊";
            s1.Ans = "A";
            s1.SelectedAns1 = true;
            s1.SelectedAns2 = false ;
            s1.SelectedAns3 = false;
            s1.SelectedAns4 = false;
            qList.Add(s1);

            s1 = new MultipleQ();
            s1.Id = 66;
            s1.Question = "那位是南台現任校長?";
            s1.A = "馬英九";
            s1.B = "陳水扁";
            s1.C = "戴謙";
            s1.D = "賴清德";
            s1.Ans = "C";
            s1.SelectedAns1 = false;
            s1.SelectedAns2 = true;
            s1.SelectedAns3 = false;
            s1.SelectedAns4 = false;
            qList.Add(s1);

            return qList;
        }

        public ActionResult Multiple()
        {
            return View(GetMultipleData());
        }

        [HttpPost]
        public ActionResult Multiple(List<MultipleQ> qList)
        {
            string s = qList[0].SelectedAns1.ToString() + ", " + qList[0].SelectedAns2.ToString() + ", " +
                   qList[0].SelectedAns3.ToString() + ", " +  qList[0].SelectedAns4.ToString();

            ViewBag.Ans = s;

            return View(GetMultipleData());
        }
    }

}

