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
                int kind = 0;//1 - ���������, 2 - ��������, 3 - ������
                int type = 0;//1 - ������, 2 - �������; 1 - ����������, 2 - �����; 1 - ������, 2 - ������
                do
                {
                    try
                    {
                        Console.Write("�������� ��� �� (1 - ���������, 2 - ��������, 3 - ������): ");
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
                        {//���������
                            do
                            {
                                try
                                {
                                    Console.Write("�������� ��� �� (1 - ������, 2 - �������): ");
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
                        {//��������
                            do
                            {
                                try
                                {
                                    Console.Write("�������� ��� �� (1 - ����������, 2 - �����): ");
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
                        {//������
                            do
                            {
                                try
                                {
                                    Console.Write("�������� ��� �� (1 - ������, 2 - ������): ");
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
                int enter = -1;//��������������� ���������� ��� ����� �����
                string enterString = "";//��������������� ���������� ��� ����� �����
                do
                {
                    try
                    {
                        Console.Write("������� ��������: ");
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
                        Console.Write("������� ����������������: ");
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
                        Console.Write("������� �����: ");
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
                        Console.Write("������� ���������� ���������: ");
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
                        Console.Write("������� ���������� ����������: ");
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
                vehicles.Last<Vehicle>().PrintInfo(vehicles.Last<Vehicle>());//����� ������������ ��
            }

            int nam = 0;
            Console.Clear();
            while (true)            //����
            {
                Console.WriteLine("�������� �������:");
                Console.WriteLine(" 1 - ������� ��� ������������ ��������");
                Console.WriteLine(" 2 - �������� ����� ������������ ��������");
                Console.WriteLine(" 3 - ������� ��� ������������ ��������");
                Console.WriteLine(" 0 - �����");
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
                    case 1://����� ���� ��
                        {
                            if (vehicles.Count == 0)
                                Console.WriteLine("������ ����. �������� ������������ ��������.");
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
                    case 2://���������� ������ ��
                        {
                            addNewVehicle();
                        }
                        break;
                    case 3://�������� ���� ��
                        {
                            if (vehicles.Count == 0)
                                Console.WriteLine("������ ����.");
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
