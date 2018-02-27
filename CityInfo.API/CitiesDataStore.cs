using System;
using System.Collections.Generic;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current {get;} = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Cincy",
                    Description = "goes here."         
                }
            };
        }
    }
}