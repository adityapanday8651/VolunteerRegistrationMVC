using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerRegistrationApp.Models
{
    public class VolunteersRegistrationform
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Upload ProfilePicture")]
        public string ProfilePicture { get; set; }

        [Required(ErrorMessage = "Please enter first Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "First Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter Date-of-Birth ")]
        public string DoB { get; set; }

        [Required(ErrorMessage = "Please choose Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter Town/District")]
        [Display(Name = "Town/District")]
        public string TownOrDistrict { get; set; }

        [Required(ErrorMessage = "Please enter Area")]
        [Display(Name = "Area")]
        public string Area { get; set; }

        [Required(ErrorMessage = "Please enter Area")]
        [Display(Name = "Landmark")]
        public string Landmark { get; set; }

        [Required(ErrorMessage = "Please enter Pin code")]
        [Display(Name = "Pin Code")]
        public int Pincode { get; set; }

        [Required(ErrorMessage = "Please enter Mobile No")]
        [Display(Name = "Mobile No ")]
        public string MobileNo { get; set; }

        [Display(Name = "Alternate Mobile No")]
        public string AltMobNo { get; set; }

        [Required(ErrorMessage = "Please enter Blood Group")]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Please enter Nearest Railway Station")]
        [Display(Name = "Nearest Railway Station")]
        public string NearestRailwayStation { get; set; }

        [Required(ErrorMessage = "Please enter Nearest Airport Nearest")]
        [Display(Name = "Nearest Airport Nearest")]
        public string NearestAirportNearest { get; set; }

        [Required(ErrorMessage = "Please enter Nearest Bus Station")]
        [Display(Name = "Nearest Bus Station")]
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
