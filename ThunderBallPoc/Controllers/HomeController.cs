using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client.Document;
using ThunderBallPoc.Models;

namespace ThunderBallPoc.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

			//todo: move into global.asax.cs
			List<Meeting> meetings;
			using (var documentStore = new DocumentStore(){ConnectionStringName = "RavenDB"})
			{
				using (var session = documentStore.OpenSession())
				{
					meetings = session.Load<Models.Meeting>().ToList();
				}
			}

			return View(meetings);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[Authorize]
		public ActionResult AddMeeting()
		{
			ViewBag.Message = "Add a New Meeting";

			return View();
		}
	}
}
