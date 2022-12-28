using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerRegistrationApp.ModelViewVolunteer
{
    public class VolunteersRegistrationformViewModel
    {
        public IFormFile ProfilePicture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DoB { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string TownOrDistrict { get; set; }
        public string Area { get; set; }
        public string Landmark { get; set; }
        public int Pincode { get; set; }
        public string MobileNo { get; set; }
        public string AltMobNo { get; set; }
        public string BloodGroup { get; set; }
        public string NearestRailwayStation { get; set; }
        public string NearestAirportNearest { get; set; }
        public string NearestBusStation { get; set; }
        public string RouteCoordinator { get; set; }
        public string GochriSeva { get; set; }
        public string ViharSeva { get; set; }
        public string Other { get; set; }
        public string AnySocialGroup { get; set; }
        public string NameOfOrganization { get; set; }
        public string Position { get; set; }
        public string AadharCard { get; set; }
    }
}
