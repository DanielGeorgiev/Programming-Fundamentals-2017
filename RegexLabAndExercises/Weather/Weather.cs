using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
public class Weather
{
    public class CityWeather
    {
        public double AvgTemperature { get; set; }

        public string Weather { get; set; }
    }

    public static void Main()
    {
        var line = Console.ReadLine();
        var weatherInfo = new Dictionary<string, CityWeather>();

        while (line != "end")
        {
            var match = Regex.Match(line, @"([A-Z]{2})([0-9]+\.[0-9]+)([A-za-z]+(?=\|))");

            if (match.Value != "")
            {
                var city = match.Groups[1].Value;
                var temperature = double.Parse(match.Groups[2].Value);
                var weather = match.Groups[3].Value;

                var cityWeather = new CityWeather()
                {
                    AvgTemperature = temperature,
                    Weather = weather
                };

                weatherInfo[city] = cityWeather;
            }

            line = Console.ReadLine();
        }

        weatherInfo = weatherInfo.OrderBy(x => x.Value.AvgTemperature).ToDictionary(x => x.Key, y => y.Value);

        foreach (var city in weatherInfo)
        {
            Console.WriteLine("{0} => {1:f2} => {2}", city.Key, city.Value.AvgTemperature, city.Value.Weather);
        }
    }
}

