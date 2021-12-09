using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATA TYPES

            bool canVote = true;

            char grade = 'A';

            //NUMBERS

            int maxInt = int.MaxValue;

            long maxLong = long.MaxValue;

            decimal maxDec = decimal.MaxValue;

            float maxFloat = float.MaxValue;

            double maxDouble = double.MaxValue;


            Console.WriteLine("Max int: " + maxInt);

            //defined when program is complied. BUT CANT BE CHANGED
            var anotherName = "tom";

            Console.WriteLine("Another name is {0}", anotherName);
        }
    }
}
