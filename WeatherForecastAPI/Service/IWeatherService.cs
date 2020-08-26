using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Service
{
    public interface IWeatherService
    {
        Task<IEnumerable<WeatherModel>> GetWeatherReport();
        Task<IEnumerable<WeatherModel>> GetWeatherReportByCityID(int cityId);
        Task<IEnumerable<WeatherModel>> GetWeatherReportByIDandDate(int cityId, string date);
    }
}
