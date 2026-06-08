using System;
using System.Collections.Generic;

class Student : People
{
    public string SchoolClass = "";

    private List<Grade> grades = new List<Grade>();

    public void AddGrade(string subject, int value, GradeType type)
    {
        grades.Add(new Grade(subject, value, type));
    }

    public List<Grade> GetGrades()
    {
        return grades;
    }

    public double GetFinalGrade(string subject)
    {
        int sum = 0;
        int count = 0;
        int examGrade = 0;

        foreach (Grade nowg in grades)
        {
            if (nowg.subject == subject)
            {
                if (nowg.type == GradeType.Екзамен)
                {
                    examGrade = nowg.value;
                }
                else
                {
                    sum += nowg.value;
                    count++;
                }
            }
        }

        double average;

         if (count > 0)
         {
         average = (double)sum / count;
         }
         else
        {
         average = 0;
         }

         return (average + examGrade) / 2;}

    public override void PrintInfo()
    {
        base.PrintInfo();

        Console.WriteLine("Клас: " + SchoolClass);
        Console.WriteLine("Оцінки:");

        foreach (Grade nowg in grades)
        {
            nowg.Print();
        }
    }
}