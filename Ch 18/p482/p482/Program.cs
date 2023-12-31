﻿using System;

class Animal { public string Name; }
class Dog : Animal { };

interface IMyIfc<out T>
{
    T GetFirst();
}

class SimpleReturn<T> : IMyIfc<T>
{
    public T[] items = new T[2];
    public T GetFirst() { return items[1]; }
}

class Program
{
    static void DoSomething(IMyIfc<Animal> returner)
    {
        Console.WriteLine(returner.GetFirst().Name);
    }

    static void Main()
    {
        SimpleReturn<Dog> dogReturner = new SimpleReturn<Dog>();
        dogReturner.items[0] = new Dog() { Name = "Avonlea" };
        dogReturner.items[1] = new Dog() { Name = "ss" };
        IMyIfc<Animal> animalReturner = dogReturner;

        DoSomething(dogReturner);
        Console.ReadKey();
    }
}