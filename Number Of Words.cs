using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input :");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == ' ' && Char.IsLetter(input[i + 1]) && (i > 0))
                {
                    count++;
                }
            }
            count++;
            Console.WriteLine("Total number of words in the string is :" + count);
        }

    }
}
