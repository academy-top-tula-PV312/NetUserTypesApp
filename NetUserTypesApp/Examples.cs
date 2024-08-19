using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetUserTypesApp
{
    static class Examples
    {
        public static void NameSpaces()
        {
            //using MyName;

            //Console.WriteLine("Hello");
            //Person person;

            //namespace MyName
            //{
            //    class Person { }
            //}
        }

        public static void InterpolatonString()
        {
            string city = "Moscow";
            int code = 77;

            Console.WriteLine($"{city:#-#-#-#-#}");

            Console.WriteLine($"City name: {city}, code: {code}, 2 + 2 = {Sum(2, 2)}");
            Console.WriteLine($"City name: {1}, code: {0}, 2 + 2 = {2}", code, city, Sum(2, 2));

            decimal price = 100.2M;
            string sprice = string.Format("{0:C2}", price);
            Console.WriteLine($"{price:C2}");

            int num = 15;
            Console.WriteLine($"{num:D4}");

            double x = 0.5;
            Console.WriteLine($"{x:F1}");
            Console.WriteLine($"{x:P}");

            long phone = 79991234567;
            Console.WriteLine($"{phone:+# (###) ###-##-##}");

            int Sum(int a, int b)
            {
                return a + b;
            }
        }
    }
}
