using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoalKe_1.Models;

namespace SoalKe_1.Controllers
{
    public class KalkulatorController : Controller
    {
        [HttpGet]
        public IActionResult Kalkulator()
        {
            KalkulatorModel kal = new KalkulatorModel();
            return View();
        }

        [HttpPost]
        public IActionResult Kalkulator(KalkulatorModel kal)
        {
            return View(kal);  
        }

        //public IActionResult Operator()
        //{
        //    Operator op = new Operator();
        //    op.Nilai1
        //    return ;
        //}
    }
}