using Microsoft.AspNetCore.Mvc;
using SalesCommApp.Models;
using SalesCommApp.Application.DTOs;
using SalesCommApp.Infrastructure.Services;

namespace SalesCommApp.Controllers
{
    public class CommissionController : Controller
    {
        private readonly CommissionService _service;

        public CommissionController(CommissionService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CommissionModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var dto = new CommissionDTO
            {
                Sales = model.Sales,
                Discount = model.Discount,
                Country = model.Country
            };

            model.Result = _service.Calculate(dto);

            return View(model);
        }
    }
}