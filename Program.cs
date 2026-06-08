using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        static int ReadGrade()
{
    int grade;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out grade))
        {
            if (grade >= 1 && grade <= 12)
            {
                return grade;
            }
        }

        Console.Write("|Помилка! Введіть оцінку від 1 до 12: ");
    }
}
    Console.WriteLine("╔══════════════════════════════════════════════════════╗");
    Console.WriteLine("║              SCHOOL MANAGEMENT SYSTEM                ║");
    Console.WriteLine("╠══════════════════════════════════════════════════════╣");
    Console.WriteLine("║  Кількість учнів: 2                                  ║");
    Console.WriteLine("║  Вчителів: 2                                         ║");
    Console.WriteLine("║  Предмети: Математика, Фізика                        ║");
    Console.WriteLine("╚══════════════════════════════════════════════════════╝");
    Console.WriteLine();
        Random rand = new Random();

        Student student1 = new Student();

        
        student1.Age = 17;
        student1.Height = rand.Next(160, 191);
        student1.SchoolClass = "10-А";
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("|Введіть ім'я учня");
        student1.fullname = Console.ReadLine();
        
        Console.WriteLine("|Введіть його оцінки");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.Write("|Математика (домашня): ");
        student1.AddGrade("|Математика",ReadGrade(),GradeType.Домашняробота);
        Console.Write("|Математика (самостійна): ");
        student1.AddGrade("|Математика",ReadGrade(),GradeType.Самостійнаробота);
        Console.Write("|Математика (контрольна): ");
        student1.AddGrade("|Математика",ReadGrade(),GradeType.Контрольнаробота);
        Console.Write("|Математика (екзамен): ");
        student1.AddGrade("|Математика",ReadGrade(),GradeType.Екзамен);
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.Write("|Фізика (домашня): ");
        student1.AddGrade("|Фізика",ReadGrade(),GradeType.Домашняробота);
        Console.Write("|Фізика (самостійна): ");
        student1.AddGrade("|Фізика",ReadGrade(),GradeType.Самостійнаробота);
        Console.Write("|Фізика (контрольна): ");
        student1.AddGrade("|Фізика",ReadGrade(),GradeType.Контрольнаробота);
        Console.Write("|Фізика (екзамен):");
        student1.AddGrade("|Фізика",ReadGrade(),GradeType.Екзамен);
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");

        Student student2 = new Student();

        
        student2.Age = 17;
        student2.Height = rand.Next(160, 191);
        student2.SchoolClass = "10-Б";
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("|Введіть ім'я учня");
        student2.fullname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("|Введіть його оцінки");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.Write("|Математика (домашня): ");
        student2.AddGrade("|Математика", ReadGrade(), GradeType.Домашняробота);
        Console.Write("|Математика (самостійна): ");
        student2.AddGrade("|Математика", ReadGrade(), GradeType.Самостійнаробота);
        Console.Write("|Математика (контрольна): ");
        student2.AddGrade("|Математика", ReadGrade(), GradeType.Контрольнаробота);
        Console.Write("|Математика (екзамен): ");
        student2.AddGrade("|Математика", ReadGrade(), GradeType.Екзамен);
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");   
        Console.Write("|Фізика (домашня): ");
        student2.AddGrade("|Фізика", ReadGrade(), GradeType.Домашняробота);
        Console.Write("|Фізика (самостійна): ");
        student2.AddGrade("|Фізика", ReadGrade(), GradeType.Самостійнаробота);
        Console.Write("|Фізика (контрольна): ");
        student2.AddGrade("|Фізика", ReadGrade(), GradeType.Контрольнаробота);
        Console.Write("|Фізика (екзамен): ");
        student2.AddGrade("|Фізика", ReadGrade(), GradeType.Екзамен);
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        
        Console.WriteLine("Журнал");

        Teacher mathTeacher = new Teacher();

        mathTeacher.fullname = "Ігор Ковальчук Іванович";
        mathTeacher.Age = rand.Next(30, 66);
        mathTeacher.Height = rand.Next(165, 196);
        mathTeacher.Subject = "|Математика";

        Teacher physicsTeacher = new Teacher();
        
        physicsTeacher.fullname = "Олександр Бондар Максимович";
        physicsTeacher.Age = rand.Next(30, 66);
        physicsTeacher.Height = rand.Next(165, 196);
        physicsTeacher.Subject = "|Фізика";

        mathTeacher.AddStudent(student1);
        mathTeacher.AddStudent(student2);

        physicsTeacher.AddStudent(student1);
        physicsTeacher.AddStudent(student2);

        List<People> people = new List<People>();

        people.Add(student1);
        people.Add(student2);
        people.Add(mathTeacher);
        people.Add(physicsTeacher);
        
        foreach (People p in people)
        {
            p.PrintInfo();
            Console.WriteLine();
        }
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("|Кінцева оцінка Івана з математики: " + student1.GetFinalGrade("|Математика"));
        Console.WriteLine("|Кінцева оцінка Івана з фізики: " + student1.GetFinalGrade("|Фізика"));
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("|Кінцева оцінка Максима з математики: " + student2.GetFinalGrade("|Математика"));
        Console.WriteLine("|Кінцева оцінка Максима з фізики: " + student2.GetFinalGrade("|Фізика"));
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("|Середня оцінка вчителя математики: " + mathTeacher.GetAverageGrade());
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("┌—————————————————————————————————————————————————————————————————————");
        Console.WriteLine("|Середня оцінка вчителя фізики: " + physicsTeacher.GetAverageGrade());
        Console.WriteLine("└—————————————————————————————————————————————————————————————————————");
        Console.ReadKey();
        
    }
}