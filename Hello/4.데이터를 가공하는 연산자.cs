//using System;
//using static System.Console;

//namespace ArithmaticOperators
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int c = 2330;
//            WriteLine($"c: {c}");

//            double d = c / 7.0;
//            WriteLine($"c: {c}, d: {d}");
//            WriteLine($"c의 타입은: {c.GetType()}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace StringConcatenate
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string result = "123" + "456";
//            WriteLine(result);

//            result = "Hello" + " " + "World!";
//            WriteLine(result);
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace RelationalOperator
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            WriteLine($"3 > 4 : {3 > 4}");
//        }
//    }
//}


//using System;
//using static System.Console;

//namespace CnoditionalOperator
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            string result = (10 % 2) == 0 ? "짝수" : "홀수";
//            WriteLine(result);
//        }
//    }
//}

//using System;
//using static System.Console;
//using System.Collections;

//namespace NullConditionalOperator
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            ArrayList a = null;
//            a?.Add("야구");
//            a?.Add("축구");
//            WriteLine($"Count: {a?.Count}");
//            WriteLine($"{a?[0]}");
//            WriteLine($"{a?[1]}");
//            WriteLine($"a는 Null배열임 : {a}");

//            a = new ArrayList();
//            WriteLine($"이제 a는 Null배열이아님 : {a}");
//            a?.Add("야구");
//            a?.Add("축구");
//            WriteLine($"Count: {a?.Count}");
//            WriteLine($"{a?[0]}");
//            WriteLine($"{a?[1]}");
//            WriteLine($"a의 배열 : {a[0]}, {a[1]}");
//        }
//    }
//}

//using System;
//using static System.Console;

//namespace ShiftOpertator
//{
//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            WriteLine("Testing <<");

//            int a = 1;
//            WriteLine($"a        : {a,5:D5}  {Convert.ToString(a,2).PadLeft(32,'0')}");
//            WriteLine($"a  << 1  : {a<<1,5:D5}  {Convert.ToString(a<<1, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 2  : {a<<2,5:D5}  {Convert.ToString(a << 2, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 5  : {a<<5,5:D5}  {Convert.ToString(a << 5, 2).PadLeft(32, '0')}");
//            WriteLine();

//            WriteLine($"a        : {a,5:D5}  {Convert.ToString(a, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 1  : {a >> 1,5:D5}  {Convert.ToString(a >> 1, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 2  : {a >> 2,5:D5}  {Convert.ToString(a >> 2, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 5  : {a >> 5,5:D5}  {Convert.ToString(a >> 5, 2).PadLeft(32, '0')}");
//            WriteLine();

//            a = 255;
//            WriteLine($"a        : {a,5:D5}  {Convert.ToString(a, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 1  : {a << 1,5:D5}  {Convert.ToString(a << 1, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 2  : {a << 2,5:D5}  {Convert.ToString(a << 2, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 5  : {a << 5,5:D5}  {Convert.ToString(a << 5, 2).PadLeft(32, '0')}");
//            WriteLine();

//            WriteLine($"a        : {a,5:D5}  {Convert.ToString(a, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 1  : {a >> 1,5:D5}  {Convert.ToString(a >> 1, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 2  : {a >> 2,5:D5}  {Convert.ToString(a >> 2, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 5  : {a >> 5,5:D5}  {Convert.ToString(a >> 5, 2).PadLeft(32, '0')}");
//            WriteLine();

//            a = -255;
//            WriteLine($"a        : {a,5:D5}  {Convert.ToString(a, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 1  : {a << 1,5:D5}  {Convert.ToString(a << 1, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 2  : {a << 2,5:D5}  {Convert.ToString(a << 2, 2).PadLeft(32, '0')}");
//            WriteLine($"a  << 5  : {a << 5,5:D5}  {Convert.ToString(a << 5, 2).PadLeft(32, '0')}");
//            WriteLine();

//            WriteLine($"a        : {a,5:D5}  {Convert.ToString(a, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 1  : {a >> 1,5:D5}  {Convert.ToString(a >> 1, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 2  : {a >> 2,5:D5}  {Convert.ToString(a >> 2, 2).PadLeft(32, '0')}");
//            WriteLine($"a  >> 5  : {a >> 5,5:D5}  {Convert.ToString(a >> 5, 2).PadLeft(32, '0')}");
//            WriteLine();

//        }
//    }
//}


