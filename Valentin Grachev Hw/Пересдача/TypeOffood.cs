using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework
{
    public class TypeOffood
    {
        public string HotDish;
        public string Drink;
        public string Salad;
        public string EasyFood;

        public TypeOffood(string hotDish, string drink, string salad, string easyFood)
        {
            HotDish = hotDish;
            Drink = drink;
            Salad = salad;
            EasyFood = easyFood;
        }

        public void Get_In_File(string path)
        {
            StreamWriter str = new StreamWriter(path);

            str.WriteLine(HotDish);
            str.WriteLine(Salad);
            str.WriteLine(Drink);
            str.WriteLine(EasyFood);
        }
    }

    
}
