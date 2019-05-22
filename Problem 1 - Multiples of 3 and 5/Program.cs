using System;

namespace Problem_1___Multiples_of_3_and_5
{
    class Multiples
    {
        static void Main(string[] args)
        {

            int maxNumber = 1000;
            int sumOfMultiples = 0;
            for(int i=1; i< maxNumber; i++)
            {
                if(i%3==0 || i%5==0)
                {
                    sumOfMultiples += i;
                    Console.WriteLine("New Multiple: " +  i);
                }
            }

            Console.WriteLine("The sum of the multiples of 3 or 5 is: " + sumOfMultiples);
        }
    }
}
