using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class WaterTransport : Vehicle
    {
        public WaterTransport() : base()
        {
        }

        public WaterTransport(int speed, int loadCapacity, string brand, int numberOfStaff, int numberOfPassengers) : base(speed, loadCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public override void DeliverTheGoods()
        {
            base.DeliverTheGoods();
            Console.Write("по воде.\n");
        }

        public override void PrintInfo(Vehicle vehicle)
        {
            Console.WriteLine("Вид ТС - водный");
            base.PrintInfo(vehicle);
        }
    }
}
