using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
     class AirTransport : Vehicle
    {
        public AirTransport() : base()
        {
        }

        public AirTransport(int speed, int loadCapacity, string brand, int numberOfStaff, int numberOfPassengers) : base(speed, loadCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public override void DeliverTheGoods()
        {
            base.DeliverTheGoods();
            Console.Write("по воздуху.\n");
        }

        public override void PrintInfo(Vehicle vehicle)
        {
            Console.WriteLine("Вид ТС - воздушный");
            base.PrintInfo(vehicle);
        }
    }
}
