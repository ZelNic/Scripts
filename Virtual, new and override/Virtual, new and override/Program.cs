using System;

public class Programm
{
    public static void Main()
    {
        List<A> list = new List<A>();

        A a = new A();        
        B b = new B();        
        C c = new C();

        list.Add(a);
        list.Add(b);
        list.Add(c);

        foreach(A i in list)
        {            
            if(i is C)
            {
                i.Make();
            }
        }
    }
}

public class A
{
    public virtual void Make()
    {
        Console.WriteLine("Make A");
    }
}

public class B : A
{
    public override void Make()
    {
        Console.WriteLine("Make B");
    }
}

public class C : A
{
    public override void Make()
    {
        Console.WriteLine("Make C");        
    }
}