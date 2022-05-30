using System;

namespace TestMaximumGenerics
{
    class program
    {
        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t******** WELCOME TO FIND MAXIMUM PROBLEM USING GENERICS ********");

            int Choice; //Creating Variable to Store Input From User
            do
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Find Maximum Among Three Integer");
                Console.WriteLine("2.Find Maximum Among Three Float");
                Console.WriteLine("3.Find Maximum Among Three String Value");
                Console.WriteLine("4.Find Maximum Among Three Value Using Generics Method");
                Console.WriteLine("5.Find Maximum Among Three Value Using Generic Class");


                Console.Write("Enter Your Choice : ");
                Choice=Convert.ToInt32(Console.ReadLine()); // store iput From User & Convert Into Integer type

                // Using Switch Case To Excute Prgram Input by User
                switch (Choice)
                {
                    case 1:

                        // Creating Instance of Class FindMaxInt
                        FindMaxInt objFindMaxInt =new FindMaxInt();

                        // printing Max Int No. AMong Three
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(30, 20, 10)); 

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(10, 30, 20));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxInt.FindMaxAmongInt(10, 20, 30));

                        Console.WriteLine("###################################################");

                        break;

                    case 2:
                        // Creating Instance of Class FindMaxFloat
                        FindMaxFloat objFindMaxFloat = new FindMaxFloat();

                        // printing Max Float No. AMong Three
                        Console.WriteLine("Maximum Float Number = {0}", objFindMaxFloat.FindMaxAmongFloat(3.1f, 2.1f, 1.1f));

                        Console.WriteLine("Maximum Float Number = {0}", objFindMaxFloat.FindMaxAmongFloat(1.1f, 3.1f, 2.1f));

                        Console.WriteLine("Maximum Float Number = {0}", objFindMaxFloat.FindMaxAmongFloat(1.1f, 2.1f, 3.1f));
                       
                        Console.WriteLine("###################################################");
                        break;
                    case 3:
                        // Creating Instance of Class FindMaxString
                        FindMaxString objFindMaxString = new FindMaxString();

                        // printing Max String Value AMong Three
                        Console.WriteLine("Maximum String Value = {0}", objFindMaxString.FindMaxAmongString("Ram","Shyam","Dane"));

                        Console.WriteLine("Maximum String Value = {0}", objFindMaxString.FindMaxAmongString("Shyam", "Dane", "Ram"));

                        Console.WriteLine("Maximum String Value = {0}", objFindMaxString.FindMaxAmongString("Dane", "Shyam", "Ram"));

                        Console.WriteLine("###################################################");
                        break;
                    case 4:
                        // Creating Instance of class FindMaxGenericsMethod
                        FindMaxGenericsMethod objFindMaxGenericsMethod = new FindMaxGenericsMethod();

                        // for integer value
                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxGenericsMethod.FindMaxGeneric(30, 20, 10));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxGenericsMethod.FindMaxGeneric(10, 30, 20));

                        Console.WriteLine("Maximum Integer Number = {0}", objFindMaxGenericsMethod.FindMaxGeneric(10, 20, 30));
                        Console.WriteLine("###################################################");


                        // for Float Value
                        Console.WriteLine("Maximum Float Number = {0}", objFindMaxGenericsMethod.FindMaxGeneric(3.1f, 2.1f, 1.1f));

                        Console.WriteLine("Maximum Float Number = {0}", objFindMaxGenericsMethod.FindMaxGeneric(1.1f, 3.1f, 2.1f));

                        Console.WriteLine("Maximum Float Number = {0}", objFindMaxGenericsMethod.FindMaxGeneric(1.1f, 2.1f, 3.1f));
                        Console.WriteLine("###################################################");



                        // for String Value
                        Console.WriteLine("Maximum String Value = {0}", objFindMaxGenericsMethod.FindMaxGeneric("Ram", "Shyam", "Dane"));

                        Console.WriteLine("Maximum String Value = {0}", objFindMaxGenericsMethod.FindMaxGeneric("Shyam", "Dane", "Ram"));

                        Console.WriteLine("Maximum String Value = {0}", objFindMaxGenericsMethod.FindMaxGeneric("Dane", "Shyam", "Ram"));

                        break;

                    case 5:

                        // for Integer Value
                        FindMaxGenricClass<int> objMaxInt =new FindMaxGenricClass<int>(10,20,30);
                        Console.WriteLine("Maximum Integer Value ={0}", objMaxInt.TestMaxValue());
                        Console.WriteLine("###################################################");

                        // For Float Value
                        FindMaxGenricClass<float> objMaxFloat = new FindMaxGenricClass<float>(10.1f, 20.2f, 30.3f);
                        Console.WriteLine("Maximum Float value ={0}", objMaxFloat.TestMaxValue());
                        Console.WriteLine("###################################################");

                        // For String Value
                        FindMaxGenricClass<string> objMaxString = new FindMaxGenricClass<string>("Ram", "Shyam", "Dane");
                        Console.WriteLine("Maximum String Value ={0}",objMaxString.TestMaxValue());
                        Console.WriteLine("###################################################");
                        break;
                        
                }
            } while(Choice !=0);

            //TO Hold OutPut Terminal
            Console.ReadKey();
        }
    }
}