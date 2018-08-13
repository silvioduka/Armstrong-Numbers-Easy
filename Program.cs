/*
Armstrong Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-24 

An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself. 

For example, 153 is an Armstrong number, as 1**3 + 5**3 + 3**3 = 153 

Create a program to check whether a given number is an Armstrong number or nor. 
Also, create a program to print all Armstrong numbers in a given range. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 153; // Insert a number to check whether a given number is an Armstrong number or nor

            int armstrong = 0;
            int t = number;

            while (t != 0)
            {
                armstrong += (int)Math.Pow(t % 10, 3);

                t = t / 10;
            }

            Console.WriteLine($"The number {number} {((number == armstrong) ? "is" : "is not")} an Armstrong number.");
        }
    }
}