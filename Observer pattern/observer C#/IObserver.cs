using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface IObserver
    {
        string ObserverId { get; set; }
        void update(float temperature, float humidity, float pressure); 

    }
}
