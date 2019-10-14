/*
Author: Daniel Davidson
Date:   10/14/2019
CTEC 135: Microsoft Software Development with C# 

Module 3, Programming Assignment 2, Problem 1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            // declaring 
            int[] myArray = new int[10];

            // initializing 
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 1;
            }

            // travesing 
            Console.WriteLine("Array elements from 1-10 \n");
            foreach (int element in myArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.ReadLine();
            #endregion

            #region 2
            /*
             * create an array of ints of size 10
               Initialize the array using a for loop with values being the index multiplied by 10
               print the array using a for loop
             */

            Console.WriteLine("For loop \n");
            // declares an array of integers
            int[] intArray;

            intArray = new int[10];

            // initialize the first elements 
            // of the array 
            intArray[0] = 10;

            // initialize the second elements 
            // of the array 
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            intArray[4] = 50;
            intArray[5] = 60;
            intArray[6] = 70;
            intArray[7] = 80;
            intArray[8] = 90;
            intArray[9] = 100;

            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);
            Console.WriteLine("\n");
            #endregion

            #region 3
            // 2D Array 
            /* initialize elements */
            Console.WriteLine("12X12 Multiplication Table \n");
            for (int i = 0; i <= 12; i++)
            {
                /* prints out i elements */
                Console.Write(i + "\t");
                for (int j = 1; j <= 12; j++)
                {
                    if (i > 0) Console.Write(i * j + "\t");
                    else Console.Write(j + "\t");
                }
                Console.Write("\n");


            }
            #endregion
        }
    }
}
