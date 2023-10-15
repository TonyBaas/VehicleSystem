using Microsoft.AspNetCore.Mvc;
using VehicleSystem.Models;

namespace VehicleSystem.Controllers
{
    public class VehicleController : Controller
    {
        private VehiclesOnLot onLot { get; set; }
        public VehicleController(VehiclesOnLot ctx)
        {
            onLot = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add"; 
            return View("Edit", new Vehicle());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit"; 
            var vehicle = onLot.Vehicles.Find(id); 
            return View(vehicle);
        }
        [HttpPost]
        public IActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                if (vehicle.VehicleId == 0) 
                    onLot.Vehicles.Add(vehicle);
                else
                    onLot.Vehicles.Update(vehicle); 
                    onLot.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (vehicle.VehicleId == 0) ? "Add" : "Edit"; 
                return View(vehicle);
            }
        }
    }
}
