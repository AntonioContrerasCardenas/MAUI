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
        public bool IsVisible { get; set; } = false;

        public TiempoViewModel()
        {
            _serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            client = new HttpClient();  
        }

        public async Task GetWeather(Location location)
        {
            string longitud = (Math.Round(location.Longitude, 2).ToString().Replace(",", "."));
            string latitud = (Math.Round(location.Latitude, 2).ToString().Replace(",", "."));

            var url = $"https://api.open-meteo.com/v1/forecast?latitude={latitud}&longitude={longitud}&current=temperature_2m&daily=weather_code,temperature_2m_max,temperature_2m_min&current_weather=true";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<TiempoModel>(responseStream, _serializerOptions);
                    TiempoModel = data;
                }
            }
        }

        public ICommand SearchCommand =>
            new Command(async(searchTxt) => {
                Lugar = searchTxt.ToString();
                var location = await GetCoordinatesAsync2(searchTxt.ToString());
                await GetWeather(location);
                IsVisible = true;
            });

        private async Task<Location> GetCoordinatesAsync2(string address)
        {
            string url = $"https://api.mapbox.com/search/geocode/v6/forward?access_token=pk.eyJ1IjoiYW50b25pbzc1NjQ1IiwiYSI6ImNtNXNqaGV6MDBoaHoya3F1dTIwZmVjZHUifQ.VKQ6UbOXCQIflEUm08bHng&q={address}&limit=1";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<MapboxModel>(responseStream);
                    return new Location { Latitude = data.features[0].properties.coordinates.latitude, Longitude = data.features[0].properties.coordinates.longitude };
                }
            }

            return new Location { Latitude = 0, Longitude = 0 };
        }

        private async Task<Location> GetCoordinatesAsync(string addres)
        {
            var locations = await Geocoding.GetLocationsAsync(addres);
            var location = locations?.FirstOrDefault();
            return location;
        }
    }
}
