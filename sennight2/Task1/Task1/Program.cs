using System;
using System.IO;
namespace Task1
{
    class Program
    {

        public static bool palindrome(string s)
        {
            char[] letter = new char[s.Length];
            letter = s.ToCharArray();
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (letter[i] != letter[length - i - 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Title = "Palindrome";
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string direction = (@"C:\Users\Андрей\Desktop\PP2\Week2\input1.txt");
            string check = File.ReadAllText(direction);
            if (palindrome(check) == true)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Yes");
            }
            else if (palindrome(check) == false)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("No");
            }
            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}