﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FeedbackMessages.Example.AspNetCore.Mvc.Models;
using FeedbackMessages.Extensions;
using FeedbackMessages.Example.Mvc.Models;

namespace FeedbackMessages.Example.AspNetCore.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            this.InfoMessage("Information message.");
            this.SuccessMessage("Success message.");
            this.WarnMessage("Warning message.");
            this.ErrorMessage("Error message.");

            return View();
        }

        [HttpPost]
        public ActionResult Index(MessageModel model, string submitButton)
        {
            this.InfoMessage(model.Message);

            if (ModelState.IsValid)
            {
                switch (submitButton)
                {
                    case "SecondPage":
                        return RedirectToAction("SecondPage");
                    default:
                        return View();
                }
            }

            return View(model);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
