using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9Tareas.MVVM.Models
{

    public class MapboxModel
    {
        public string type { get; set; }
        public Feature[] features { get; set; }
        public string attribution { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public string id { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public float[] coordinates { get; set; }
    }

    public class Properties
    {
        public string mapbox_id { get; set; }
        public string feature_type { get; set; }
        public string full_address { get; set; }
        public string name { get; set; }
        public string name_preferred { get; set; }
        public Coordinates coordinates { get; set; }
        public string place_formatted { get; set; }
        public float[] bbox { get; set; }
        public Context context { get; set; }
    }

    public class Coordinates
    {
        public float longitude { get; set; }
        public float latitude { get; set; }
    }

    public class Context
    {
        public Region region { get; set; }
        public Country country { get; set; }
        public Place place { get; set; }
    }

    public class Region
    {
        public string mapbox_id { get; set; }
        public string name { get; set; }
        public string wikidata_id { get; set; }
        public string region_code { get; set; }
        public string region_code_full { get; set; }
    }

    public class Country
    {
        public string mapbox_id { get; set; }
        public string name { get; set; }
        public string wikidata_id { get; set; }
        public string country_code { get; set; }
        public string country_code_alpha_3 { get; set; }
    }

    public class Place
    {
        public string mapbox_id { get; set; }
        public string name { get; set; }
        public string wikidata_id { get; set; }
    }

}
