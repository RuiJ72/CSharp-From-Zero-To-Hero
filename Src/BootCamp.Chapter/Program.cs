using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Homework - Working with Variables and GitHub");
            Console.Write("\nPlease enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Now, enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nYour name is {name} and you have {age} old!");
        }
    }
}
