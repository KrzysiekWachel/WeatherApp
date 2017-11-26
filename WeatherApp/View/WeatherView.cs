using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Model;

namespace WeatherApp
{
    public partial class WeatherView : Form
    {
        private WeatherModel model;
        private SettingsView settings;
        public WeatherView()
        {
            InitializeComponent();

            model = new WeatherModel(this);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            model.UpdateDataAsync();
        }

        public void ShowWeather(Weather w)
        {
            if (!w.Updated)
            {
                labelError.Text = "No Internet connection";
            }
            else
            {
                labelError.Text = "";
            }
            labelCity.Text = $"City: {w.City}, {w.Country}";
            labelTemp.Text = $"Temperature: {w.Temperature}°C";
            labelSunRise.Text = $"Sunrise: {w.SunRise}";
            labelSunSet.Text = $"Sunset: {w.SunSet}";
            labelMaxTemp.Text = $"Maximum temperature: {w.MaxTemperature}°C";
            labelMinTemp.Text = $"Minimum temperature: {w.MinTemperature}°C";
            labelWind.Text = $"Wind: {w.WindSpeed} m/s - {w.WindName}";
            labelPressure.Text = $"Pressure: {w.Pressure} {w.PressureUnit}";
            labelHumidity.Text = $"Humidity: {w.Humidity} {w.HumidityUnit}";
            labelCloud.Text = $"Cloudy: {w.Clouds} {w.CloudsName}";
            Image image = Image.FromFile(w.IconPath);
            pictureBoxWeather.BackgroundImage = image;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            settings = new SettingsView(model);
            settings.ShowDialog();
        }

        public void AddCityToList(string cityName)
        {
            comboBoxCity.Items.Add(cityName);
            comboBoxCity.SelectedItem = comboBoxCity.Items.OfType<string>().Last();
            panelWeather.Visible = true;
        }

        public void RemoveCityFromList(string cityName)
        {
            comboBoxCity.Items.Remove(cityName);
            if (comboBoxCity.Items.Count > 0)
            {
                comboBoxCity.SelectedItem = comboBoxCity.Items.OfType<string>().Last();
                string otherCity = comboBoxCity.SelectedItem as string;
                model.SelectCity(otherCity);
                model.UpdateDataAsync();
            }
            else
            {
                panelWeather.Visible = false;
            }

        }

        private void comboBoxCity_DropDownClosed(object sender, EventArgs e)
        {
            string cityName = comboBoxCity.SelectedItem as string;
            model.SelectCity(cityName);
            model.UpdateDataAsync();
        }

        private void WeatherView_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void WeatherView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author: Krzysztof Wachel \r\n2017",
                "Weather",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void pictureBoxWeather_Click(object sender, EventArgs e)
        {

        }
    }
}
