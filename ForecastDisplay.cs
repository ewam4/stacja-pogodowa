using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacjaPogodowa
{
    class ForecastDisplay : IObserver
    {
        private float currentPressure;
        private float lastPressure;

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.Write("Prognoza: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Pogoda się poprawia");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("Bez zmian");
            }
            else
            {
                Console.WriteLine("Uważaj na nadchodzące ochłodzenie i deszcz");
            }
        }
    }
}
