using System;

namespace _05_Temperature
{
    public enum Unit
    {
        Fahrenheit,
            Celcius
    };
 
    internal class Temperature
    {
        public Temperature(Unit unit, double input)
        {
            Fahrenheit = input;
            Celcius = input; 
        }

        public Temperature()
        { }
        private double fahrenheit;
        private double celcius;
        public double Fahrenheit
        {
        get { return fahrenheit; }
         set { fahrenheit = value; }
        }

        public double Celcius
        {
         get {return celcius;}
         set {celcius = value;}
        }

        internal static double FahrenheitToCelcius(double f)
        {
            double c = (f - 32) * 5/9;

            return c;
        }

        internal static double CelciusToFahrenheit(double c)
        {
            double f = c * 9/5 + 32;

            return f;
        }
    }
}