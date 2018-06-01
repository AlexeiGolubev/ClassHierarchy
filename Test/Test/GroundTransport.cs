using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GroundTransport : Vehicle
    {
        public GroundTransport() : base()
        {
        }

        public GroundTransport(int speed, int loadCapacity, string brand, int numberOfStaff, int numberOfPassengers) : base(speed, loadCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public override void DeliverTheGoods()
        {
            base.DeliverTheGoods();
            Console.Write("по земле.\n");
        }

        public override void PrintInfo(Vehicle vehicle)
        {
            Console.WriteLine("Вид ТС - наземный");
            base.PrintInfo(vehicle);
        }
    }
}
