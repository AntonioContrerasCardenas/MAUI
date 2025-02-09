using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using P9Tareas.MVVM.Models;
using PropertyChanged;

namespace P9Tareas.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class TiempoViewModel
    {
        public TiempoModel TiempoModel { get; set; }
        private HttpClient client;
        private JsonSerializerOptions _serializerOptions;
        public string Lugar { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public TiempoViewModel()
        {
            _serializerOptions = new JsonSerializerOptions();
            client = new HttpClient();  
        }

        public async Task GetWeather(Location location)
        {
            string longitud = (Math.Round(location.Longitude, 2).ToString().Replace(",", "."));
            string latitud = (Math.Round(location.Latitude, 2).ToString().Replace(",", "."));

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitud}&longitude={longitud}&daily=weather_code,temperature_2m_max,temperature_2m_min";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<TiempoModel>(responseStream);
                    TiempoModel = data;
                }
            }
        }

        public ICommand SearchCommand =>
            new Command(async(searchTxt) => {
                Lugar = searchTxt.ToString();
                var location = await GetCoordinatesAsync(searchTxt.ToString());
                await GetWeather(location);
            });

        private async Task<Location> GetCoordinatesAsync(string addres)
        {
            var locations = await Geocoding.GetLocationsAsync(addres);
            var location = locations?.FirstOrDefault();
            return location;
        }
    }
}
