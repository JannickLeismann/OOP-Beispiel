using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Beispiel
{
    class Motorcycle : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Zwei Räder haben bodenkontakt.");
        }
    }
}
