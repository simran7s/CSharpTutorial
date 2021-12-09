using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment

            /* 
             Multiline comment
             */

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
