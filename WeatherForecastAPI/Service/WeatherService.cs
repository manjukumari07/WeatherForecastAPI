using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastAPI.Repository;
using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Service
{
    public class WeatherService : WeatherRepository, IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository ?? throw new ArgumentNullException(nameof(weatherRepository));
        }
        public async Task<IEnumerable<WeatherModel>> GetWeatherReport()
        {
            return (await _weatherRepository.GetWeatherReport());
        }

        public async Task<IEnumerable<WeatherModel>> GetWeatherReportByCityID(int cityId)
        {
            var weatherList = await _weatherRepository.GetWeatherReport();
            return weatherList.Where(x => x.ID == cityId).ToList();
        }

        public async Task<IEnumerable<WeatherModel>> GetWeatherReportByIDandDate(int cityId, string date)
        {
            var weatherList = await _weatherRepository.GetWeatherReport();
            return (weatherList.Where(x => x.ID == cityId).Where(x => x.Date == date)).ToList();
        }
    }
}