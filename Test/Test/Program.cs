using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>(); 
            void addNewVehicle() {
                int kind = 0;//1 - воздушный, 2 - наземный, 3 - водный
                int type = 0;//1 - самолёт, 2 - вертолёт; 1 - автомоболь, 2 - поезд; 1 - лайнер, 2 - танкер
                do
                {
                    try
                    {
                        Console.Write("Выберите вид ТС (1 - воздушный, 2 - наземный, 3 - водный): ");
                        kind = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (kind < 1 || kind > 3);
                switch (kind)
                {
                    case 1:
                        {//воздушный
                            do
                            {
                                try
                                {
                                    Console.Write("Выберите тип ТС (1 - самолёт, 2 - вертолёт): ");
                                    type = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            while (type < 1 || type > 2);
                            if (type == 1) { vehicles.Add(new Aircraft()); }
                            else { vehicles.Add(new Helicopter()); }
                        } break;
                    case 2:
                        {//наземный
                            do
                            {
                                try
                                {
                                    Console.Write("Выберите тип ТС (1 - автомоболь, 2 - поезд): ");
                                    type = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            while (type < 1 || type > 2);
                            if (type == 1) { vehicles.Add(new Auto()); }
                            else { vehicles.Add(new Train()); }
                        }
                        break;
                    case 3:
                        {//водный
                            do
                            {
                                try
                                {
                                    Console.Write("Выберите тип ТС (1 - лайнер, 2 - танкер): ");
                                    type = int.Parse(Console.ReadLine());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            while (type < 1 || type > 2);
                            if (type == 1) { vehicles.Add(new Liner()); }
                            else { vehicles.Add(new Tanker()); }
                        }
                        break;
                }
                int enter = -1;//вспомогательная переменная для ввода чисел
                string enterString = "";//вспомогательная переменная для ввода строк
                do
                {
                    try
                    {
                        Console.Write("Введите скорость: ");
                        enter = int.Parse(Console.ReadLine());
                        vehicles.Last<Vehicle>().Speed = enter;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (enter < 0 || enter > 30000);
                enter = -1;
                do
                {
                    try
                    {
                        Console.Write("Введите грузоподъёмность: ");
                        enter = int.Parse(Console.ReadLine());
                        vehicles.Last<Vehicle>().LoadCapacity = enter;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (enter < 0);
                enter = -1;
                do
                {
                    try
                    {
                        Console.Write("Введите марку: ");
                        enterString = Console.ReadLine();
                        vehicles.Last<Vehicle>().Brand = enterString;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (enterString == "");
                enterString = "";

                do
                {
                    try
                    {
                        Console.Write("Введите количество персонала: ");
                        enter = int.Parse(Console.ReadLine());
                        vehicles.Last<Vehicle>().NumberOfStaff = enter;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (enter < 0 || enter > 10000);
                enter = -1;
                do
                {
                    try
                    {
                        Console.Write("Введите количество пассажиров: ");
                        enter = int.Parse(Console.ReadLine());
                        vehicles.Last<Vehicle>().NumberOfPassengers = enter;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (enter < 0 || enter > 10000);
                enter = -1;
                Console.Clear();
                vehicles.Last<Vehicle>().PrintInfo(vehicles.Last<Vehicle>());//вывод добавленного ТС
            }

            int nam = 0;
            Console.Clear();
            while (true)            //меню
            {
                Console.WriteLine("Выберите функцию:");
                Console.WriteLine(" 1 - Вывести все транспортные средства");
                Console.WriteLine(" 2 - Добавить новое транспортное средство");
                Console.WriteLine(" 3 - Удалить все транспортные средства");
                Console.WriteLine(" 0 - Выход");
                try
                {
                    nam = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.Clear();
                switch (nam)
                {
                    case 0: Environment.Exit(0); break;//exit
                    case 1://вывод всех ТС
                        {
                            if (vehicles.Count == 0)
                                Console.WriteLine("Список пуст. Добавьте транспортное средство.");
                            else
                            {
                                for (int i = 0; i < vehicles.Count; i++)
                                {
                                    vehicles[i].PrintInfo(vehicles[i]);
                                    Console.WriteLine("");
                                }
                            }
                            //vehicles.Last<Vehicle>().PrintInfo(vehicles.Last<Vehicle>());
                        } break;
                    case 2://добавление нового ТС
                        {
                            addNewVehicle();
                        }
                        break;
                    case 3://удаление всех ТС
                        {
                            if (vehicles.Count == 0)
                                Console.WriteLine("Список пуст.");
                            else vehicles.Clear();
                        }
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }
        
            
        }
    }
}
