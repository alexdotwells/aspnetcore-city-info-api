using System;
using System.Collections.Generic;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API
{
    public class CitiesDataStore
    {   
        public List<CityDto> Cities { get; set; }
        // In memory data store
        public static CitiesDataStore Current {get;} = new CitiesDataStore();
        
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