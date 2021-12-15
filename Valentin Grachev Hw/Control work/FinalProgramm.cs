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
        
        private int  power;
        public int Power 
        {
            get
            {
                return power;
            }
            set
            {
                if(value<0)
                {
                    throw new Exception("   МОЩНОСТЬ БОЛЬШЕ НУЛЯ");
                }
                power = value;
            }
        }
        public string EnergyClass;
        public string Name;

        
    }
     public   class Electronic: Tech
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
        private bool ethernet;
        public bool ethernetConnection;
       
        
        public Electronic(string maker, string name, int power, string energyclass, int  charge, int storage  )
        {
            Maker = maker;
            Name = name;
            Power = power;
            EnergyClass = energyclass;
            Charge = charge;
            Storage = storage;

        }



        public override string ToString()
        {
            return $"{Maker}\n{Name}";
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


}
