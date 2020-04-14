using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingApp.ApplicationLogic.DataModel;
using BookingApp.ApplicationLogic.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService contactService;
        public ContactController(ContactService contactService)
        {
            this.contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMessage([FromForm]Contact model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            this.contactService.AddMessage(model);
            return Redirect(Url.Action("Index", "Home"));
        }
        [HttpGet]
        public IActionResult ViewMessages()
        {
            var contactMessages = contactService.GetAllMessages();
            return View(contactMessages);
        }
        [HttpGet]
        public IActionResult DeleteMessage()
        {
            var messageIds = contactService.GetAllMessagesIds();
            ViewData["MessagesIds"] = messageIds;
            return View();
        }
        [HttpPost]
        public IActionResult DeleteMessage([FromForm]Contact model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            this.contactService.DeleteMessage(model.Id);
            return Redirect(Url.Action("ViewMessages", "Contact"));
        }
    }
}