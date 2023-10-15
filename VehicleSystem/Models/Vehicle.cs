﻿using System.ComponentModel.DataAnnotations;

namespace VehicleSystem.Models
{
    public class Vehicle
    {
        [Key] public int VehicleId { get; set; }

        [Required(ErrorMessage = "Year")][Range(1885, 2024, ErrorMessage = "Year must be between 1885 and 2024")] 
        public int? Year { get; set; }

        [Required(ErrorMessage = "Make")] 
        public string Make { get; set; }

        [Required(ErrorMessage = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Trim")] 
        public string Trim { get; set; }

    }
}
