using System;

class People
{
    public string? fullname;
    public int Age;
    public double Height;

    public virtual void PrintInfo()
    {
        Console.WriteLine("┌————————————————————————————————————————————");
        Console.WriteLine("|П.І.Б: " + fullname);
        Console.WriteLine("|Вік: " + Age);
        Console.WriteLine("|Зріст: " + Height);
    }
}