using System;

namespace Week4Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = GetNumber();
            if (number % 2 == 0)
            {
                Console.WriteLine("Podałeś liczbę parzystą");
            }
            else
                Console.WriteLine("Podałeś liczbę nieparzystą");
        }

        public static int GetNumber()
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }
                return number;
            }            
        }
    }
}
