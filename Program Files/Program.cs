/* This is the program in C# that will help us to learn better.
 * You can try this at home.
 */
using System;

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
            int day = 2;
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

            Console.ReadLine();  // It will hold the console until a button is pressed.
        }
    }
}
