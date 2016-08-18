using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CurrentConditions:IObserver,IDisplayElement
    {
        private ISubject subject;
        private float temperature, humidity, pressure;

        public CurrentConditions(ISubject subject)
        {
            this.subject = subject;
        }

        public void display()
        {
            Console.Out.WriteLine("Current Condition......");
        }


        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = humidity;

            this.display();
        }



        public string ObserverId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    class ForecastDisplay : IObserver, IDisplayElement
    {
        private ISubject subject;
        private float temperature, humidity, pressure;

        public ForecastDisplay(ISubject subject)
        {
            this.subject = subject;
        }

        public void display()
        {
            Console.Out.WriteLine("forecast Display.....");
        }


        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = humidity;

            this.display();
        }


        public string ObserverId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
