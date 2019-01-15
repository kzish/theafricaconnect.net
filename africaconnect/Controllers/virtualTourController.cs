using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace africaconnect.Controllers
{
    [Route("VirtualTour")]
    public class VirtualTourController : Controller
    {
        [Route("VictoriaFallsToVictoriaFalls")]
        public IActionResult VictoriaFallsToVictoriaFalls()
        {
            ViewBag.title = "Victoria Falls to Victoria Falls";
            return View();
        }

        [Route("BestOfZimbabwe")]
        public IActionResult BestOfZimbabwe()
        {
            ViewBag.title = "Best Of Zimbabwe";
            return View();
        }


        [Route("ChokeAndOkavanmgoDelta")]
        public IActionResult ChokeAndOkavanmgoDelta()
        {
            ViewBag.title = "Choke And Okavanmgo Delta";
            return View();
        }

        [Route("ZimbabweAndZambia")]
        public IActionResult ZimbabweAndZambia()
        {
            ViewBag.title = "Zimbabwe And Zambia";
            return View();
        }

        [Route("ZImbotsNamibia")]
        public IActionResult ZImbotsNamibia()
        {
            ViewBag.title = "Zimbabwe Botswana Namibia";
            return View();
        }


        [Route("Namibia2")]
        public IActionResult Namibia2()
        {
            ViewBag.title = "Namibia2";
            return View();
        }


        [Route("BestOfZimbabweAndKrugar")]
        public IActionResult BestOfZimbabweAndKrugar()
        {
            ViewBag.title = "Best Of Zimbabwe And Krugar";
            return View();
        }


        [Route("CampingTour")]
        public IActionResult CampingTour()
        {
            ViewBag.title = "Camping Tour";
            return View();
        }






    }
}
