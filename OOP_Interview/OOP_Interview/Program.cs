using System;
                                    
public class Base
{
    public Base() => Console.WriteLine("Base constructor");
    public virtual void Show() => Console.WriteLine("Base Show");
}

public class Derived : Base
{
    public Derived() => Console.WriteLine("Derived constructor");
    public override void Show() => Console.WriteLine("Derived Show");
}

public class Program
{
    public static void Main()
    {
        Base obj = new Derived();
        obj.Show();
    }
}
