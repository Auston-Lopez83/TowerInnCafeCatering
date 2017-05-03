using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TowerInnCafeCatering.Models;

namespace TowerInnCafeCatering.Controllers
{
    public class PackageDealController : Controller
    {
        private IPackageDealRepository repository;
        public PackageDealController(IPackageDealRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.PackageDeals);
    }

    //public IActionResult PackageDeals()
    //{
    //    return View();
    //}
    //public IActionResult TakeOutTrays()
    //{
    //    return View();
    //}
    //public IActionResult CreateYourOwnCatering()
    //{
    //    return View();
    //}




}
