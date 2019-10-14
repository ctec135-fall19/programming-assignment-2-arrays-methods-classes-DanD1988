/*
Author: Daniel Davidson
Date:   10/14/2019
CTEC 135: Microsoft Software Development with C# 

Module 3, Programming Assignment 2, Problem 2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 demo of call by value

            int x = 120;

            Console.WriteLine("Value Before Calling the Method: {0}", x);

            callByValue(x);

            Console.WriteLine("Value After Calling the Method: {0}", x);

            Console.ReadLine();

            #endregion

            #region 2 demo of call by reference
            Console.WriteLine("----Demo of call by reference----\n");
            int[] myArray = new int[] { 20, 30, 40, 50, 60 };

            Console.WriteLine("Before method call");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("{0} ", myArray[i]);
            }

            Console.WriteLine("After method call");
            callReference(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("{0}", myArray[i]);
            }
            #endregion

            #region 3 Overloading
            // calls int version of add
            Console.WriteLine(Add(10, 10));
            #endregion
        }
        // static method to demonstrate call by value
        static void callByValue(int x)
        {
            x *= x;

            Console.WriteLine("Variable Value Inside the Method: {0}", x);
        }


        static void callReference(int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = i * 3;
            }
            Console.WriteLine("Variable Value Inside the Method: {0}", y);
        }

        static void Add(long x, long y)
        {
            return x + y;
        }

    }
}