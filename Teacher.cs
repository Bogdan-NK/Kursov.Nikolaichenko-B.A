using System;
using System.Collections.Generic;

class Teacher : People
{
    public string Subject = "";

    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public double GetAverageGrade()
{
    int sum = 0;
    int count = 0;

    foreach (Student student in students)
    {
        foreach (Grade grade in student.GetGrades())
        {
            if (grade.subject == Subject)
            {
                sum += grade.value;
                count++;
            }
        }
    }

    if (count > 0)
    {
        return (double)sum / count;
    }

    return 0;
}

    public override void PrintInfo()
    {
        base.PrintInfo();

        Console.WriteLine("|Предмет: " + Subject);
        Console.WriteLine("|Кількість учнів: " + students.Count);
        Console.WriteLine("└————————————————————————————————————————————");
    }
}