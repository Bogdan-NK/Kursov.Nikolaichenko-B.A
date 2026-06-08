using System;

enum GradeType
{
    Домашняробота,
    Самостійнаробота,
    Контрольнаробота,
    Екзамен,
}

class Grade
{
    public string subject;
    public int value;
    public GradeType type;

    public Grade(string subject, int value, GradeType type)
    {
        this.subject = subject;
        this.value = value;
        this.type = type;
    }

    public void Print()
    {
        Console.WriteLine(
            $"предмет: {subject}, Оцінка: {value}, Вигляд: {type}");
    }
}