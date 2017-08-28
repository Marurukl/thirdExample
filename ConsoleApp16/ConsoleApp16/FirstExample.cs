using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class FirstExample
    {
        public void Handler()
        {
            char key;
            int count=0;
            for (;;)
            {
                key = Console.ReadKey().KeyChar;
                if (key == '.')
                {
                    break;
                }
                else if(key==' ')
                {

                    count++;
                    Console.WriteLine("проблелов : "+count);
                }






            }
        }
    }
}
