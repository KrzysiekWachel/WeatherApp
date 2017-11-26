using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class SettingsView : Form
    {
        private WeatherModel model;
        List<string> currentCities;

        public SettingsView(WeatherModel m)
        {
            model = m;
            InitializeComponent();
            currentCities = model.GetAllCitiesNames();
            foreach (var c in currentCities)
            {
                listBoxCities.Items.Add(c);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            model.AddCity(textBoxCity.Text);
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string cityToRemove = listBoxCities.SelectedItem as string;
            listBoxCities.Items.Remove(cityToRemove);
            model.RemoveCity(cityToRemove);
        }
    }
}
