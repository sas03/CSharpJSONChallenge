using System.Text.Json;

namespace JSONChallenge;
class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("weather.json");
        WeatherInfo weatherinfo = JsonSerializer.Deserialize<WeatherInfo>(json);
        Console.WriteLine("Longitude = " + weatherinfo.coordonnees.lon + "Latitude = " + weatherinfo.coordonnees.lat);
        foreach(Weather weather in weatherinfo.weather)
        {
            Console.WriteLine("Id: " + weather.id + ", Main: " + weather.main + ", Description: " + weather.description + ", Icon: " + weather.icon);
        }
        Console.WriteLine("Base = " + weatherinfo.baseS);
        Console.WriteLine("Main temp = " + weatherinfo.main.temp + ", Main pressure = " + weatherinfo.main.pressure + ", Main humidity = " + weatherinfo.main.humidity + ", Main temp_min = " + weatherinfo.main.temp_min + ", Main temp_max = " + weatherinfo.main.temp_max);
        Console.WriteLine("Visibility = " + weatherinfo.visibility);
        Console.WriteLine("Wind speed = " + weatherinfo.wind.speed + ", Wind deg = " + weatherinfo.wind.deg);
        Console.WriteLine("Clouds all = " + weatherinfo.clouds.all);
        Console.WriteLine("Dt = " + weatherinfo.dt);
        Console.WriteLine("Sys type = " + weatherinfo.sys.type + ", Sys id = " + weatherinfo.sys.id + ", Sys message = " + weatherinfo.sys.message + ", Sys country = " + weatherinfo.sys.country + ", Sys sunrise = " + weatherinfo.sys.sunrise + ", Sys sunset = " + weatherinfo.sys.sunset);
        Console.WriteLine("Weather Id = " + weatherinfo.id);
        Console.WriteLine("Weather Name = " + weatherinfo.name);
        Console.WriteLine("Weather Cod = " + weatherinfo.cod);
    }
}
