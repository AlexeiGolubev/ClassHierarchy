using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Aircraft : AirTransport
    {
        public Aircraft() : base()
        {
        }

        public Aircraft(int speed, int loadCapacity, string brand, int numberOfStaff, int numberOfPassengers) : base(speed, loadCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public override void DeliverTheGoods()
        {
            Console.Write("Самолёт ");
            base.DeliverTheGoods();
        }

        public override void PrintInfo(Vehicle vehicle)
        {
            Console.WriteLine("Тип ТС - самолёт");
            base.PrintInfo(vehicle);
        }
    }
}
