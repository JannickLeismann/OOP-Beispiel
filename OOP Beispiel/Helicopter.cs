using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Beispiel
{
    class Helicopter : Plane
    {
        public override void Landing()
        {
           // base.Landing();

            Console.WriteLine("Der Helicopter sinkt langsam.");
        }
    }
}
