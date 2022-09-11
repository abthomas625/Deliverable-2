using System;

class Program
{
  public static void Main(string[] args)
    {
        int numberTea = 0;
        int numberWater = 0;

        Console.WriteLine("Welcome to the buffet! All you can eat $9.99 Drinks are not included in the buffet price. How many are we serving today? We can only accept groups of 6 or fewer.");
        int people = int.Parse(Console.ReadLine());

        if (people <= 6)
        {
            Console.WriteLine("{0}A table for {1}! Please follow me, and I'll show you to your seat. {2}What would you like to drink? We offer water or tea.",

                Environment.NewLine,
                people,
                Environment.NewLine);

            for (int i = 1; i <= people; i++)
            {

                Console.WriteLine("{0}Person Number {1}, water or tea?",

                    Environment.NewLine,
                    i);

                string choice = Console.ReadLine();

                if (choice == "water")
                {
                    Console.WriteLine("Water, excellent!");
                    numberWater = numberWater + 1;
                }

                else
                {

                    if (choice == "tea")
                    {
                        Console.WriteLine("Tea! Very good!");
                        numberTea = numberTea + 1;
                    }

                    else
                    {
                        Console.WriteLine("That is unavailable. Sorry");
                    }
                }
            }
            Console.WriteLine("{0}Okay, so that will be {1} water(s) and {2} tea(s). I'll go get those. Please, feel free to grab your food!",

                Environment.NewLine,
                numberWater, numberTea);

            decimal food = people * 9.99m;
            decimal tea = numberTea * 2.00m;
            decimal total = food + tea;

            Console.WriteLine("{0}Here is your bill. Total price: ${1}",

                Environment.NewLine, total);
        }

        else
        {
            Console.WriteLine("Sorry. We can only accept parties with 6 or fewer members. Have a nice day!");
        }

    }
}