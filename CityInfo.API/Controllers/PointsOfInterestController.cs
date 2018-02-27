using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CityInfo.API.Models;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityid}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityid)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityid);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityid}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int id, int cityid)
        {

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityid);

            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = CitiesDataStore.Current.Cities.FirstOrDefault(p => p.Id == id);

            if (city == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterest);
        }

    }
}