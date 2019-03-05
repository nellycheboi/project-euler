﻿using System;
using System.Linq;
namespace ProjectEuler
{
    public class Problems
    {
        public  void MultiplesOf3And5()
        {
           
                Puts("Find the sum of all the multiples of 3 and 5 below a limit. Input a limit", out string input);
                if (Int64.TryParse(input, out long limit))
                {
                    ulong result = MultiplesOf3And5(limit);
                    Puts($"The sum is {result}");
                }
                else
                {
                    Puts($"Invalid input. Make sure you input is an number. The maximum we can accept is {long.MaxValue}", out input);
                }
            
        }
        public void EvenFibonacciNumbers()
        {
         
                Puts("Find the sum all of all even valued fibonnaci numbers below a limit. Input a limit",  out string input);
                if (Int64.TryParse(input, out long limit))
                {
                    ulong result = EvenFibonacciNumbers(limit);
                    Puts($"The sum is {result}");
                }
                else
                {
                    Puts($"Invalid input. Make sure you input is an number. The maximum we can accept is {long.MaxValue}");

                }
         
        }
        public  void LargestPrimeFactor()
        {

            Puts("Find the largest prime factor of a number. Input a number", out string input);
            if (Int64.TryParse(input, out long number))
            {
                long result = LargestPrimeFactor(number);
                Puts();
                Puts($"The largest prime factor of {number} is {result}");
            }
            else
            {
                Puts();
                Puts($"Invalid input. Make sure you input is an number. The maximum we can accept is {long.MaxValue}");

            }

        }

        #region Problems
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// <para>Find the sum of all the multiples of 3 or 5 below 1000.</para>
        /// https://projecteuler.net/problem=2
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        private  ulong MultiplesOf3And5(long limit)
        {

            ulong currentSum = 0;
            for (long i = 2; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentSum += (ulong)i;
                }
            }
            return currentSum;
        }
        /// <summary>
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        /// <para>1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...</para>
        /// <para>By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.</para>
        /// https://projecteuler.net/problem=2
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        private  ulong EvenFibonacciNumbers(long limit)
        {
            (long prev, long current) = (1, 2);
            ulong totalSum = 0;
            while (current < limit)
            {
                ulong innerSum = (ulong)prev + (ulong)current;
                Puts($"({prev}, {current})");

                if (current % 2 == 0)
                {
                    totalSum += (ulong)current;
                    Puts($"Adding {current} to the to total sum");
                }
                else
                {
                   // Puts($"Skipping {current};");

                }
                prev = current;
                current = (long)innerSum;
                Puts();
            }
            return totalSum;
        }


        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// <para>What is the largest prime factor of the number 600851475143 ?</para>
        /// <para>https://projecteuler.net/problem=3</para>
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private  long LargestPrimeFactor(long number)
        {
            long largest = 0;
            for(long i = 2; i <= Math.Sqrt(number); i++)
            {
                
                if (number%i == 0  )
                {
                    if (IsPrime(i))
                    {
                        Puts($"{i} is a prime factor of {number}");
                        largest = i;
                    }
                    else
                    {
                        Puts($"{i} is a  factor of {number}");

                    }
                }
            }
            if(largest == 0)
            {
                Puts($"{number} is a prime");
            }
            return largest;
        }
        private  bool IsPrime(long number)
        {
            if(number == 2)
            {
                return true;
            }
            for (long i = 3; i <= Math.Sqrt(number); i=i+2)
            {
                if(number % i == 0)
                {
                    return false; 
                }
            }
            return true;
        }

        #endregion

        #region Helpers
        private  void Puts(string input, out string output)
        {
            Console.WriteLine("CTRL+C to interrupt the read operation:");

            Puts(input);
            output = Console.ReadLine();

        }
        private  void Puts(string input = "")
        {
            Console.WriteLine($"{ input}");

        }
        #endregion

    }
}
