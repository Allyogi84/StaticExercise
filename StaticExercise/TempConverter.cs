using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        private static int celsius;

        public static double FahrenheitToCelsius(double fahrenheit)

        {
            var result = (fahrenheit - 32) / 1.8;

                 return result;
            

                
        }
        public static double CelciusToFahrenheit(double celcius)

        {
            return celsius * 9 / 5 + 32;

        }
    }

}

