using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VolunteerRegistrationApp.Models;
using VolunteerRegistrationApp.ModelViewVolunteer;
using static System.Net.Mime.MediaTypeNames;

namespace VolunteerRegistrationApp.Controllers
{
    public class VolunteersRegistrationController : Controller
    {
        private readonly ILogger<VolunteersRegistrationController> _logger;

        private readonly VolunteersContext volunteersContext;
        private readonly IWebHostEnvironment webHostEnvironment;
        public VolunteersRegistrationController(ILogger<VolunteersRegistrationController> logger,VolunteersContext _volunteersContext, IWebHostEnvironment _webHostEnvironment)
        {
            _logger = logger;
            volunteersContext = _volunteersContext;
            webHostEnvironment = _webHostEnvironment;
        }


        public IActionResult Index()
        {

            // ViewBag.volunteerRegistrations = volunteersContext.VolunteersRegistrationform.ToList();
            // return View();
            var items = volunteersContext.VolunteersRegistrationform.ToList();
            return View(items);
        }

        [HttpPost]
        public IActionResult Test(VolunteersRegistrationform volunteersRegistrationform)
        {
            if (ModelState.IsValid)
            {
                volunteersContext.VolunteersRegistrationform.Add(volunteersRegistrationform);
                volunteersContext.SaveChanges();
                return RedirectToAction("News");
            }
            return View();     
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VolunteersRegistrationformViewModel vm)
        {
            string stringFileName = UploadFile(vm);
            var volunteersRegistrationform = new VolunteersRegistrationform
            {
                ProfilePicture = stringFileName,
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                DoB = vm.DoB,
                Gender = vm.Gender,
                State = vm.State,
                City = vm.City,
                TownOrDistrict = vm.TownOrDistrict,
                Area = vm.Area,
                Landmark = vm.Landmark,
                Pincode = vm.Pincode,
                MobileNo = vm.MobileNo,
                AltMobNo = vm.AltMobNo,
                BloodGroup = vm.BloodGroup,
                NearestRailwayStation = vm.NearestRailwayStation,
                NearestAirportNearest = vm.NearestAirportNearest,
                NearestBusStation = vm.NearestBusStation,
                RouteCoordinator = vm.RouteCoordinator,
                GochriSeva = vm.GochriSeva,
                ViharSeva = vm.ViharSeva,
                Other = vm.Other,
                AnySocialGroup = vm.AnySocialGroup,
                NameOfOrganization = vm.NameOfOrganization,
                Position = vm.Position,
                AadharCard = vm.AadharCard,
            };
            volunteersContext.VolunteersRegistrationform.Add(volunteersRegistrationform);
            volunteersContext.SaveChanges();

            return RedirectToAction("Index");
        }

        private string UploadFile(VolunteersRegistrationformViewModel vm)
        {
            string fileName = null;
            if (vm.ProfilePicture != null)
            {
                string uploadDir = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + vm.ProfilePicture.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    vm.ProfilePicture.CopyTo(fileStream);
                }
            }
            return fileName;

        }
    }
       
}
