/* This is the program in C# that will help us to learn better.
 * You can try this at home.
 */
using System;
using System.Linq;

namespace FirstPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables  - type variable_name = value;
            /*int age = 25;
            double balance = 5000;
            char marriagestatus = 'M';
            string name = "Ram Prasad Chauhan";
            bool isVeg = false;


            //This is the main program
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Persona Details");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("MarriageStatus: " + marriagestatus);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Veg: " + isVeg);

            */


            //TypeCasting
            /* int value = 10;
             double doubleValue = value;

             double mydouble = 10.98;
             int newvalue = (int) mydouble;
            

            int a = 10;
            double b = 5.23;
            bool myvalue = true;


            Console.WriteLine(Convert.ToString(a));
            Console.WriteLine(Convert.ToDouble(a));
            Console.WriteLine(Convert.ToInt32(b));
            Console.WriteLine(Convert.ToString(myvalue));
            */


            //User Input  
            /*  Console.WriteLine("Enter your Name: ");

              string name = Console.ReadLine();

              Console.WriteLine("Enter your age: ");

              int age = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Name is " + name);
              Console.WriteLine("Age is " + age);

              */


            //Operators
            /*int a= 5, b = 10;
            int result;

            result=(a > b)? a : b;

            result = a + b;
            result = a + = 5;
            result = a - b;
            result = a * b;
            result = a % b;
            result = a *= b;
            result = a < b;
            result = a >= b;
            result = a && b;
            result = a || b;
            result = a + b;
            result = a + b;
            result = a + b;
            result = a + b;
    

            Console.WriteLine("Result is " + result);
            */

            //Math Functions
            /*    int x = Math.Min(100, 50);

                Console.WriteLine("Minimum Value is " + x);

                //Math.Max(x,y)
                //Math.sqrt(x);

                */

            //Strings
            /*  string hello = "Hello Beautiful People";
              string how = " How are you ?";
              //string gretting = hello + how;
              string gretting = string.Concat(hello, how);
              string news = "There\'s new \"delta varitaion\" of Corona virus.";

              string fName = "Dipendra";
              string lName = "Thakuri";
              string welcome = $"Hello, {fName} {lName} Welcome to the club.";


              Console.WriteLine(hello);
              Console.WriteLine("The length of the hello string is: " + hello.Length );
              Console.WriteLine("UPPERCASE: " + hello.ToUpper());
              Console.WriteLine("LOWERCASE: " + hello.ToLower());
              Console.WriteLine(gretting);
              Console.WriteLine(welcome);

              //String Access
              Console.WriteLine(hello[9]);
              Console.WriteLine(hello.IndexOf("u"));

              //Substring
              int pos = hello.IndexOf("B");
              String newhello = hello.Substring(pos);

              Console.WriteLine(newhello);
              Console.WriteLine(news);


              // x= 10, y =5 result = x+y = 10+5 = 15  //summation
              // x= "10" y ="5" result = x+y = 10+5 = 105 // concatenation

              */


            //Boolean
            /*
            bool isMale = false;
            bool isWednesday = true;
            int x = 10;
            int y = 5;

            Console.WriteLine(isMale);
            Console.WriteLine(isWednesday);
            Console.WriteLine(x>y);

            */


            //If-else  (Conditional Statements) : if, if-else, else-if switch 
            /*  int x = 10;
              int y = 5;

              if (x > y)
              {
                  Console.WriteLine("10 is greater than 5");
              }


              //if-else
              if (x > y)
              {
                  Console.WriteLine("10 is greater than 5");
              }
              else
              {
                  Console.WriteLine("5 is greater than 10");
              }

              //else if
              int time = 12;

              if (time <12 )
              {
                  Console.WriteLine("Good Morning");
              }
              else if (time == 12)
              {
                  Console.WriteLine("Good noon");
              }
              else if (time < 16)
              {
                  Console.WriteLine("Good afernoon");
              }
              else if (time < 20)
              {
                  Console.WriteLine("Good evening");
              }
              else
              {
                  Console.WriteLine("Good night");
              }

              //ternary operator
              */

            //Switch Statement
            /* int day = 2;
             switch (day)
             {
                 case 1:
                     Console.WriteLine("Sunday");
                     break;
                 case 2:
                     Console.WriteLine("Monday");
                     break;
                 case 3:
                     Console.WriteLine("Tuesday");
                     break;
                 case 4:
                     Console.WriteLine("Wednesday");
                     break;
                 case 5:
                     Console.WriteLine("Thursday");
                     break;
                 case 6:
                     Console.WriteLine("Friday");
                     break;
                 case 7:
                     Console.WriteLine("Saturday");
                     break;
                 default:
                     Console.WriteLine("Please enter the correct data");
                     break;
             }

             */

            //Loop
            //while
            /* int num = 0; 

             while (num < 5)
             {
                 Console.WriteLine(num);
                 num++;
             }

             //Do/While
             int num = 0;
             do
             {
                 Console.WriteLine(num);
                 num++;
             } while (num < 5);
              

            //for loop
            for (int num =0; num<5; num++)
            {
                Console.WriteLine(num);
            }
         

            //foreach loop
            string[] fruits = { "Banana", "Mango", "Apple", "Grapes", "Pear" };
            foreach(string num in fruits)
            {
                Console.WriteLine(num);
            }

            

            for(int i=0; i<10; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("I'm out");
             

            for(int i=0; i<10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("|I'm out");
            */

            //Arrays
            /* string[] fruits = { "Banana", "Mango", "Apple", "Grapes", "Pear" };

             //Accessing individual element
             Console.WriteLine(fruits[0]);
             Console.WriteLine(fruits[1]);
             Console.WriteLine(fruits[2]);
             Console.WriteLine(fruits[3]);
             Console.WriteLine(fruits[4]);

             //Changing value of specific elements.
             fruits[2] = "Gauva";

             Console.WriteLine(fruits[2]);
             Console.WriteLine("\n");

             for(int i=0; i<fruits.Length; i++)
             {
                 Console.WriteLine(fruits[i]);
             }


            int[] numbers = { 4, 2, 5, 1, 7, 8, 9, 6, 10 };

            Console.WriteLine("Before Sorting\n");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nAfter Sorting\n");
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
          

            //Linq
            int[] numbers = { 4, 2, 5, 1, 7, 8, 9, 6, 10 };

            int max = numbers.Max();
            int min = numbers.Min();
            int sum = numbers.Sum();

            Console.WriteLine("\nMaximum Value" + max);
            Console.WriteLine("\nMinimum Value\n" + min);
            Console.WriteLine("\nSummation of Numbers\n" + sum);
           

            string fruits = new string[4];

            string fruits2 = new string[4] { "Apple", "Mango", "Banana", "Grapes" };

            string[] fruits3 = new string[] { "Apple", "Mango", "Banana", "Grapes" };

            string[] fruits4 = { "Apple", "Mango", "Banana", "Grapes" };
            */

            //Menu Choice using the customer input
            Console.WriteLine("============Welocme to ABC Bank==============");
            Console.WriteLine("==============MENU==========================");
            Console.WriteLine("1. Fast Cash");
            Console.WriteLine("2. Cash Withdraw");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("=====FAST CASH======");
                    Console.WriteLine("1. 500");
                    Console.WriteLine("2. 1000");
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:
                            Console.WriteLine("You have successfully withdrawn 500. \n Please collect your money.");
                            break;
                        case 2:
                            Console.WriteLine("You have successfully withdrawn 1000. \n Please collect your money.");
                            break;
                        default:
                            Console.WriteLine("Please choose the option in the menu");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("========CASH WITHDRAW=========");
                    Console.WriteLine("Enter the Cash (in multiple of 500): ");
                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    /*if (choice3 % 500 == 0)
                    {
                        Console.WriteLine($"You have successfully withdrawn {choice3}. \n Please collect your money.");
                    }
                    else
                    {
                        Console.WriteLine("Please enter the money in the multiple of 500");
                    }
                    */
                  string statement = (choice3 % 500 == 0) ? $"You have successfully withdrawn {choice3}. \n Please collect your money" : "Please enter the money in the multiple of 500";
                    Console.WriteLine(statement);
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }
            Console.WriteLine("Thank you for doing banking with us");




            Console.ReadLine();  // It will hold the console until a button is pressed.
        }
    }
}
