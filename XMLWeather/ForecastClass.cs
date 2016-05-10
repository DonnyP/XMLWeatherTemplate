using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    class ForecastClass
    {
        public string rain, high, low, windDirection, windSpeed, date;

        public ForecastClass(string _rain, string _high, string _low, string _windDirection, string _windSpeed, string _date)
        {
            rain = _rain;
            high = _high;
            low = _low;
            windDirection = _windDirection;
            windSpeed = _windSpeed;
            date = _date;
        }

    }
}
