using Mvc5_DIContainerForUnity.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5_DIContainerForUnity.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService messageService;

        public HomeController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        // GET: Home
        public ActionResult Index()
        {
            return Content(messageService.Hello("Mickey"));
        }
    }
}