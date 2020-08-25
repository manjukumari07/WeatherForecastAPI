using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Repository
{
    public interface IWeatherRepository
    {
        List<WeatherModel> GetWeatherReport();
    }

    public class WeatherRepository : IWeatherRepository
    {
        public List<WeatherModel> GetWeatherReport()
        {
            List<WeatherModel> items = new List<WeatherModel>()
        {
            new WeatherModel()
            {
                Date=String.Format("{0:yyyy-MM-dd}", new DateTime(2020,3, 10)),
                ID=1,
                City="Stockholm",
                Location="59.332204, 18.065390",
                Temperature= 27,
                Summary= "sunny"
            },
            new WeatherModel()
            {
                Date=String.Format("{0:yyyy-MM-dd}", new DateTime(2020,3, 19)),
                ID=2,
                City="Gothenburg",
                Location="57.708826, 11.974598",
                Temperature= 23,
                Summary= "windy"
            },
            new WeatherModel()
            {
                Date=String.Format("{0:yyyy-MM-dd}", new DateTime(2020,3, 21)),
                ID=3,
                City="Malmo",
                Location="51.332204, 19.065390",
                Temperature= 28,
                Summary= "sunny"
            },
             new WeatherModel()
            {
                Date=String.Format("{0:yyyy-MM-dd}", new DateTime(2020,3, 15)),
                ID =1,
                City="kiruna",
                Location="59.332204, 18.065390",
                Temperature= 27,
                Summary= "sunny"
            }
        };
            return (items);
        }
    }
}
