using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Homework.Control_Work.CW2.Reflection
{
    public  class ReflectionRunner
    {
        public static void Run()
        {
            Assembly assembly = Assembly
                .LoadFrom(
                @"C:\Программирование\ValentineGrachyov\Valentin Grachev Hw\bin\Debug\Homework.exe");

            var type = assembly.GetType();
            var n = new Reflection();



            Type EventType = typeof(Reflection);
            var reflectionMethod = typeof(Reflection).GetMethod("Print");

            reflectionMethod.Invoke(null, parameters: null);

            var privateFields = type.GetField("num", BindingFlags.Instance | BindingFlags.NonPublic);
            privateFields.GetValue(n);

            var Property = EventType.GetProperty("Num");
            Console.WriteLine(Property.GetValue(n.Num));
            Property.SetValue(n.Num, 5);
            Console.WriteLine(Property.GetValue(n.Num));

        }
    }
}
