using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorProject.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(double a, double b, string op = "+")
        {
            switch (op)
            {
                case "+":
                    ViewBag.KetQua = a + b; break;
                case "-":
                    ViewBag.KetQua = a - b; break;
                case "*":
                    ViewBag.KetQua = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KetQua = "Không chia được cho 0";
                    else ViewBag.KetQua = a / b;
                    break;
            }
            return View();
        }
    }
}