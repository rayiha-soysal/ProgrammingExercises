using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestionOne();
            QuestionTwo();

            Console.ReadKey();
        }

        private static void QuestionTwo()
        {
            //  By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            int i = 0, sum = 0, prev = 0,temp=0;
            while (i<4000000)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                if (i == 1)
                {
                    i++;
                    prev = 1;
                    continue;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                   
                    }

                    temp = i;
                    i += prev;
                    prev = temp;
                   

                }
            }

            Console.WriteLine("(the Fibonacci sequence whose values do not exceed four million) the sum of the even-valued terms = " + sum);
        }

        public static void QuestionOne()
        {
            // Find the sum of all the multiples of 3 or 5 below 1000.
            int i = 0, sum=0;

            while (i<1000)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;

                i++;
            }

            Console.WriteLine("the sum of all the multiples of 3 or 5 below 1000 = "+sum);
        }
    }
}
