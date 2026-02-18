/*
3
S01 Aman 9.2
3
S02 Riya 8.5
3
S03 Rahul 9.2
3
S04 Neha 7.8
1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
class InvalidGPAException : Exception
{
    public InvalidGPAException(string message) : base(message) { }
}

class DuplicateStudentException : Exception
{
    public DuplicateStudentException(string message) : base(message) { }
}

class StudentNotFoundException : Exception
{
    public StudentNotFoundException(string message) : base(message) { }
}


class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public double GPA { get; set; }
    public Student(string id, string name, double gpa)
    {
        Id = id;
        Name = name;
        GPA = gpa;
    }
}
class Program
{
    public static SortedDictionary<double, List<Student>> students = new SortedDictionary<double, List<Student>>();
    public static void Main(string[] args)
    {
        bool exit = false;
        try
        {
            while (!exit)
            {
                Console.WriteLine("\n--- Student GPA Ranking System ---");
                Console.WriteLine("1 → Display Ranking");
                Console.WriteLine("2 → Update GPA");
                Console.WriteLine("3 → Add Student");
                Console.WriteLine("4 → Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine() ?? "";
                switch (choice)
                {
                    case "1":
                        DisplayRanking();
                        break;
                    case "2":
                        UpdateGPA();
                        break;
                    case "3":
                        AddStudent();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    public static void AddStudent()
    {
        Console.WriteLine("Enter Student's ID, Name, GPA (input in same format.)!");
        string[] str = (Console.ReadLine() ?? "").Split(" ");
        string studentId = str[0];
        string Name = str[1];
        Double GPA = Convert.ToDouble(str[2]);
        if (GPA < 0 || GPA > 10)
            throw new InvalidGPAException("GPA must be between 0 and 10.");
        Student student = new Student(studentId, Name, GPA);
        foreach (var i in students)
        {
                if(i.Value.Any(s => s.Id == studentId))
                {
                    throw new DuplicateStudentException($"Duplicate Student Exists with Id {student.Id}!");
                }
            
        }

        if (students.ContainsKey(student.GPA))
        {
            students[student.GPA].Add(student);
        }
        else
        {
            students[student.GPA] = new List<Student> { student };
        }
        Console.WriteLine("Student Added Successfully!");
    }
    public static void UpdateGPA()
    {
        Console.WriteLine("Enter Student Id and updated GPA");
        string[] str = (Console.ReadLine() ?? "").Split(" ");
        string StudentId = str[0];
        double NewGPA = Convert.ToDouble(str[1]);
        if (NewGPA < 0 || NewGPA > 10)
        {
            throw new InvalidGPAException($"GPA must be 0-10");
        }

        Student? student = null;
        Double OldGPA = 0;
        foreach (var group in students)
        {
            student = group.Value.FirstOrDefault(s => s.Id == StudentId);
            if (student != null)
            {
                OldGPA = student.GPA;
                break;
            }
        }
        if (student == null)
        {
            throw new StudentNotFoundException("Student not found.");
        }
        students[OldGPA].Remove(student);
        if (students[OldGPA].Count == 0)
        {
            students.Remove(OldGPA);
        }

        if (!students.ContainsKey(NewGPA))
        {
            students[NewGPA] = new List<Student>();
        }
        students[NewGPA].Add(student);
        student.GPA = NewGPA;
        Console.WriteLine("✅ GPA updated successfully!");

    }

    public static void DisplayRanking()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }
        Console.WriteLine("\n--- GPA Ranking (High → Low) ---");
        var result = students.OrderByDescending(s => s.Key);
        int rank = 1;
        foreach (var group in result)
        {
            Console.WriteLine($"\n\nStudents with Rank {rank} and GPA:{group.Key}\n");
            foreach (var student in group.Value)
            {
                Console.WriteLine($"{rank}. {student.Name} | ID: {student.Id} | GPA: {student.GPA}");
            }
            Console.WriteLine("__________________________________");
            rank++;
        }
    }

}
