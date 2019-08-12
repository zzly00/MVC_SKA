using System;
using System.Web.Mvc;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var indexViewModel = new IndexViewModel();
            var random = new Random();
            for (var i = 0; i < 50; i++)
            {
                indexViewModel.Account.Add(new IndexViewModel.AccountModel()
                {
                    ID = i + 1,
                    Category = "支出",
                    Date = DateTime.Now,
                    Amount = random.Next(100, 1000)
                });

            }
            return View(indexViewModel);
        }

        public ActionResult _AccountList()
        {
            return PartialView();
        }
    }
}