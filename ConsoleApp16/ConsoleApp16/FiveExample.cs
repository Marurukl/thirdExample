using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class FiveExample
    {
        public void Handler()
        {
            int n;
            Console.WriteLine("Введите цифру : ");
            Int32.TryParse(Console.ReadLine(), out n);
            // 1234
            // 12
            // 123
            // 
            int thousandInNumber = n / 1000;
            int hundredInNumber = n / 100 - (n/1000 * 10);
            int tenInNumber = n / 10 - ((n/100)*10);
            int oneInNumber = n - (n/10*10);
            if(n/1000 != 0)
            {
                Console.WriteLine(oneInNumber+ tenInNumber+ hundredInNumber + thousandInNumber);
                Console.ReadLine();
            }
            else if (n/100 != 0)
            {
                Console.WriteLine(oneInNumber  + tenInNumber  + hundredInNumber );
                Console.ReadLine();
            }
            else if (n / 10 != 0)
            {
                Console.WriteLine(oneInNumber  + tenInNumber );
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(oneInNumber);
                Console.ReadLine();
            }

        }
    }
}
