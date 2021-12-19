using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    
    public class Weapon
    {
        public string Name;
        private int damage;

        public int  Damage
        {
            get
            {
                return damage;
            }
            set
            {                
                if(value <=0)
                {
                    throw new Exception("Урон не может быть нулевым");
                }
                damage = value;
            }

        }

        private int durability;
        public int Durability 
        {
            get { return durability; }
            set 
            {
                if (value <0 && value>100)
                {
                    throw new Exception("Прочность должжна быть от нуля до ста");
                }
                durability = value;

            }
        }

        public Weapon(string name ,int damage, int durability)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
        }

        public void DoDamage()
        {
            if(Durability>0 )
            {
                Durability--;
                Console.WriteLine($"Был нанесен урон {Damage}");
            }
            else 
            {
                Console.WriteLine("Оружие сломалось");
            }
            

        }

        public void Repair()
        {
            Durability = 100;
            Console.WriteLine("Оружие починено");
        }



    }

    public class Policeman
    {
        public string Name;
        public string Surname;
        public string Patronyc;
        public string  Rank;
        public Weapon Weapon;

        public Policeman(string name, string surname, string patronyc, string rank, Weapon weapon)
        {
            Name = name;
            Surname = surname;
            Patronyc = patronyc;
            Rank = rank;
            Weapon = weapon;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {Patronyc} {Rank} {Weapon.Name} {Weapon.Durability} " );
        }

        
    }
    
}
