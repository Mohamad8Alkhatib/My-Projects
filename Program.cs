using System;

namespace switche_test
{
    class Program
    {
        static int input_int()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static double input_double()
        {
            double y = Convert.ToDouble(Console.ReadLine());
            return y;
        }
        static void enter_numbers()
        {
            Console.WriteLine("Enter two numbers:");
        }
        static int min(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
        static int sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int multi(int a, int b)
        {
            int result = a * b;
            return result;
        }
        static double Div(double a, double b)
        {
            double result = a / b;
            return result;
        }
        static int average(int a, int b)
        {
            int x = sum(a, b);
            int result = x / 2;
            return result;
        }
        static void sqrt(double x)
        {
            Console.WriteLine(Math.Sqrt(x));
        }
        static double Percentage(double x, double y)
        {
            double z = (x * y) / 100;
            return z;
        }
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("Enter number from 1 to 8 :" +
                    "\n1: for sum two numbers" +
                    "\n2: for minus two numbers" +
                    "\n3: for multiply two numbers" +
                    "\n4: for div two numbers" +
                    "\n5: for even or odd" +
                    "\n6: for average of two numbers" +
                    "\n7: for square of two numbers" +
                    "\n8: for rise a number to a power" +
                    "\n9: for %" +
                    "\n10: for primary or not primary" +
                    "\n11: for logout");
                int choice = input_int();
                switch (choice)
                {
                    case 1:
                        {
                            enter_numbers();
                            int num1 = input_int();
                            int num2 = input_int();
                            int result = sum(num1, num2);
                            Console.WriteLine($"sum is:\n{num1} + {num2} = {result}");
                            break;
                        }
                    case 2:
                        {
                            enter_numbers();
                            int num1 = input_int();
                            int num2 = input_int();
                            int result = min(num1, num2);
                            if (num1 > num2)
                            {
                                Console.WriteLine($"result is:\n{num1}-{num2}={result}");
                            }
                            else
                            {
                                Console.WriteLine($"result is:\n{num2}-{num1}={result}");
                            }
                            break;
                        }
                    case 3:
                        {
                            enter_numbers();
                            int num1 = input_int();
                            int num2 = input_int();
                            int result = multi(num1, num2);
                            Console.WriteLine($"result is:\n{num1}*{num2}={result}");
                            break;
                        }
                    case 4:
                        {
                            enter_numbers();
                            double number1, number2;
                            number1 = input_double();
                            number2 = input_double();
                            while (number2 == 0)
                            {
                                Console.WriteLine("Please enter another number:");
                                number2 = Convert.ToDouble(Console.ReadLine());
                            }
                            double result = Div(number1, number2);
                            Console.WriteLine($"Result is:\n{number1}/{number2}={result}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter a number please :");
                            int num = input_int();
                            if (num % 2 == 0)
                            {
                                Console.WriteLine("The number is even.");
                            }
                            else
                            {
                                Console.WriteLine("The number is odd.");
                            }
                            break;
                        }
                    case 6:
                        {
                            enter_numbers();
                            int num1 = input_int();
                            int num2 = input_int();
                            int result = average(num1, num2);
                            Console.WriteLine($"average={result}");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter a number :");
                            double num = input_double();
                            while (num < 0)
                            {
                                Console.WriteLine("Enter a number larger then 0");
                            }
                            Console.Write("Square of the number = ");
                            sqrt(num);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Enter the number and the power");
                            double num = input_int();
                            int power = input_int();
                            //for عن طريق حلقة Math.Sqrt للحل بدون دالة 
                            /* double result = 1;
                            bool IsNegative = false;
                            if (power < 0)
                            {
                                IsNegative = true;
                                power = -power;
                            }
                            for(int i=0; i < power; i++)
                            {
                                result *= num;
                            }
                            if (IsNegative)
                            {
                                result = 1.0 / result;
                            }*/
                            double result = Math.Pow(num, power);
                            Console.WriteLine($"Result = {result}");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Enter full value and the percentage :");
                            double fullValue = input_double();
                            double percentage = input_double();
                            double result = Percentage(fullValue, percentage);
                            Console.WriteLine($"percentage = {result}");
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Enter a number :");
                            int x = input_int();
                            if (x <= 1)
                            {
                                Console.WriteLine("The number isn't primary.");
                            }
                            bool isPrime = true;
                            for (int i = 2; i < x; i++)
                            {
                                if (x % i == 0)
                                {
                                    isPrime = false;
                                }
                            }
                            if (isPrime)
                                Console.WriteLine("The number is primary.");
                            else
                                Console.WriteLine("The number isn't primary.");
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("Thank you for using our program.");
                            continueProgram = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option, Please try again");
                        break;
                }
                if (continueProgram)
                {
                    Console.WriteLine("Do you want to do anothor operaition?(1 to continue 2 to close.)");
                    int response = input_int();
                    if (response != 1)
                    {
                        continueProgram = false;
                        Console.WriteLine("Good bye");
                    }
                }
            }
        }
    }
}
