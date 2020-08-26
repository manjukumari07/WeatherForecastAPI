using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastAPI.Model;
using WeatherForecastAPI.Service;

namespace WeatherForecastAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly IWeatherService _weatherService;
        List<WeatherModel> newWeatherList = new List<WeatherModel>();

        public CitiesController(IWeatherService weatherService)
        {
            _weatherService = weatherService ?? throw new ArgumentNullException(nameof(weatherService));
        }

        // GET api/weather/cities
        [HttpGet()]
        public async Task<ActionResult<WeatherModel>> GetCities()
        {
            var weatherlist = await _weatherService.GetWeatherReport();
            if (weatherlist.Any())
            {
                return Ok(weatherlist);
            }
            return NotFound($"No Record");
        }


        // GET api/weather/cities/citiyID
        // GET api/weather/cities/citiyID? date = yyyy - MM - dd
        [HttpGet("{cityId}")]
        public async Task<ActionResult> GetCitiesByIdDate(int cityId, string date)
        {
            try
            {
                if (!string.IsNullOrEmpty(date))
                {
                    var weatherlistByDate = await _weatherService.GetWeatherReportByIDandDate(cityId, date);
                    if (weatherlistByDate.Any())
                    {
                        return Ok(weatherlistByDate);
                    }
                    return NotFound($"No record found for given date");
                }
                else
                {
                    var weatherlistById = await _weatherService.GetWeatherReportByCityID(cityId);
                    if (weatherlistById.Any())
                    {
                        return Ok(weatherlistById);
                    }
                    return NotFound($"No Record with given ID found");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }
        }
    }
}
