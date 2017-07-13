using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolomorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat1 = new Boat(2, 500, "White and Yellow", 70.0d, .78d);


            boat1.Move();
            boat1.Move();
            Console.WriteLine("Boat {0}",boat1.GetDistanceTraveled());


            Automobile car1 = new Automobile(4, 20, 4, 5, 500, "Blue", 260d);

            car1.Move();
            car1.Color = "Gold";
            car1.Move();
            Console.WriteLine("Your {1} Car {0}", car1.GetDistanceTraveled(),car1.Color);

            Aircraft plane = new Aircraft(100, 1000000, "White", 600);
            plane.Move();

            Console.WriteLine(plane.GetDistanceTraveled());
        }
    }
}
