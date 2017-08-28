using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class ThirdExample
    {
        string word;
        string newWord;
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
                    Console.WriteLine("Введите слово  : ");
                    word=Console.ReadLine();
                    RegistrarСhange(word);
                    word = newWord;
                    Console.WriteLine("Ваше слово : " + word);
                    Console.ReadLine();
                }
                else if (key == '0')
                {
                    break;
                }
                ShowMenu();
            }
        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 -  Введите любое слово.");
            Console.WriteLine("0 - Выход.");
        }
        public void Registar()
        {
            Console.WriteLine("1 - Верхний регистор.");
            Console.WriteLine("2 - Нижний регистор.");
        }
        public void RegistrarСhange(string word)
        {
            Registar();
            char key;
            for (;;)
            {
                key = Console.ReadKey().KeyChar;
                if (key == '1')
                {
                   newWord= word.ToUpper();
                    break;
                }
                else if(key == '2')
                {
                   newWord= word.ToLower();
                    break;
                }
                Registar();
            } 
        }
    }
}
