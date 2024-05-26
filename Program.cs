using System;

namespace stacjaPogodowa
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            ForecastDisplay forecastDisplay = new ForecastDisplay();

            weatherStation.RegisterObserver(currentDisplay);
            weatherStation.RegisterObserver(forecastDisplay);

            weatherStation.SetMeasurements(25.0f, 65.0f, 1013.1f);
            weatherStation.SetMeasurements(22.0f, 70.0f, 1012.5f);
        }
    }
}
