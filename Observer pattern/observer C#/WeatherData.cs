using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : ISubject
    {
        private List<IObserver> ObserverList;
        private float temperature,humidity,pressure;

        public WeatherData()
        {
            ObserverList = new List<IObserver>();
        }
    
        public void registerObserver(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            try
            {
                ObserverList.Remove(observer);
            }
            catch (Exception ex)
            {

            }
        }

        public void notifyObserver()
        {
            for (int i = 0; i < ObserverList.Count; i++)
                ObserverList[i].update(temperature, humidity, pressure);
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.measurementChanged();
        }


        public void measurementChanged()
        {
            this.notifyObserver();
        }
    }
}
