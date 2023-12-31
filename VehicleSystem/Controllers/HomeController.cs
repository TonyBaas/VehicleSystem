﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VehicleSystem.Models;

namespace VehicleSystem.Controllers
{
    public class HomeController : Controller
    {
        private VehiclesOnLot onLot { get; set; }
        public HomeController(VehiclesOnLot ctx)
        {
            onLot = ctx;
        }

        public IActionResult Index()
        {
            var vehicles = onLot.vehicles.OrderBy(m => m.Year).ToList();
            return View();
        }

    }
}