using System;

class Stu
{
    public string name;
    public Stu(string name)
    {
        this.name = name;
    }
}

class Program
{
    static void Main()
    {
        int x = 2;
        ref int y = ref x;

        Stu s1 = new Stu("wp");
        ref Stu s2 = ref s1;
        Console.WriteLine($"s1 = {s1.name}, s2 = {s2.name}");
        s1.name = "pw";
        Console.WriteLine($"s1 = {s1.name}, s2 = {s2.name}");
        s2.name = "hh";
        Console.WriteLine($"s1 = {s1.name}, s2 = {s2.name}");

        Console.WriteLine($"x = {x}, y = {y}");
        x = 5;
        Console.WriteLine($"x = {x}, y = {y}");
        y = 6;
        Console.WriteLine($"x = {x}, y = {y}");
        Console.ReadKey();
    }
}