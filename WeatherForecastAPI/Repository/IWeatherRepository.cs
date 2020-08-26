using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastAPI.Model;
namespace WeatherForecastAPI.Repository
{
    public interface IWeatherRepository
    {
        Task<IEnumerable<WeatherModel>> GetWeatherReport();
    }
}
