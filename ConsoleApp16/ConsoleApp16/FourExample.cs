
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class FourExample
    {
        public void Handler()
        {
            Console.WriteLine("Введите число А и B : ");
            int a, b;
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            for (; a < b; a++)
            {
               
                for (int i = 0; i < a; i++)
                {
                    if (i != a-1)
                        Console.Write(a);
                    else if (i == a-1)
                        Console.WriteLine(a);
                }

            }
            Console.ReadLine();
        }
    }
}
