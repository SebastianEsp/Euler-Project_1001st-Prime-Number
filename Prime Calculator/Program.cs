using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("which prime number do you want to find?");
            string num = Console.ReadLine();
            int numInt;
            Int32.TryParse(num, out numInt);
            numInt -= 1;

            List<int> primeNumbers = new List<int>();
            bool isPrime = true;

            for (int i = 2; i <= 200000; i++)
            {
                for (int j = 2; j <= 200000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
                isPrime = true;
            }     

            primeNumbers.ForEach(y => Console.WriteLine("{0}", y));
            Console.WriteLine("\nThe 10001st prime number is: {0}",primeNumbers[numInt].ToString());
            Console.Read();
        }
    }
}
