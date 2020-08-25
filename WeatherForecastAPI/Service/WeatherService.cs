using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastAPI.Repository;
using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Service
{
    public interface IWeatherService
    {
        List<WeatherModel> GetWeatherReport();
        List<WeatherModel> GetWeatherReportByCityID(int cityId);
        List<WeatherModel> GetWeatherReportByIDandDate(int cityId, string date);
    }
    public class WeatherService : WeatherRepository, IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository ?? throw new ArgumentNullException(nameof(weatherRepository));
        }
        public List<WeatherModel> GetWeatherReport()
        {
            return (_weatherRepository.GetWeatherReport());
        }

        public List<WeatherModel> GetWeatherReportByCityID(int cityId)
        {
            var weatherList = _weatherRepository.GetWeatherReport();
            return weatherList.Where(x => x.ID == cityId).ToList();
        }

        public List<WeatherModel> GetWeatherReportByIDandDate(int cityId, string date)
        {
            var weatherList = _weatherRepository.GetWeatherReport();
            return (weatherList.Where(x => x.ID == cityId).Where(x => x.Date == date)).ToList();
        }
    }
}