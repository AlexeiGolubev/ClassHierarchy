using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Liner : WaterTransport
    {
        public Liner() : base()
        {
        }

        public Liner(int speed, int loadCapacity, string brand, int numberOfStaff, int numberOfPassengers) : base(speed, loadCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public override void DeliverTheGoods()
        {
            Console.Write("Лайнер ");
            base.DeliverTheGoods();
        }

        public override void PrintInfo(Vehicle vehicle)
        {
            Console.WriteLine("Тип ТС - лайнер");
            base.PrintInfo(vehicle);
        }
    }
}
