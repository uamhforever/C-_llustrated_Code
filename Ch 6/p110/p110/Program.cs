using System;

class MyClass
{
    public void ListInts(params int[] inVals)
    {
        if ((inVals != null) && (inVals.Length != 0))
            for (int i = 0; i < inVals.Length; i++) // Process the array.
            {
                inVals[i] = inVals[i] * 10;
                Console.WriteLine($"{inVals[i]}"); // Display new value.
            }
    }

    public void ListInts(Stu stu)
    {
        stu.first = stu.first * 10;
        stu.second = stu.second * 10;
        stu.third = stu.third * 10;
    }
}

class Stu
{
    public int first;
    public int second;
    public int third;

    public Stu(int first, int second, int third)
    {
        this.first = first;
        this.second = second;
        this.third = third;
    }
}

class Program
{
    static void Main()
    {
        int first = 5, second = 6, third = 7;        // Declare three ints.

        MyClass mc = new MyClass();
        mc.ListInts(first, second, third);         // Call the method.

        Console.WriteLine($"{first}, {second}, {third}");

        Stu stu = new Stu(5, 6, 7);
        mc.ListInts(stu);
        Console.WriteLine($"{stu.first}, {stu.second}, {stu.third}");

        Console.ReadKey();
    }
}