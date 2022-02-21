using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    public class MainFood
    {
        Ingrediate[] Composition;

        public DateTime Sell_By = new DateTime(2022, 2, 22);

        public TypeOffood Type;

        public override string ToString()
        {
            return Type.HotDish.ToString();
        }

        public virtual void Get_Menu(int maxCalory)
        {
            int hotDish_kalority = 15;
            int drink_kalority = 10;
            int salad_kalority = 5;
            int fastFood_kalority = 25;

            if(hotDish_kalority + drink_kalority< maxCalory )
            {
                Console.WriteLine($"{Type.HotDish} {Type.Drink}");
            }
            
            if(drink_kalority + salad_kalority + hotDish_kalority< maxCalory)
            {
                Console.WriteLine($"{Type.Drink} {Type.Salad} {Type.HotDish}");
            }

            if(drink_kalority + fastFood_kalority< maxCalory)
            {
                Console.WriteLine($"{Type.Drink} {Type.EasyFood}");
            }


        }


        

        



    }

    public class Child_Food : MainFood
    {
        
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 7 )
                {
                    throw new Exception("Ребенок должен быть старше 7");
                }
                age = value;
            }
        }

        
        public bool Alergy;

        public Child_Food(int age, bool alergy)
        {
            Age = age;
            Alergy = alergy;
        }




    }

    public class Child_Menu : Child_Food
    {
        
        public Child_Menu(int age, bool alergy ): base(age, alergy)
        {
            Age = age;
            Alergy = alergy;
        }
        
        public void Get_Menu(bool alergy)
        {
            bool hotDish_alergy = true;
            bool drink_alergy = true;
            bool salad_alergy = false;
            bool fastFood_alergy = true;

            if (hotDish_alergy && drink_alergy == alergy)
            {
                Console.WriteLine($"{Type.HotDish} {Type.Drink}");
            }

            if (hotDish_alergy && salad_alergy && hotDish_alergy == alergy)
            {
                Console.WriteLine($"{Type.Drink} {Type.Salad} {Type.HotDish}");
            }

            if (drink_alergy && fastFood_alergy == alergy)
            {
                Console.WriteLine($"{Type.Drink} {Type.EasyFood}");
            }



        }
    }

    
}
