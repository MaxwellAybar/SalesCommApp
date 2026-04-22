using Microsoft.AspNetCore.Mvc;
using SalesCommApp.Models;
using SalesCommApp.Services;

namespace SalesCommApp.Controllers
{
    public class CommissionController : Controller
    {
        private readonly CommissionService _service = new CommissionService();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CommissionModel model)
        {
            model.Result = _service.Calculate(model.Country, model.Sales, model.Discount);
            return View(model);
        }
    }
}