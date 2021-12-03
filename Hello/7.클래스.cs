//using System;
//using static System.Console;

//namespace BasicClass
//{
//    class Cat
//    {
//        public string Name;
//        public string Color;

//        public void Meow()
//        {
//            WriteLine($"{Name} : 야옹");
//        }
//    }

//    class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Cat kitty = new Cat();
//            kitty.Color = "하얀색";
//            kitty.Name = "키티";
//            kitty.Meow();
//            WriteLine($"{kitty.Name} : {kitty.Color}");

//            Cat nero = new Cat();
//            nero.Color = "검은색";
//            nero.Name = "네로";
//            nero.Meow();
//            WriteLine($"{nero.Name} : {nero.Color}");

//            Cat atty = new Cat();
//            atty.Meow();
//            WriteLine($"{atty.Name} : {atty.Color}");
//        }
//    }
//}

using System;
using static System.Console;

class Global
{
    public static int Count = 0;
    public string Name = "한기운";
}

class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}

class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}

class MainAppp
{
    static void Main()
    {
        WriteLine($"Global Count: {Global.Count}");
        new ClassA();
        WriteLine($"Global Count: {Global.Count}");
        new ClassA();
        WriteLine($"Global Count: {Global.Count}");
        //WriteLine($"new Global 생성전 Count: {Global.Count},Name: {a.Name}");//요건 당연히 안댐 인스턴스가 생성 안됬으므로
        new ClassB();
        WriteLine($"Global Count: {Global.Count}");
        Global a = new Global();
        WriteLine($"new Global 생성후 Count: {Global.Count},Name: {a.Name}");//static Count이므로 a.Count안댐. 그니깐 아예 프로그램 시작부터 Global.Count는 생성되어 있는거임.
        new ClassB();
        WriteLine($"Global Count: {Global.Count}");

    }
}