using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebWorld.Data;
using WebWorld.Models;
using WebWorld.Services;

namespace WebWorld.Controllers
{
    public class HomeController : Controller
    {
        private IMailService _mail;
        public IMessageBoardRepository _repo { get; set; }

        public HomeController(IMailService mail, IMessageBoardRepository repo)
        {
            _mail = mail;
            _repo = repo;
        }

        public ActionResult Index()
        {
            
            // get topics

            var topics = _repo.GeTopics()
                .OrderBy(d => d.Created)
                .Take(25)
                .ToList();

            return View(topics);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel model)
        {
            var msg = string.Format("message from : {1}{0} Email {2}{0}Website: {3}{0}Message", Environment.NewLine,
                model.Name, model.Email, model.Message);


            if (_mail.SendMail("noreply@webworld.wmw.co.uk", "johnamuesi@gmail.com", "help needed", msg))
            {
                ViewBag.MailSent = true;
            }
            
            
            return View();
        }

        public ActionResult MyMessages()
        {
            return View();
        }

        
    }
}