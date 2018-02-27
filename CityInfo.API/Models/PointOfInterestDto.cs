using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Models
{
    public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}