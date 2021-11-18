//using System;
//using static System.Console;

//namespace Method
//{
//    class Calculator
//    {
//        public static int Plus(int a,int b)
//        {
//            return a + b;
//        }
//        public static int Minus(int a,int b)
//        {
//            return a - b;
//        }
//    }
//    class MainApp
//    {
//        public static void Main()
//        {
//            int result = Calculator.Plus(3, 4);
//            WriteLine(result);

//            result = Calculator.Minus(5, 2);
//            WriteLine(result);
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Return
//{
//    class MainApp
//    {
//        static int Fibonacci(int n)
//        {
//            if (n < 2)
//            {
//                return n;
//            }
//            else
//                return Fibonacci(n - 1) + Fibonacci(n - 2);
//        }

//        static void PrintProfile(string name, string phone)
//        {
//            if (name=="")
//            {
//                WriteLine("이름을 입력해 주세요.");
//                return;
//            }
//            WriteLine($"Name :{name}, Phone:{phone}");
//        }

//        static void Main()
//        {
//            WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");

//            PrintProfile("", "123 - 4567");
//            PrintProfile("한기운", "456-1230");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace SwapByValue
//{
//    class MainApp
//    {
//        public static void Swap(ref int a,ref int b)
//        {
//            int temp = b;
//            b = a;
//            a = temp;
//        }

//        static void Main()
//        {
//            int x = 3;
//            int y = 4;

//            WriteLine($"{x},{y}");

//            Swap(ref x,ref y);

//            WriteLine($"{x},{y}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace RefReturn
//{
//    class Product
//    {
//        private int price = 100;

//        public ref int GetPrice()
//        {
//            return ref price;
//        }

//        public void PrintPrice()
//        {
//            WriteLine($"Price : {price}");
//        }
//    }

//    class MainApp
//    {
//        static void Main()
//        {
//            Product carrot = new Product();
//            ref int ref_local_price = ref carrot.GetPrice();
//            int normal_local_price = carrot.GetPrice();

//            carrot.PrintPrice();
//            WriteLine($"Ref Local Price : {ref_local_price}");
//            WriteLine($"Normal Lacal Price : {normal_local_price}");

//            ref_local_price = 200;

//            carrot.PrintPrice();
//            WriteLine($"Ref Local Price : {ref_local_price}");
//            WriteLine($"Normal Lacal Price : {normal_local_price}");
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace UsingOut
//{
//    class MainApp
//    {
//        static void Divide(int a,int b, out int quotient,out int remainder)
//        {
//            quotient = a / b;
//            remainder = a % b;
//        }

//        static void Main()
//        {
//            int a = 20;
//            int b = 3;

//            Divide(a, b, out int c, out int d);

//            WriteLine($"a:{a}, b:{b}: a/b:{c}, a%b:{d}");
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Overloading
//{
//    class MainApp
//    {
//        static int Plus(int a, int b)
//        {
//            WriteLine("Calling Int Plus(int,int)...");
//            return a + b;
//        }
//        static int Plus(int a, int b, int c)
//        {
//            WriteLine("Calling Int Plus(int,int,int)...");
//            return a + b + c;
//        }

//        static double Plus(double a, double b)
//        {
//            WriteLine("Calling Double Plus(double,double)...");
//            return a + b;
//        }

//        static double Plus(int a, double b)
//        {
//            WriteLine("Calling Double Plus(int,double)...");
//            return a + b;
//        }

//        static void Main()
//        {
//            WriteLine(Plus(1, 2));
//            WriteLine(Plus(1, 2,3));
//            WriteLine(Plus(1.0,2.4 ));
//            WriteLine(Plus(1, 2.7));
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace UsingParams
//{
//    class MainApp
//    {
//        static int Sum(params int[] args)
//        {
//            Write("Summing....");
//            int sum = 0;
//            for (int i = 0; i < args.Length; i++)
//            {
//                if (i > 0)
//                {
//                    Write(", ");
//                }
//                Write($"{args[i]}");
//                sum += args[i];
//            }
//            WriteLine();
//            return sum;
//        }

//        static void Main()
//        {
//            int sum = Sum(2, 3, 4, 5, 6, 7, 10);

//            WriteLine($"Sum:{sum}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace OptionalParameter
//{
//    class MainApp
//    {
//        static void PrintProfile(string name, string phone = "")
//        {
//            WriteLine($"Name: {name}, Phone: {phone}");
//        }

//        static void Main()
//        {
//            PrintProfile("중근");
//            PrintProfile("관순", "010-123-1234");
//            PrintProfile(phone: "010-345-3593", name: "동주");
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace LocalFunction
//{
//    class MainApp
//    {
//        static string ToLowerString(string input)
//        {
//            var arr = input.ToCharArray();
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = ToLowerChar(i);
//            }

//            char ToLowerChar(int i)
//            {
//                if (arr[i] < 65 || arr[i] > 90)
//                {
//                    return arr[i];
//                }
//                else
//                    return (char)(arr[i] + 32);
//            }

//            return new string(arr);
//        }
//        static void Main()
//        {
//            WriteLine(ToLowerString("Hello!"));
//            WriteLine(ToLowerString("Good Morning."));
//            WriteLine(ToLowerString("This is C#."));
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Ex6_1
//{
//    class MainApp
//    {
//        static int Square(int a)
//        {
//            return a * a;
//        }
//        static double Square(double a)
//        {
//            return a * a;
//        }

//        static void Main()
//        {
//            Write("수를 입력하시오: ");
//            string input = ReadLine();
//            double arg = Convert.ToDouble(input);
//            WriteLine($"결과: {Square(arg)}");
//        }
//    }
//}

using System;
using static System.Console;

namespace Ex6_3
{
    class MainApp
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            WriteLine($"{a} + {b} = {resultA}");

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            WriteLine($"{x} + {y} = {resultB}");

        }
        
        public static void Plus(int a,int b,out int c)
        {
            c = a + b;
        }
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}