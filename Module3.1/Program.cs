using System;

namespace Module3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.MyMethod<ChocolateCake>(new ChocolateCake(), 1);

        }
    }
}

public class MyClass
{
    public void MyMethod<T>(T myParameter, int myParameter2)
    {
        Console.WriteLine("my first parameter is: " + myParameter);
        Console.WriteLine("my second parameter is: " + myParameter2);
    }
}

public class ChocolateCake
{
    public string MyProperty { get; set; }
}
