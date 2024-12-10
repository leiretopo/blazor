namespace ProyectoRifa
{
    public class MisEndPoints
    {
        public static String GetGeoApifyEndPoint(String ciudad)
        {
            return "https://api.geoapify.com/v1/geocode/search?text=" + ciudad + "&format=json&apiKey=" + MiConfig.GeoApifyKey;
        }

        public static string GetWeatherEndpoint(float lat, float lon)
        {
            return "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m&hourly=temperature_2m&daily=weather_code,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
        }
    }
}
