using System;

namespace cs_into1a
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statements check if something is true
            // if it is, then it executes the code inside of the curly braces
            // ex:

            // if (this variable is true) {
            //     then execute this code
            // }

            // if else statements execute one branch out of two branches
            // ex:

            // if (this variable is true) {
            //     then execute this code
            // } if the variable is anything else {
            //     then execute this code
            // }

            // if/else statements can execute one branch out of many
            // ex:

            // if (this variable is true) {
            //     then execute this code
            // } (otherwise if this variable is true) {
            //     then execute this code
            // } (otherwise if this variable is true) {
            //     then execute this code
            // } if the variable is anything else {
            //     then execute this code
            // }

            bool lightSwitch = true;
            if (lightSwitch)
            {
                Console.WriteLine("light is on!");
            } else
            {
                Console.WriteLine("light is off!");
            }

            int secretNumber = 9;
            if (secretNumber == 2)
            {
                Console.WriteLine("Secret number found");
            } else if (secretNumber == 9)
            {
                Console.WriteLine("Secret number found");
            } else if (secretNumber == 1)
            {
                Console.WriteLine("Secret number found");
            } else
            {
                Console.WriteLine("No secret number found");
            }

            // Conditional statements

            if (lightSwitch)
            {
                // execute if true
                lightSwitch = false;
                Console.WriteLine("Light switch is on, turning off now...");
            }

            if (lightSwitch == true)
            {
                lightSwitch = false;
                Console.WriteLine("Light on");
            } else
            {
                Console.WriteLine("Light is off");
            }

            // else if statement

            int sNumber = 12;

            if (sNumber == 3)
            {
                Console.WriteLine("number found!");
            } else if (sNumber == 12)
            {
                Console.WriteLine("number found!");
            } else
            {
                Console.WriteLine("number not found!");
            }

            // switch statement
            string firstName = "Ben";

            switch (firstName)
            {
                case "Carlos":
                    Console.WriteLine("Carlos found");
                    break;
                case "Antoine":
                    Console.WriteLine("Antoine found");
                    break;
                case "Ben":
                    Console.WriteLine("Ben is a ghost, you cannot find him!");
                    break;
                default:
                    Console.WriteLine("Nobody found");
                    break;
            }

            string[] groceryList = { "eggs", "milk", "chicken", "pickles" };
            Console.WriteLine(groceryList[3]);

            foreach(string item in groceryList)
            {
                // this will loop 4 times
                Console.WriteLine(item);
            }

            int[] numList = { 3, 7, 2, 1, 0 };
            foreach(int i in numList)
            {
                var newNum = i + 25;
                Console.WriteLine(newNum);
            }

            for (int i = 0; i < groceryList.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(groceryList[i]);
            }

            foreach(string i in groceryList)
            {
                if(i == "pickles")
                {
                    Console.WriteLine("eat pickles");
                } else
                {
                    Console.WriteLine("regular item");
                }
            }
        }
    }   
}
