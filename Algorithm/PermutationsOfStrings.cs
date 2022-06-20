using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class PermutationsOfStrings
    {
        // 
        public static void ReturnPermutation(String EnteredString,int FirstIndex,int LastIndex)
        {
                //If leftIndex and rightIndex are pointing to the same index of the enteredString, simply print the enteredString
                if (FirstIndex == LastIndex)
                {
                    Console.WriteLine();
                }
                //otherwise
                else
                {
                    //We start from the leftIndex here 1st index and go till the rightIndex here end of the enteredStringing to compute
                    for (int i = FirstIndex; i <= LastIndex; i++)
                    {
                    //Swapping the leftIndex char with the i'th index char i.e. current and the next
                    //to compute for the next string
                    EnteredString = Swap(EnteredString, FirstIndex, i);

                    //Recursive call
                    //passing enteredString for permutataion operation
                    ReturnPermutation(EnteredString, FirstIndex + 1, rightIndex);

                    //Swap the array again to make it as it was before
                    //this operation is known as backtracking
                    EnteredString = Swap(EnteredString, FirstIndex, i);

                    }
                }
            }

            //Method for swaping characters in the string and it is returning String
            public static String Swap(String enteredString, int leftIndex, int rightIndex)
            {
                //Creating a character array named tempString to perform swapping operation
                char[] tempString = EnteredString.ToCharArray();

                //creating a temporary variable temp for swapping operation
                //swap logic to swap leftIndex with the rightIndex
                char temp = tempString[leftIndex];
                tempString[leftIndex] = tempString[rightIndex];
                tempString[rightIndex] = temp;

                //Converting tempString array back to string
                string toReturn = new string(tempString);

                //Finally return the string which we have converted from the array
                return toReturn;
            }

            public void Driver()
            {
                Console.Write("Enter the string to find all of it's permutations : ");
                string enteredString = Console.ReadLine();
                Console.WriteLine("Permutations of the string " + enteredString + " are :");
                ReturnPermutation(enteredString, 0, enteredString.Length - 1);
            }
        

    }
}
