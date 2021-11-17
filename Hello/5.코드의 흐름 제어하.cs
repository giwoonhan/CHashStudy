//using System;
//using static System.Console;

//namespace IfElse
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Write("숫자를 입력하세요 :");

//            string input = ReadLine();
//            int number = int.Parse(input);

//            if (number > 0)
//            {
//                WriteLine($"{number}는 양수이다.");
//            }
//            else if (number < 0)
//            {
//                WriteLine($"{number}는 음수이다.");
//            }
//            else
//                WriteLine("0");

//            if (number % 2 == 0)
//            {
//                WriteLine($"{number}는 짝수이다.");
//            }
//            else
//                WriteLine($"{number}는 홀수이다.");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Switch
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Write("요일을 입력하세요.(일,월,화,수,목,금,토) : ");
//            string day = ReadLine();

//            switch (day)
//            {
//                case "일":
//                    WriteLine("Sunday");
//                    break;
//                case "월":
//                    WriteLine("Monday");
//                    break;
//                case "화":
//                    WriteLine("Tuesday");
//                    break;
//                case "수":
//                    WriteLine("Wednesday");
//                    break;
//                case "목":
//                    WriteLine("Thursday");
//                    break;
//                case "금":
//                    WriteLine("Friday");
//                    break;
//                case "토":
//                    WriteLine("Saturday");
//                    break;
//                default:
//                    WriteLine("요일이 아닙니다.다시 입력하시오.");
//                    break;
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Switch2
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            object obj = null;

//            string input = ReadLine();
//            if (int.TryParse(input, out int out_i))
//            {
//                obj = out_i;
//            }
//            else if (float.TryParse(input, out float out_f))
//            {
//                obj = out_f;
//            }
//            else
//                obj = input;

//            switch (obj)
//            {
//                case int i:
//                    WriteLine($"{i}는 int 형식입니다.");
//                    break;
//                case float f:
//                    WriteLine($"{f}는 float형식입니다.");
//                    break;
//                default:
//                    break;
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace SwitchExp
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("점수를 입력하시오 : ");
//            int score = int.Parse(ReadLine());

//            WriteLine("재수강인가요? Y/N");
//            bool repeated = ReadLine() == "Y" ? true : false;
//            string grade = "";

//            switch (score/10)
//            {
//                case 9:
//                    grade = "A";
//                    if (repeated=true)
//                    {
//                        grade = "B";
//                    }
//                    break;
//                case 8:
//                    grade = "B";
//                    break;
//                case 7:
//                    grade = "C";
//                    break;
//                case 6:
//                    grade = "D";
//                    break;
//                default:
//                    grade = "F";
//                    break;
//            }
//            WriteLine($"당신의 학점은 {grade}입니다.");
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace While
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int i = 10;

//            while (i>0)
//            {
//                WriteLine($"i : {i--}");
//            }

//        }
//    }
//}

//using System;
//using static System.Console;

//namespace DoWhile
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int i = 10;
//            do
//            {
//                WriteLine($"a) i : {i--}");
//            }
//            while (i > 0);

//            do
//            {
//                WriteLine($"b) i : {i--}");
//            } while (i>0);
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace For
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                WriteLine(i);
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace ForFor
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    Write("*");
//                }
//                WriteLine();
//            }
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Foreach
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[] { 0, 1, 2, 3, 4 };

//            foreach (int a in arr)
//            {
//                WriteLine(a);
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Break
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                WriteLine("계속할까요?(예/아니오) : ");
//                string answer = ReadLine();

//                if (answer=="아니오")
//                {
//                    break;
//                }
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Continue
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                if (i%2==1)
//                {
//                    WriteLine($"{i}는 홀수");
//                }
//                else
//                {
//                    continue;
//                }
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Practice2
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 5; i > 0; i--)
//            {
//                for (int j = 0; j < i; j++)
//                {
//                    Write("*");
//                }
//                WriteLine();
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Pratice3_1
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int i = 0, j = 0;
//            while (i<5)
//            {
//                while (j<=i)
//                {
//                    Write("*");
//                    j++;
//                }
//                WriteLine();
//                j = 0;
//                i++;
//            }
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Pratice3_2
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int i = 5, j = 0;
//            while (i>0)
//            {
//                while (j<i)
//                {
//                    Write("*");
//                    j++;
//                }
//                WriteLine();
//                j = 0;
//                i--;
//            }
//        }
//    }
//}

using System;
using static System.Console;

namespace Practice4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Write("반복 횟수를 입렵하시오.");
            int repeated = int.Parse(ReadLine());
            if (repeated<=0)
            {
                WriteLine("0보다 같거나 작은 숫자는 사용할 수 없습니다.");
                return;
            }
            else
            {
                for (int i = 0; i < repeated; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Write("*");
                    }
                    WriteLine();
                }
            }
        }
    }
}