using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Beispiel
{
    class Car : Vehicle, IVehicle
    {
        public void Move() {
            Console.WriteLine("Vier Räder haben bodenkontakt.");
        }
    }
}
