using System;
using System.ComponentModel;


class CoPrac
{
    static void Main()
    {
        //Prac_1();
        //Prac_2();
        //Prac_3_1();
        //Prac_3_2();
        //Prac_4_1();
        //Prac_4_2();
        //Prac_5();
        //Prac_6();
        //Prac_7_1();
        //Prac_7_2();
        //Prac_8_1();
        //Prac_8_2();
        //Prac_8_3();
        Prac_9_1();
    }

    static void Prac_1()
    {
        object obj1 = 42;
        object obj2 = 3.14;
        object obj3 = "Hello";
        object obj4 = true;

        Console.WriteLine(obj1);
        Console.WriteLine(obj2);
        Console.WriteLine(obj3);
        Console.WriteLine(obj4);
    }
    static void Prac_2()
    {
        Stack stack = new Stack();
        stack.Push("sausage");
        string s = (string)stack.Pop();
        Console.WriteLine(s);

        stack.Push(3);
        int three = (int)stack.Pop();
        Console.WriteLine(three);

    }
    static void Prac_3_1()
    {
        int i = 1234;
        object o = i;

        Console.WriteLine(i);
    }
    static void Prac_3_2()
    {
        object obj = 1234;
        int i = (int)obj;
        Console.WriteLine(i);
    }
    static void Prac_4_1()
    {
        int i = 42;
        object obj = i;
        Console.WriteLine(obj);

    }
    static void Prac_4_2()
    {
        Point p = new Point() { X = 10, Y = 20 };
        IDisplayable d = p;
        Console.WriteLine(d.GetType().Name);
    }
    static void Prac_5()
    {
        int i = 3;
        object obj = i;
        i = 5;

        Console.WriteLine($"원본: {i}");
        Console.WriteLine($"박싱된 값: {obj}");

    }
    static void Prac_6()
    {
        object obj = 42;
        int i = (int)obj;
        Console.WriteLine($"언박싱 성공 : {i}");

        try
        {
            long l = (long)obj;
        }
        catch(InvalidCastException)
        {
            Console.WriteLine("잘못된 타입으로 언박싱 시도");
        }

        int temp = (int)obj;
        long correcct = temp;
        Console.WriteLine($"올바른 변환 : {correcct}");
    }
    static void Prac_7_1()
    {
        int sum = 0;
        for (int i = 0; i < 1000; i++)
        {
            object boxed = i;
            sum += (int)boxed;
        }
        Console.WriteLine($"박싱 사용: {sum}");

        int sum1 = 0;
        for (int i = 0; i < 1000;i++)
        {
            sum1 += i;
        }
        Console.WriteLine($"직접 처리: {sum1}");
    }
    static void Prac_7_2()
    {
        GenericStack<int> genricStack = new GenericStack<int>();
        genricStack.Push(42);
        int value = genricStack.Pop();
        Console.WriteLine(value);
    }
    static void Prac_8_1()
    {
        int i = 1234;
        string c = "안녕하세요";
        char c2 = 'A';
        double d = 3.14;
        object obj = new object();

        Console.WriteLine(i.GetType());
        Console.WriteLine(c.GetType());
        Console.WriteLine(c2.GetType());
        Console.WriteLine(d.GetType());
        Console.WriteLine(obj.GetType());
    }
    static void Prac_8_2()
    {
        Console.WriteLine(typeof(int));
        Console.WriteLine(typeof(string));
        Console.WriteLine(typeof(double));
    }
    static void Prac_8_3()
    {
        Points p = new Points() { X = 10 , Y= 20};
        Console.WriteLine(p.GetType().Name);
        Console.WriteLine(typeof(Points).Name);
        Console.WriteLine(p.GetType() == typeof(Points));
        Console.WriteLine(p.X.GetType().Name);            
        Console.WriteLine(p.Y.GetType().FullName);
    }
    static void Prac_9_1()
    {
        int i = 42;
        double d = 3.14;
        bool b = true;

        Console.WriteLine(i.ToString());
        Console.WriteLine(d.ToString());
        Console.WriteLine(b.ToString());
    }
}




