using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class Vehicle
    {
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
    }

}
