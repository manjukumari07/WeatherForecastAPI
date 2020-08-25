using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastAPI.Model
{
    public class WeatherModel
    {
        public string Date { get; set; }

        public int ID { get; set; }

        public string City { get; set; }

        public string Location { get; set; }

        public int Temperature { get; set; }

        public string Summary { get; set; }
    }
}