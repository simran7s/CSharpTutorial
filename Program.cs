using System;
using System.Text;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Builder

            StringBuilder sb = new StringBuilder();

            

            //Add to sb
            sb.Append("This is the first sentence. ");

            //Add new line at the end of the insert sentence;
            sb.AppendLine("This is my second sentence.");

            //Add formated to sb
            sb.AppendFormat("My name is {0} and I live in {1}", "Simran", "Brampton");

            //Make sb empty string
            //sb.Clear(); 

            //replace the first string with whats in the second string
            sb.Replace("a", "e");

            //remove from index 5 to but not including index 7. (5,6)
            sb.Remove(5, 7);

            //must convert to string
            Console.WriteLine(sb.ToString());


        }
    }
}
