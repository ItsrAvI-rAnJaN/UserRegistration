using System;

namespace prGenric
{
    class program
    {

        //method for  Array using Generics..
        public static void pr_toPrint<T>(T[] inputArray)
        {
            foreach(var Element in inputArray)
            {
                Console.WriteLine(Element);
            }
            Console.WriteLine("##############################################");

        }
       
            static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t************ WELCOME TO GENERICS PRACTICE PROBLEM ***************");

            // Passing Value to Array
            int[] intArray = {1,2,3,4,5};
            double[] doubleArray = {1.1, 2.2, 3.3, 4.4, 5.5};
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
             
            // print Array
            program.pr_toPrint(intArray);
            program.pr_toPrint(doubleArray);
            program.pr_toPrint(charArray);

           
            Console.ReadKey();
        }
    }
}