using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class SecondExample
    {
        public void Handler()
        {
            ShowMenu();
            char key;
            for (;;)
            {
                
                key = Console.ReadKey().KeyChar;
                if (key == '1')
                {
                    Console.Clear();
                    Console.WriteLine("Введите Номер Билета  : ");
                    int tickeNumber;
                    Int32.TryParse(Console.ReadLine(), out tickeNumber);
                    CheckTicket(tickeNumber);
                }
                else if(key == '0')
                {
                    break;
                }
                ShowMenu();
            }
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 -  Ввести номер билета(6 Значное число).");
            Console.WriteLine("0 - Выход.");
        }
        public void CheckTicket(int ticketNumber)
        {
            
            int firstNumber=ticketNumber / 100000;
            int secondNumber=(ticketNumber / 10000)-(firstNumber*10);
            int thirdNumber=(ticketNumber/1000)-((ticketNumber/10000)*10);
            int fourNumber=((ticketNumber/100)-(ticketNumber/1000)*10);
            int fiveNumber= ((ticketNumber / 10) - (ticketNumber / 100) * 10); ;
            int sixNumber= ((ticketNumber / 1) - (ticketNumber / 10) * 10); ;
            
            if ((firstNumber + secondNumber + thirdNumber) == (fourNumber + fiveNumber + sixNumber))
            {
                Console.WriteLine("Поздравляю У вас счастливый билет !!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Жаль , но у вас не счастливый билет :(");
                Console.ReadLine();
            }
              
        }
    }
}
