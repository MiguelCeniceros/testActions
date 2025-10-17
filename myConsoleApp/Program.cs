

namespace myConsoleApp;

/// <summary>
/// This class represents a public class which should be documented.
/// </summary>
public class Another
{
    private int _myInt;

    /// <summary>
    /// Represents the value of the integer.
    /// </summary>
    public int MyInt
    {
        get => _myInt * 1;
        set => _myInt = value;
    }


    /// <summary>
    /// This method represents an action within the class. Should be documented too.
    /// </summary>
    public void DoSomething()
    {
        // do something
        MyInt = 10;
    }

    public int GetNumber(int i)
    {
        return MyInt * 100;
    }

}


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world");

        var another = new Another();
        another.DoSomething();

    }


}