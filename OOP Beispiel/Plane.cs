using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Beispiel
{
    class Plane : Vehicle, IVehicle
    {
        public bool HasJetDrive { get; set; }

        public void Move()
        {
            Console.WriteLine("Die Räder befinden sich in der Luft.");
        }

        public virtual void Landing()
        {
            Console.WriteLine("Landeanflug beginnt mit Passagieren.");
        }
    }
}
