using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Inlämningsuppgift_1___Jangerud
{
    class Program
    {

        static void Main(string[] args)
        {
            bool runProgram = true;
            List<int> sumList = new List<int>();
            var sum = 0;

            while (runProgram)
            {

                //Starten av programmet!

                Console.WriteLine("Enter first operator: ");
                string firstOp = Console.ReadLine();

                Console.WriteLine("Enter second operator: ");
                string secondOp = Console.ReadLine();

                Console.WriteLine("Enter first number: ");
                int.TryParse(Console.ReadLine(), out int firstNum);

                Console.WriteLine("Enter second number: ");
                int.TryParse(Console.ReadLine(), out int secondNum);

                Console.WriteLine("Enter third number: ");
                int.TryParse(Console.ReadLine(), out int thirdNum);


                // Början av uträkningarna samt sparandet av resultatet från de olika uträkningarna beroende av vilken operator som skrivs in.

                switch (firstOp)
                {
                    //Så länge som första operatorn är * så sker första caset. Sedan tittar den värdet på andra operatorn.
                    case "*":
                        if (secondOp == "+")
                        {
                            sum = ((firstNum * secondNum) + thirdNum);
                            Console.WriteLine($"{firstNum} * {secondNum} + {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }else if (secondOp == "-")
                        {
                            sum = ((firstNum * secondNum) - thirdNum);
                            Console.WriteLine($"{firstNum} * {secondNum} - {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }else if (secondOp == "*")
                        {
                            sum = (firstNum * secondNum * thirdNum);
                            Console.WriteLine($"{firstNum} * {secondNum} * {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else
                        {
                            sum = ((firstNum * secondNum) / thirdNum);
                            Console.WriteLine($"{firstNum} * {secondNum} / {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        break;

                    //Så länge som första operatorn är / så sker det här. Sedan tittar den värdet på andra operatorn.
                    case "/":
                        if (secondOp == "+")
                        {
                            sum = ((firstNum / secondNum) + thirdNum);
                            Console.WriteLine($"{firstNum} / {secondNum} + {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else if (secondOp == "-")
                        {
                            sum = ((firstNum / secondNum) - thirdNum);
                            Console.WriteLine($"{firstNum} / {secondNum} - {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else if (secondOp == "*")
                        {
                            sum = (firstNum / (secondNum * thirdNum));
                            Console.WriteLine($"{firstNum} / {secondNum} * {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else
                        {
                            sum = (firstNum / secondNum / thirdNum);
                            Console.WriteLine($"{firstNum} / {secondNum} / {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        break;

                    //Så länge som första operatorn är + så sker det här. Sedan tittar den värdet på andra operatorn.
                    case "+":
                        if (secondOp == "+")
                        {
                            sum = (firstNum + secondNum + thirdNum);
                            Console.WriteLine($"{firstNum} + {secondNum} + {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else if (secondOp == "-")
                        {
                            sum = (firstNum + secondNum - thirdNum);
                            Console.WriteLine($"{firstNum} + {secondNum} - {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else if (secondOp == "*")
                        {
                            sum = (firstNum + (secondNum * thirdNum));
                            Console.WriteLine($"{firstNum} + {secondNum} * {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else
                        {
                            sum = (firstNum + (secondNum / thirdNum));
                            Console.WriteLine($"{firstNum} + {secondNum} / {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        break;

                    //Så länge som första operatorn är - så sker det här caset. Sedan tittar den värdet på andra operatorn.
                    case "-":
                        if (secondOp == "+")
                        {
                            sum = (firstNum - secondNum + thirdNum);
                            Console.WriteLine($"{firstNum} - {secondNum} + {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else if (secondOp == "-")
                        {
                            sum = (firstNum - secondNum - thirdNum);
                            Console.WriteLine($"{firstNum} - {secondNum} - {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else if (secondOp == "*")
                        {
                            sum = (firstNum - (secondNum * thirdNum));
                            Console.WriteLine($"{firstNum} - {secondNum} * {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        else
                        {
                            sum = (firstNum - (secondNum / thirdNum));
                            Console.WriteLine($"{firstNum} - {secondNum} / {thirdNum} = {sum}");
                            sumList.Add(sum);

                        }
                        break;

                    //Här vill jag var ärlig med att jag inte riktigt visste vad jag skulle göra i default så blev en lite onödig utskrift kanske.
                    default:
                        Console.WriteLine("Try again");
                        break;

                }

                /*Här kommer checken av resultatet ifall det är 100 eller över/under.
                 * 
                 * 
                 */
                if (sum < 100)
                {
                    Console.WriteLine("The sum is less than a hundred!");

                    Console.WriteLine("Do you want to continue? y/n");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        runProgram = true;
                    }
                    else if (answer == "n")
                    {
                        //Arbete med att försöka skriva ut en summa av hela arraylistan.
                        sumList.GetType();
                        Console.WriteLine(sumList.GetEnumerator());
                        runProgram = false;
                    }
                }
                else if (sum > 100)
                {
                    Console.WriteLine("The sum is more than a hundred!");

                    Console.WriteLine("Do you want to continue? y/n");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "y")
                    {
                        runProgram = true;
                        Console.Clear();
                    }
                    else if (answer == "n")
                    {
                        //Arbete med att försöka skriva ut en summa av hela arraylistan.
                        int sumOfValues = sumList.Sum();

                        Console.WriteLine("Thank you for playing! The sum of all your rounds are " + sumOfValues + ". Bye!");
                        runProgram = false;

                    }

                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap!");
                    runProgram = false;

                }
            }

        }
    }
}
