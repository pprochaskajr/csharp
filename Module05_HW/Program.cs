using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05_HW
{
    class Module05_HW
    {
        static void Main(string[] args)
        {
            
            int[] array = { 5, 6, 54, 7, 8, 5, 5, 5, 8, 9 };
            string[] strArray = new string[5];
            const int ARR_LEN_10 = 10;
            int[] arrayInitialize = new int[ARR_LEN_10];
            string str = "Hi";
            int n1 = 4;
            int[] linqArray = { 1, 2, 3, 5, 7, 9, 11, 13, 17, 23, 27 };
            Random rand = new Random();

            // here is an example of a for loop to initialize an array

            Console.WriteLine("Array is initialized to ....");

            for (int i = 0; i < arrayInitialize.Length; i++)
            {
                arrayInitialize[i] = i + 5;
                Console.WriteLine("arrayInitialize[{0}] is : {1}", i, arrayInitialize[i]);
            }
            Console.WriteLine("");

            //    Example of calling a static method

            Console.WriteLine("Calling a static method to display a value \nand pass an array to do it");
            Console.WriteLine("");

            ArrayTest(array[5], array);

            Console.WriteLine("");


            // here is an example of a foreach loop 

            Console.WriteLine("Example of a foreach loop.....");
            Console.WriteLine("");

            strArray[0] = "Moe";
            strArray[1] = "Larry";
            strArray[2] = "Curly";
            strArray[3] = "Shemp";
            strArray[4] = "Joe";

            foreach (string name in strArray)
                Console.WriteLine("Names are : " + name);

            Console.WriteLine("");
            // Method overloading
            Console.WriteLine("Example of method overloading ");
            Console.WriteLine("");
            Hello(str);
            int sqrNumber = Hello(str, n1);
            Console.WriteLine("Returned square value.." + sqrNumber);

            Console.WriteLine("");

            // recursion example of summing

            Console.WriteLine("Example of recursion using sum with input of 7....");
            Console.WriteLine("Also using Exception handling....");
            Console.WriteLine("");
            int number = RecurSum(7);
            
             Console.WriteLine("7 summed recursively is..." +  number);

            // using LINQ

             Console.WriteLine("");
             Console.WriteLine("Example using LINQ");
             Console.WriteLine("Printout original array");
             Console.WriteLine("");

             foreach (var element in linqArray)
                 Console.Write(" {0}", element);

             var filtered =
                 from value in linqArray
                 where value > 13
                 select value;

             Console.WriteLine("");
             Console.WriteLine("Displaying all values > 13");
             Console.WriteLine("");

             foreach (var element in filtered)
                 Console.Write(" {0}", element);

            // random number generation example 
             Console.WriteLine("");
             Console.WriteLine("Example of random number generation");
             Console.WriteLine("");
             Console.WriteLine("Create a random number between 1 and 50");
             Console.WriteLine("");

             int ranNum = rand.Next(1, 51);   
             Console.WriteLine("random number generated is... " + ranNum);
            
            Console.ReadKey();

        }

        // Method overloading

        public static void Hello(string strHello)
        {
            Console.WriteLine("Hello from Hello...." + strHello);

        }

        public static int Hello(string strHello, int n1)
        {
            Console.WriteLine("Hello from math Hello.." + strHello + "...with integer input..." + n1);
            return n1 * n1;
        }


        // Here is a static method that displays one value from an input array

        public static void ArrayTest(int oneValue, int[] arrayTest)
        {
            Console.WriteLine("oneValue is {0}", oneValue);
        }

        // Here is a static method that demostrates recursion and handles an exception

        public static int RecurSum(int n)
        {
            if (n <= 1)  // base case

                return 1;

            else    // recursive case
            {

                try
                {

                    return RecurSum(n - 1) + n;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                    return 99999; // dummy number to indicate problem
                }
            }
        }


    }
}
   