using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;

namespace WeatherApp
{

    public class WeatherModel
    {
        private WeatherView view;
        private List<Weather> weatherData;

        private string selectedCity;

        public WeatherModel(WeatherView v)
        {
            view = v;

            weatherData = new List<Weather>();

            foreach (var e in Properties.Settings.Default.Cities)
            {
                AddCity(e);
            }
        }

        public async Task UpdateDataAsync()
        {
            if (weatherData.Count != 0)
            {
                Weather w = weatherData.Find(e => e.City == selectedCity);
                await Task.Run(() =>
                {
                    w.Update();
                });
                view.ShowWeather(w);
            }
        }

       

        public void AddCity(string cityName)
        {
            byte[] tempBytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(cityName);
            string asciiStr = Encoding.UTF8.GetString(tempBytes);

            Weather city = new Weather(asciiStr);
            city.Update();
            if (!weatherData.Any(c => c.City == city.City))
            {
                view.ShowWeather(city);
                weatherData.Add(city);
                view.AddCityToList(city.City);
                selectedCity = city.City;
                if (!Properties.Settings.Default.Cities.Contains(city.City))
                {
                    Properties.Settings.Default.Cities.Add(city.City);
                    Properties.Settings.Default.Save();
                }
            }

        }

        public void SelectCity(string cityName)
        {
            selectedCity = cityName;
        }

        public List<string> GetAllCitiesNames()
        {
            List<string> cityNames = new List<string>();
            foreach (var w in weatherData)
            {
                cityNames.Add(w.City);
            }
            return cityNames;
        }

        public void RemoveCity(string cityName)
        {
            Weather weatherToRemove = weatherData.Find(w => w.City == cityName);
            weatherData.Remove(weatherToRemove);
            if (Properties.Settings.Default.Cities.Contains(cityName))
            {
                Properties.Settings.Default.Cities.Remove(cityName);
                Properties.Settings.Default.Save();
            }
            view.RemoveCityFromList(cityName);
        }
    }
}
