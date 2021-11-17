//using System;
//using static System.Console;

//namespace Hello
//{
//    class MainApp
//    {
//        // 프로그램 실행이 시작되는 곳
//        static void Main(string[] args)
//        {
//            if (args.Length == 0)
//            {
//                Console.WriteLine("사용법 : Hello.exe <이름>");
//                return;
//            }
//            Console.WriteLine("Hello, {0}!", args[0]); //Hello, World를 프롬프트에 출력
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Hello
//{
//    class MainApp
//    {
//        static void Main()
//        {
//            WriteLine("여러분, 안녕하세요?");
//            WriteLine("반갑습니다!");
//            return;
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace IntegralTypes
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            sbyte a = -10;
//            byte b = 40;

//            WriteLine($"a={a},b={b}");

//            short c = -3_0000;
//            ushort d = 6_0000;

//            WriteLine($"c={c},d={d}");

//            int e = -1000_0000;
//            uint f = 3_0000_0000;

//            WriteLine($"e={e}, f={f}");

//            long g = -5000_0000_0000;
//            ulong h = 200_0000_0000_0000_0000;

//            WriteLine($"g={g},h={h}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace IntegerLiterals
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            byte a = 240;
//            WriteLine($"a={a}");

//            byte b = 0b1111_0000;
//            WriteLine($"b={b}");

//            byte c = 0xF0;
//            WriteLine($"c={c}");

//            uint d = 0x1234_abcd;
//            WriteLine($"d={d}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Overflow
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            uint a = uint.MaxValue;
//            WriteLine(a);
//            a = a + 2;
//            WriteLine(a);

//            int b = int.MinValue;
//            WriteLine(b);
//            b = b - 1;
//            WriteLine(b);
//        }
//    }
//


//using System;
//using static System.Console;

//namespace FloatingPoint
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            float a = 3.1415_9265_3589_7932_3846f;
//            WriteLine(a);
//            double b = 3.1415_9265_3589_7932_3846;
//            WriteLine(b);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Decimal
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
//            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
//            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

//            WriteLine(a);
//            WriteLine(b);
//            WriteLine(c);
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace Char
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            char a = '안';
//            char b = '녕';
//            char c = '하';
//            char d = '세';
//            char e = '요';

//            WriteLine(a);
//            WriteLine(b);
//            WriteLine(c);
//            WriteLine(d);
//            WriteLine(e);
//            WriteLine();
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace String
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string a = "안녕하세요?";
//            string b = "박상현입니다";

//            WriteLine(a);
//            WriteLine(b);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Bool
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            bool a = true;
//            bool b = false;

//            WriteLine(a);
//            WriteLine(b);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Object
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            object a = 123;
//            object b = 3.1415_9265_3589_7932_3846_2643_3832_79m;
//            object c = true;
//            object d = "안녕하세요";

//            WriteLine(a);
//            WriteLine(b);
//            WriteLine(c);
//            WriteLine(d);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace BoxingUnboxing
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int a = 123;
//            object b = (object)a;
//            int c = (int)b;

//            WriteLine(a);
//            WriteLine(b);
//            WriteLine(c);

//            double x = 3.1414213;
//            object y = x;
//            double z = (double)y;

//            WriteLine(x);
//            WriteLine(y);
//            WriteLine(z);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace IntegralConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            sbyte a = 127;
//            WriteLine(a);

//            int b = (int)a;
//            WriteLine(b);

//            int x = 128;
//            WriteLine(x);

//            sbyte y = (sbyte)x;
//            WriteLine(y);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace FloatConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            float a = 69.6875f;
//            WriteLine("a : {0}", a);

//            double b = (double)a;
//            WriteLine("b : {0}", b);
//            WriteLine("69.6875 == b : {0}", 69.6875 == b);

//            float x = 0.1f;
//            WriteLine("x : {0}", x);

//            double y = (double)x;
//            WriteLine("y : {0}", y);

//            WriteLine("0.1 == y : {0}", 0.1 == y);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace SignedUnsignedConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int a = 500;
//            WriteLine(a);

//            uint b = (uint)a;
//            WriteLine(b);

//            int x = -30;
//            WriteLine(x);

//            uint y = (uint)x;
//            WriteLine(y);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace FloatToIntegral
//{
//    class MainAPP
//    {
//        static void Main(string[] args)
//        {
//            float a = 0.9f;
//            int b = (int)a;
//            WriteLine(b);

//            float c = 1.1f;
//            int d = (int)c;
//            WriteLine(d);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace StringNumberConversion
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int a = 123;
//            string b = a.ToString();
//            WriteLine(b);

//            float c = 3.14f;
//            string d = c.ToString();
//            WriteLine(d);

//            string e = "123456";
//            int f = Convert.ToInt32(e);
//            WriteLine(f);

//            string g = "1.2345";
//            float h = float.Parse(g);
//            WriteLine(h);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Constant
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            const int MAX_INT = 2147483647;
//            const int MIN_INT = -2147483648;

//            WriteLine(MAX_INT);
//            WriteLine(MIN_INT);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Enum
//{
//    class MainApp
//    {
//        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
//        static void Main(string[] args)
//        {
//            WriteLine((int)DialogResult.YES);
//            WriteLine((int)DialogResult.NO);
//            WriteLine((int)DialogResult.CANCEL);
//            WriteLine((int)DialogResult.CONFIRM);
//            WriteLine((int)DialogResult.OK);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Enum2
//{
//    class MainApp
//    {
//        enum DialogResult { YES,NO,CANCEL,CONFIRM,OK}
//        static void Main(string[] args)
//        {
//            DialogResult result = DialogResult.YES;
//            WriteLine(result == DialogResult.YES);
//            WriteLine(result == DialogResult.NO);
//            WriteLine(result == DialogResult.CANCEL);
//            WriteLine(result == DialogResult.CONFIRM);
//            WriteLine(result == DialogResult.OK);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace Nullable
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int? a = null;
//            WriteLine(a.HasValue);
//            WriteLine(a != null);

//            a = 3;
//            WriteLine(a);
//            WriteLine(a.HasValue);
//            WriteLine(a != null);
//            WriteLine(a.Value);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace UsingVar
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            var a = 20;
//            WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

//            var b = 3.1414213;
//            WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

//            var c = "Hello, World!";
//            WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

//            var d = new int[] { 10, 20, 30 };
//            Write("Type: {0}, Value: ", d.GetType());
//            foreach (var e in d)
//                Write("{0} ", e);
//            WriteLine();
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace StringSearch
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string greeting = "Good Morning";

//            WriteLine(greeting);
//            WriteLine();

//            WriteLine($"IndexOf \"Good\" : {greeting.IndexOf("Good")}");
//            WriteLine($"IndexOf 'o' : {greeting.IndexOf('o')}");

//            WriteLine($"LastIndexOf \"Good\" : {greeting.LastIndexOf("Good")}");
//            WriteLine($"LastIndexOf 'o' : {greeting.LastIndexOf('o')}");

//            WriteLine($"StartsWith \"Good\" : {greeting.StartsWith("Good")}");
//            WriteLine($"StartsWith \"Morning\" : {greeting.StartsWith("Morning")}");

//            WriteLine($"Endswith \"Good\" : {greeting.EndsWith("Good")}");
//            WriteLine($"EndsWith \"Morning\" : {greeting.EndsWith("Morning")}");

//            WriteLine($"Contains \"Morning\" : {greeting.Contains("Morning")}");
//            WriteLine($"Contains \"Evening\" : {greeting.Contains("Evening")}");

//            WriteLine($"Replaced \"Moring\" with \"Evening\" : {greeting.Replace("Morning", "Evening")}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace StringModify
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            WriteLine($"ToLower() : \"{"ABC".ToLower()}\"");
//            WriteLine($"ToUpper() : \"{"abc".ToUpper()}\"");

//            WriteLine($"Insert() : \"{"Happy Friday!".Insert(5, " Sunny")}\"");
//            WriteLine($"Remove() : \"{"I Don't Love You".Remove(2, 6)}\"");

//            WriteLine($"Trim() : \"{" No Space ".Trim()}\"");
//            WriteLine($"TrimStart() : \"{" No Space ".TrimStart()}\"");
//            WriteLine($"TrimEnd() : \"{" No Space ".TrimEnd()}\"");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace StringSlice
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string greeting = "Good Morning.";
//            WriteLine(greeting.Substring(0, 4));
//            WriteLine(greeting.Substring(5));

//            string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
//            WriteLine($"Word Count : {arr.Length}");

//            foreach (string element in arr)
//                WriteLine($"{element}");

//        }
//    }
//}


//using System;
//using static System.Console;

//namespace StringFormatNumber
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            WriteLine($"10진수: {123,0:D}");
//            WriteLine($"10진수: {123,0:D5}");

//            WriteLine($"16진수: 0x{0xFF1234:X}");
//            WriteLine($"16진수: 0x{0xFF1234:X8}");

//            WriteLine($"숫자: {12345678:N}");
//            WriteLine($"숫자: {123456789:N0}");

//            WriteLine($"고정소수점: {123.45:F}");
//            WriteLine($"고정소수점: {123.456:F5}");

//            WriteLine($"공학용: {123.456789:E}");
//        }
//    }
//}


//using System;
//using System.Globalization;
//using static System.Console;

//namespace StringFormatDateTime
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            DateTime dt = new DateTime(2021, 11, 14, 19, 8, 2);
//            WriteLine(dt);

//            WriteLine($"12시간 형식: {dt:yyyy-MM-dd tt hh:mm:ss (ddd)}");
//            WriteLine($"24시간 형식: {dt:yyyy-MM-dd tt HH:mm:ss (dddd)}");
//            WriteLine();

//            CultureInfo ciKo = new CultureInfo("kr-KR");
//            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
//            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
//            WriteLine(dt.ToString(ciKo));
//            WriteLine();

//            CultureInfo ciEn = new CultureInfo("en-US");
//            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
//            WriteLine(dt.ToString("yyyy_MM-dd HH:mm:ss (dddd)", ciEn));
//            WriteLine(dt.ToString(ciEn));
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace StringInterpolation
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string name = "한기운";
//            int age = 29;
//            WriteLine($"이름: {name,5}, 나이: {age,5:D3}");
//            WriteLine($"이름: {name,5}, 나이: {age,5:D3}, {(age > 20 ? "성인" : "미성년자"),5}");
//        }
//    }
//}


using System;
using static System.Console;

namespace RectArea
{
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();

            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();

            int int_width = int.Parse(width);
            int int_height = int.Parse(height);
            int area = int_width * int_height;
            WriteLine($"사각형의 넓이는 {area,-5:D5}");

        }
    }
}