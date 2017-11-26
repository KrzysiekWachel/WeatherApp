using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WeatherApp.Model
{
    public class Weather
    {
        private XmlDocument xmlDocument;


        public string City { get; private set; }
        public string Country { get; private set; }
        public string Lon { get; private set; }
        public string Lat { get; private set; }
        public string SunRise { get; private set; }
        public string SunSet { get; private set; }
        public double Temperature { get; private set; }
        public double MinTemperature { get; private set; }
        public double MaxTemperature { get; private set; }
        public double Humidity { get; private set; }
        public string HumidityUnit { get; private set; }
        public double Pressure { get; private set; }
        public string PressureUnit { get; private set; }
        public string WindSpeed { get; private set; }
        public string WindName { get; private set; }
        public double WindDirection { get; private set; }
        public double Clouds { get; private set; }
        public string CloudsName { get; private set; }
        public string Precipitation { get; private set; }
        public double WeatherNumber { get; private set; }
        public string WeatherValue { get; private set; }
        public string LastUpdate { get; private set; }

        public bool Updated { get; private set; }
        public string WeatherIcon { get; private set; }
        public string IconPath { get; private set; } 

        public Weather(string city)
        {
            City = city;
        }

        public void Update()
        {
            string CurrentURL = @"http://api.openweathermap.org/data/2.5/weather?q=" +
                City +
                @"&mode=xml&units=metric&lang=en&APPID=d31bac13a858173f8aadc25a790de4d2";
            try
            {
                using (WebClient client = new WebClient())
                {
                    var data = client.DownloadData(CurrentURL);
                    string xmlContent = Encoding.UTF8.GetString(data);

                    xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(xmlContent);
                }
                ProcessData();
                DownloadPicture();
                Updated = true;
            }
            catch (System.Net.WebException e)
            {
                Updated = false;
            }
        }

        private void DownloadPicture()
        {
            IconPath = WeatherIcon + @".png";
            if (!File.Exists(IconPath))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri(@"http://openweathermap.org/img/w/"+WeatherIcon+".png"), 
                        IconPath);  
                }
            }
        }

        private void ProcessData()
        {
            XmlNode cityNode = xmlDocument.SelectSingleNode("current/city");
            XmlNode cityCoordNode = xmlDocument.SelectSingleNode("current/*/coord");
            City = cityNode.Attributes["name"].Value;

            Lon = cityCoordNode.Attributes["lon"].Value;
            Lat = cityCoordNode.Attributes["lat"].Value;

            Country = xmlDocument.SelectSingleNode("current/city/country").InnerText;

            XmlNode sunNode = xmlDocument.SelectSingleNode("current/*/sun");
            SunRise = sunNode.Attributes["rise"].Value;
            SunSet = sunNode.Attributes["set"].Value;


            XmlNode temperatureNode = xmlDocument.SelectSingleNode("current/temperature");
            Temperature = double.Parse(temperatureNode.Attributes["value"].Value.Replace('.',','));
            MinTemperature = double.Parse(temperatureNode.Attributes["min"].Value.Replace('.', ','));
            MaxTemperature = double.Parse(temperatureNode.Attributes["max"].Value.Replace('.', ','));


            XmlNode humidityNode = xmlDocument.SelectSingleNode("current/humidity");
            Humidity = double.Parse(humidityNode.Attributes["value"].Value.Replace('.', ','));
            HumidityUnit = humidityNode.Attributes["unit"].Value;

            XmlNode pressureNode = xmlDocument.SelectSingleNode("current/pressure");
            Pressure = double.Parse(pressureNode.Attributes["value"].Value.Replace('.', ','));
            PressureUnit = pressureNode.Attributes["unit"].Value;

            XmlNode windNode = xmlDocument.SelectSingleNode("current/*/speed");
            WindSpeed = windNode.Attributes["value"].Value;
            WindName = windNode.Attributes["name"].Value;

            XmlNode windDirectionNode = xmlDocument.SelectSingleNode("current/*/direction");
            WindDirection = double.Parse(windDirectionNode.Attributes["value"].Value.Replace('.', ','));

            XmlNode cloudsNode = xmlDocument.SelectSingleNode("current/clouds");
            Clouds = double.Parse(cloudsNode.Attributes["value"].Value.Replace('.', ','));
            CloudsName = cloudsNode.Attributes["name"].Value;

            XmlNode precipitationNode = xmlDocument.SelectSingleNode("current/precipitation");
            Precipitation = precipitationNode.Attributes["mode"].Value;

            XmlNode weatherNode = xmlDocument.SelectSingleNode("current/weather");
            WeatherNumber = double.Parse(weatherNode.Attributes["number"].Value.Replace('.', ','));
            WeatherValue = weatherNode.Attributes["value"].Value;
            WeatherIcon = weatherNode.Attributes["icon"].Value;

            XmlNode lastUpdateNode = xmlDocument.SelectSingleNode("current/lastupdate");
            LastUpdate = lastUpdateNode.Attributes["value"].Value;


        }
    }
}
