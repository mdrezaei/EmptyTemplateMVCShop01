using EmptyMVCShop01.Models;
using EmptyMVCShop01.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMVCShop01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Pie Shop";
            var piesOfTheWeek = _pieRepository.PiesOfTheWeek;
            HomeViewModel homeViewModel = new HomeViewModel(piesOfTheWeek);
            return View(homeViewModel);
        }
    }
}
