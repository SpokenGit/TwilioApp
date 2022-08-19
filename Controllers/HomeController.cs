using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using TwilioWeb.Data;
using TwilioWeb.Models;
using TwilioWeb.Models.Interfaces;
using TwilioWeb.Utilities;

namespace TwilioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyContext _context;
        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Sent"] =  _context.sentmessagess.ToList();
           
            return View();
            
        }

        public IActionResult Create(messages messages)
        {
            if (messages.message!=null || messages.to_field != null)
            {
                MessageManager manager = new MessageManager(new Sqlmessage(messages, _context));
                sentmessages msgSent = new sentmessages();
                //Inserting the informatio to the "messages" Table
                var result = manager.Insert();
                if (result.Contains("Error"))
                {
                    ViewData["msg"] = result;
                }
                else
                {
                    TwilioAPI API = new TwilioAPI();
                    //Calling the API with the phone information to be sent
                    msgSent = API.SendMessage(messages, _context);
                    //If there is no errors sending the messages then Insert to the "sentmessages" Table
                    if (msgSent != null)
                    {
                        manager = new MessageManager(new SqlSentmessage(msgSent, _context));
                        var result2 = manager.Insert();

                        ViewData["msg"] = "Message Sent Succesfully..!!!";
                    }
                    else { ViewData["msg"] = "There was an error sending the messages..!!!"; }

                }
            }
            else {

                ViewData["msg"] = "Please complete the Fields : TO and PHONE NUMBERS";
            }

           
            ViewData["Sent"] = _context.sentmessagess.ToList();
            return View("Index");
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
