using System;
using System.Collections.Generic;
using classes;

namespace myTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // # tutorial practice loop
            // # Description: if else
            // int a = 5;
            // int b = 3;
            // if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            // }

            // int c = 4;
            // if ((a + b + c > 10) && (a > b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("And the first number is greater than the second");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("Or the first number is not greater than the second");
            // }

            // if ((a + b + c > 10) || (a > b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("Or the first number is greater than the second");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("And the first number is not greater than the second");
            // }


            // # tutorial practice loop
            // # Description: nested for
            // for (int row = 1; row < 11; row++)
            // {
            //      for (char column = 'a'; column < 'k'; column++)
            //     {
            //         Console.WriteLine($"The cell is ({row}, {column})");
            //     }
            // }



            // # tutorial practice loop
            // # Description: create liststring
            // var names = new List<string> {"sharie","Ana","Felipe"};
            // foreach (var name in names)
            // {
            //     Console.WriteLine($"Hello {name.ToUpper()}!");
            // }
            // Console.WriteLine();
            // names.Add("Maria");
            // names.Add("Bill");
            // names.Remove("Ana");
            // foreach (var name in names)
            // {
            // Console.WriteLine($"Hello {name.ToUpper()}!");
            // }
            // Console.WriteLine($"My name is {names[0]}.");
            // Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            // Console.WriteLine($"The list has {names.Count} people in it");
            // var index = names.IndexOf("Felipe");
            // if (index != -1)
            // Console.WriteLine($"The name {names[index]} is at index {index}");

            // var notFound = names.IndexOf("Not Found");
            // Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            // names.Sort();
            // foreach (var name in names)
            // {
            // Console.WriteLine($"Hello {name.ToUpper()}!");
            // }


            // # tutorial practice loop
            // # Description: create listint fibonacci
            // var fibonacciNumbers = new List<int> {1,1};
            // while (fibonacciNumbers.Count < 20)
            // {
            //     var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //     var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //     fibonacciNumbers.Add(previous + previous2);
            // }

            // foreach(var item in fibonacciNumbers)
            // {
            //     Console.WriteLine(item);
            // }


            // # tutorial practice class
            // # Description: create bank account
        var account = new BankAccount("sharie", 1000);
        var account2 = new BankAccount("sharie2", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
        Console.WriteLine(account.Balance);
        account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
        Console.WriteLine(account.Balance);
        // Test for a negative balance.
        try
        {
            account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Exception caught trying to overdraw");
            Console.WriteLine(e.ToString());
        }

      
    }
}}
