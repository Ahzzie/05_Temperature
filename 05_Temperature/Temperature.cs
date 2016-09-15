using System;

namespace _05_Temperature
{
    internal class Temperature
    {
        internal static double FahrenheitToCelcius(double f)
        {
            double c = (f - 32) * 5 / 9;

            return c;
        }

        internal static double CelciusToFahrenheit(double c)
        {
            double f = c * 9/5 + 32;
            return f;
        }
    }
}