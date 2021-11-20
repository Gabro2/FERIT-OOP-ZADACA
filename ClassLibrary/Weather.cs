using System;
using System.Collections.Generic;
using System.Text;
namespace ClassLibrary
{
    public class Weather
    {
        double temperature;
        double windspeed;
        double humidity;
        public Weather()
        {

        }
        public Weather(double temperature, double humidity, double windspeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windspeed = windspeed;
        }
        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }
        public void SetWindSpeed(double windspeed)
        {
            this.windspeed = windspeed;
        }
        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }
        public double GetTemperature()
        {
            return temperature;
        }
        public double GetHumidity()
        {
            return humidity;
        }
        public double GetWindSpeed()
        {
            return windspeed;
        }
        public double CalculateFeelsLikeTemperature()
        {
            double c1 = -8.78469475556;
            double c2 = 1.61139411 * temperature;
            double c3 = 2.33854883889 * humidity;
            double c4 = -0.14611605 * temperature * humidity;
            double c5 = -0.012308094 * Math.Pow(temperature, 2);
            double c6 = -0.0164248277778 * Math.Pow(humidity, 2);
            double c7 = 0.002211732 * Math.Pow(temperature, 2) * humidity;
            double c8 = 0.00072546 * temperature * Math.Pow(humidity, 2);
            double c9 = -0.000003582 * Math.Pow(humidity, 2) * Math.Pow(temperature, 2);
            return c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9;
        }

        public double CalculateWindChill()
        {
            if (windspeed > 4.8 && temperature <= 10)
            {
                return 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windspeed, 0.16) + 0.3965 * temperature * Math.Pow(windspeed, 0.16);
            }
            else
            {
                return 0;
            }

        }

    }

}
