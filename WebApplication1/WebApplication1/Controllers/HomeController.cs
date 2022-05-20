using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var s = new shuffle();
    
            var dealer1 = s.Shuffle();
            var dealer2 = s.Shuffle();
            var player1 = s.Shuffle();
            var player2 = s.Shuffle();

            ViewBag.Dealer = string.Format("{0}, {1} ", dealer1, dealer2);
            ViewBag.Player = string.Format("{0}, {1} ", player1, player2);

            int intdealer1 = s.convertToInt(dealer1);
            int intdealer2 = s.convertToInt(dealer2);
            int intPlayer1 = s.convertToInt(player1);
            int intPlayer2 = s.convertToInt(player2);

            int SumofDealer = intdealer1 + intdealer2;
            ViewBag.SumDealer = string.Format("{0}", SumofDealer);
            int SumofPlayer = intPlayer1 + intPlayer2;
            ViewBag.SumPlayer = string.Format("{0}", SumofPlayer);
            
            return View();
        }

       

        [HttpGet]
        public ActionResult HitButton()
        {
            shuffle Hit = new shuffle();
            TempData["Hit"] = "";
            //TempData["Sum"] = "";
            return View(Hit);
        }
        
        [HttpPost]
        //public ActionResult HitButton(shuffle sf)
        //{
        //    int t1 = sf.HitMethod();
        //    TempData["Hit"] =  string.Format("{0}", t1);

        //    int sum = t1;
        //    TempData["Sum"] = string.Format("{0}", sum);

        //    return RedirectToAction("Index");
        //}


        public ActionResult HitButton(shuffle sf)
        {

            TempData["Hit"] = TempData["Details"] + string.Format("{0}", sf.HitMethod());

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult StayButton(shuffle ss)
        //{
        //    TempData["Stay"] = TempData["Stay"].ToString() + "," + string.Format("{0}", ss.HitMethod());
        //    return RedirectToAction("Index");
        //}
    }
}
