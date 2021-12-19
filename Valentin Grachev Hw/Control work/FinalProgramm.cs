using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    abstract public class Tech
    {
        public string Maker;

        private int power;
        public int Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("   МОЩНОСТЬ БОЛЬШЕ НУЛЯ");
                }
                power = value;
            }
        }
        public string EnergyClass;
        public string Name;


    }
    public class Electronic : Tech
    {
        private int charge;
        public int Charge
        {
            get
            {
                return charge;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    charge = value;
                }
                else
                    throw new Exception("Заряд от 0 до 100");
            }
        }
        private int storage;
        public int Storage
        {
            get
            {
                return storage;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("  ПАМЯТЬ БОЛЬШЕ НУЛЯ");
                }
                storage = value;
            }
        }

        public bool EthernetConnection;



        public Electronic(string maker, string name, int power, string energyclass, int charge, int storage, bool ethernet)
        {
            Maker = maker;
            Name = name;
            Power = power;
            EnergyClass = energyclass;
            Charge = charge;
            Storage = storage;
            EthernetConnection = ethernet;

        }



        public override string ToString()
        {
            return $"{Maker}\n{Name}";
        }

        public override int GetHashCode()
        {
            return 54 * Power * Charge;
        }

        public override bool Equals(object obj)
        {
            var b = obj as Electronic;
            if (Name == b.Name && Maker == b.Maker && Power == b.Power && EnergyClass == b.EnergyClass
                && Charge == b.Charge && Storage == b.Storage
                && EthernetConnection == b.EthernetConnection) return true;
            return false;
        }

        public void InFile()
        {
            var file = new StreamWriter(@"C:\Программирование\text.txt", true);
            file.Write($" {ToString()} {this.RepairC()}");
            file.Dispose();

        }

    }
    public static class Extention
    {
        public static string RepairC(this Electronic price)
        {
            string cost = Console.ReadLine();
            Console.WriteLine($"За ремонт отдано {cost}");
            return $"За ремонт отдано {cost}";
        }
    }

    public class Stack
    {
        private Electronic[] devices = { };

        public void Add(params Electronic[] add)
        {
            Electronic[] result = new Electronic[devices.Length + add.Length]; // Creating array with needing length

            devices.CopyTo(result, 0); // Copy source array to the new array
            add.CopyTo(result, devices.Length); // Copy add array or nums to the new array

            devices = result;
        }

        

        public Stack() { }

        public Electronic Read()
        {
            if (devices.Length == 0)
                throw new Exception("Stack is empty");
            var result = devices[devices.Length - 1];

            Electronic[] new_devices = new Electronic[devices.Length - 1];

            for (int i = 0; i < new_devices.Length; i++)
            {
                new_devices[i] = devices[i];
            }


            devices = new_devices;
            return result;
        }

        public void Print()
        {
            foreach (var device in devices)
                Console.WriteLine(device.ToString());
        }
    }
}  
