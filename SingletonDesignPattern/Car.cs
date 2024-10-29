using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }

        private static Car myCar = null;
        private Car()
        {
        }

        public static Car GetCar()
        {
            if (myCar is null)
                myCar = new Car();

            return myCar;
        }
    }
}
