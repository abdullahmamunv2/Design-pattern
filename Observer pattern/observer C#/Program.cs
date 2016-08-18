using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject sub = new WeatherData();

            IObserver currentCon = new CurrentConditions(sub);
            IObserver forecastDis = new ForecastDisplay(sub);

            sub.registerObserver(currentCon);
            sub.registerObserver(forecastDis);

            sub.setMeasurements(0, 0, 0);

            sub.removeObserver(forecastDis);

            sub.setMeasurements(0, 0, 0);

            Console.ReadLine();
        }
    }
}
