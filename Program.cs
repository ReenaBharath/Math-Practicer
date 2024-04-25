using System;

namespace Math_Practicer
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Welcome To My Project");
            Console.WriteLine("------------------------");
            Console.WriteLine("Let's Start!");


            bool exit = false;
            while (!exit)

            {
                Console.WriteLine("Welcome to My Calculator\n" + "Type \"exit\" to exit\n");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Addition ");
                Console.WriteLine("2. Subtraction ");
                Console.WriteLine("3. Multiplication ");
                Console.WriteLine("4. Division ");
                Console.WriteLine("5. Average ");
                Console.WriteLine("6. Power");
                Console.WriteLine("7. Squareroot");
                Console.WriteLine("8. Cuberoot");
                Console.WriteLine("9. Maximum of two numbers");
                Console.WriteLine("10. Minimum of two numbers");
                Console.WriteLine("11. Exit ");
                Console.WriteLine("12. Select your choice (1-11): ");
                int ch = Int32.Parse(Console.ReadLine());


                ConsoleKeyInfo playAgain;
                switch (ch)
                {
                    case 1:
                        Console.Write("Enter A Number:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Anoter Number:");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("Sum = {0}", c);

                        break;

                    case 2:
                        Console.Write("Enter A Number:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Anoter Number:");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine("Difference = {0}", c);
                        break;

                    case 3:
                        Console.Write("Enter A Number:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Anoter Number:");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine("Product = {0}", c);
                        break;
                    case 4:
                        Console.Write("Enter A Number:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Anoter Number:");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine("Quotient = {0}", c);
                        break;
                    case 5:
                        Console.Write("Enter A Number:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Anoter Number:");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = (a + b) / 2;
                        Console.WriteLine("Average = {0}", c);
                        break;
                    case 6:
                        Console.WriteLine("Enter A Number");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter A Number");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = (int)Math.Pow(a, b);
                        Console.WriteLine("Power ={0}", c);
                        break;
                    case 7:
                        Console.WriteLine("Enter A Number");
                        a = Convert.ToInt32(Console.ReadLine());
                        c = (int)Math.Sqrt(a);
                        Console.WriteLine("SquareRoot = {0}", c);
                        break;
                    case 8:
                        Console.WriteLine("Enter A Number");
                        a = Convert.ToInt32(Console.ReadLine());
                        c = (int)Math.Cbrt(a);
                        Console.WriteLine("CubeRoot = {0}", c);
                        break;
                    case 9:
                        Console.WriteLine("Enter A Number");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter A Number");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = (int)Math.Max(a, b);
                        Console.WriteLine("Maximum is ={0}", c);
                        break;
                    case 10:
                        Console.WriteLine("Enter A Number");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter A Number");
                        b = Convert.ToInt32(Console.ReadLine());
                        c = (int)Math.Min(a, b);
                        Console.WriteLine("Minimum is ={0}", c);
                        break;
                    case 11:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Click on any Key to Play Again OR click N key to Exit ");
                playAgain = Console.ReadKey();
                if (playAgain.Key == ConsoleKey.Y)
                {

                }
                else if (playAgain.Key == ConsoleKey.N)
                {
                    Console.WriteLine("Goodbye, Thanks for Playing");
                    exit = true;
                }
            }
        }
    }
}
