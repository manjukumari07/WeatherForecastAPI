using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Service
{
    public interface IWeatherService
    {
        List<WeatherModel> GetWeatherReport();
        List<WeatherModel> GetWeatherReportByCityID(int cityId);
        List<WeatherModel> GetWeatherReportByIDandDate(int cityId, string date);
    }
}
