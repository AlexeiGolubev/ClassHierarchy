using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    class Vehicle
    {
        protected int speed;
        protected int loadCapacity;
        protected string brand;
        protected int numberOfStaff;
        protected int numberOfPassengers;
        
        public Vehicle()
        {
            this.speed = 0;
            this.loadCapacity = 0;
            this.brand = "Не указана";
            this.numberOfStaff = 0;
            this.numberOfPassengers = 0;
        }

        public Vehicle(int speed, int loadCapacity, string brand, int numberOfStaff, int numberOfPassengers)
        {
            this.speed = speed;
            this.loadCapacity = loadCapacity;
            this.brand = brand;
            this.numberOfStaff = numberOfStaff;
            this.numberOfPassengers = numberOfPassengers;
        }

        public int Speed {
            get { return speed; }
            set { this.speed = value; }
        }
        public int LoadCapacity {
            get { return loadCapacity; }
            set { this.loadCapacity = value; }
        }
        public string Brand {
            get { return brand; }
            set { this.brand = value; }
        }
        public int NumberOfStaff {
            get { return numberOfStaff; }
            set { this.numberOfStaff = value; }
        }
        public int NumberOfPassengers {
            get { return numberOfPassengers; }
            set { this.numberOfPassengers = value; }
        }

        public virtual void DeliverTheGoods()
        {
            Console.Write("доставляет груз ");
        }
        public virtual void PrintInfo(Vehicle vehicle)
        {
            Console.WriteLine("Скорость - " + vehicle.Speed+
                "\nГрузоподъёмность - " + vehicle.LoadCapacity +
                "\nМарка - " + vehicle.Brand +
                "\nКоличество персонала - " + vehicle.NumberOfStaff +
                "\nКоличество пассажиров - " + vehicle.NumberOfPassengers);
        }

    }
}
