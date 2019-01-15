using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using africaconnect.Models;
using Microsoft.AspNetCore.Hosting.Internal;

namespace africaconnect.Controllers
{
    [Route("Home")]
    [Route("")]
    public class HomeController : Controller
    {
        HostingEnvironment host;
        public HomeController(HostingEnvironment e)
        {
            host = e;
        }


        [Route("Home")]
        [Route("")]
        public IActionResult Home()
        {
            ViewBag.title = "Home";
            return View();
        }

        [Route("Gallery")]
        public IActionResult Gallery()
        {
            ViewBag.title = "Gallery";
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewBag.title = "About";
            return View();
        }

        [Route("Vehicles")]
        public IActionResult Vehicles()
        {
            ViewBag.title = "Vehicles";
            return View();
        }

        [Route("Services")]
        public IActionResult Services()
        {
            ViewBag.title = "Services";
            return View();
        }

        [Route("Cars")]
        public IActionResult Cars()
        {
            ViewBag.title = "Cars";
            return View();
        }

        [Route("Accomodation")]
        public IActionResult Accomodation()
        {
            ViewBag.title = "Accomodation";
            return View();
        }




        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewBag.title = "Contact";
            return View();
        }


        [Route("Test")]
        public string test()
        {
            var s = "";
            for (var i = 1; i < 71; i += 4)
            {

                s += "<li data-src='~/gall/gal" + (i + 0) + ".png'><a href='~/gall/gal" + (i + 0) + ".png'><img src='~/gall/gal" + (i + 0) + ".png' alt='' title='' /></a></li>\n";
                s += "<li data-src='~/gall/gal" + (i + 1) + ".png'><a href='~/gall/gal" + (i + 1) + ".png'><img src='~/gall/gal" + (i + 1) + ".png' alt='' title='' /></a></li>\n";
                s += "<li data-src='~/gall/gal" + (i + 2) + ".png'><a href='~/gall/gal" + (i + 2) + ".png'><img src='~/gall/gal" + (i + 2) + ".png' alt='' title='' /></a></li>\n";
                s += "<li data-src='~/gall/gal" + (i + 3) + ".png'><a href='~/gall/gal" + (i + 3) + ".png'><img src='~/gall/gal" + (i + 3) + ".png' alt='' title='' /></a></li>\n";
                // s += "<div class='clear'></div>\n";
            }
            return s;
        }


        [Route("CampingTrips")]
        public IActionResult CampingTrips()
        {
            ViewBag.title = "CampingTrips";
            return View();
        }

        [Route("LifeOnTheRoad")]
        public IActionResult LifeOnTheRoad()
        {
            ViewBag.title = "Life On The Road";
            return View();
        }

        [Route("Food")]
        public IActionResult Food()
        {
            ViewBag.title = "Food";
            return View();
        }

        [Route("Accommodated")]
        public IActionResult Accommodated()
        {
            ViewBag.title = "Accommodated";
            return View();
        }

        [Route("Camping")]
        public IActionResult Camping()
        {
            ViewBag.title = "Camping";
            return View();
        }

        [Route("SmallGroupTours")]
        public IActionResult SmallGroupTours()
        {
            ViewBag.title = "Small Group Tours";
            return View();
        }

        [Route("DayTours")]
        public IActionResult DayTours()
        {
            ViewBag.title = "Day Tours";
            return View();
        }

        [Route("ServicesPreAndPostTourAccomodation")]
        public IActionResult ServicesPreAndPostTourAccomodation()
        {
            ViewBag.title = "Pre And Post Tour Accomodation";
            return View();
        }

        [Route("ServicesAirportTransfers")]
        public IActionResult ServicesAirportTransfers()
        {
            ViewBag.title = "Airport Transfers";
            return View();
        }


        [Route("TouristAttractions")]
        public IActionResult TouristArractions()
        {
            ViewBag.title = "Tourist Attractions";
            return View();
        }

        [Route("VirtualTours")]
        public IActionResult VirtualTours()
        {
            ViewBag.title = "Virtual Tours";
            return View();
        }

        [HttpGet("SubscribeEmail")]
        public IActionResult SubscribeEmail()
        {
            return RedirectToAction("Home", "Home");
        }
        [HttpPost("SubscribeEmail")]
        public IActionResult SubscribeEmail(string email)
        {
            var email_ = new globals.emailMessage();
            email_.to = globals.adminEmail;
            email_.subject = "Africa connect Subscription";
            email_.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/message.html");
            email_.message = email_.message.Replace("{{message}}", "I would like to subscribe my email: " + email + " to recieve news, updates, and special offers for Africa connect travel and tours");
            Task.Run(() =>
            {
                globals.sendEmail(email_);//send email async
            });
            ViewBag.title = "Thank you";

            return View();

        }

        [HttpGet("ClientEnquiry")]
        public IActionResult ClientEnquiry()
        {
            return RedirectToAction("Home","Home");
        }

        [HttpPost("ClientEnquiry")]
        public IActionResult ClientEnquiry(clientEnq enq)
        {
            var email = new globals.emailMessage();
            email.message = System.IO.File.ReadAllText(host.WebRootPath + "/emialViews/message.html");
            email.subject = "Africa connect client Enquiry";
            var message = "name: " + enq.firstname + " " + enq.lastname + " mobile: " + enq.phone + " email: " + enq.email + " message: " + enq.message;
            email.message = email.message.Replace("{{message}}",message);
            email.to = globals.adminEmail;
            Task.Run(()=> {
                globals.sendEmail(email);
            });
            ViewBag.title = "Enquiry";
            return View();
        }
        public class clientEnq
        {
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string message { get; set; }
        }


        [Route("UpdateBrowser")]
        public IActionResult UpdateBrowser()
        {
            return View();
        }



    }
}
