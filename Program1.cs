// using System;
// using System.Collections;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         ArrayList studentNames=new ArrayList();
//         while(true)
//         {
//             string input=Console.ReadLine();
//             if(input==null)
//             {
//                 continue;
//             }
//             if(input.Equals("stop",StringComparison.OrdinalIgnoreCase))
//             {
//                 break;
//             }
//             if(!IsValidName(input))
//             {
//                 continue;
//             }
//             if(IsNameInCollection(studentNames,input))
//             {
//                 Console.WriteLine(input+" is already in the collection.");
//             }
//             else
//             {
//                 studentNames.Add(input);
//                 Console.WriteLine(input+" added to the collection.");
//             }
//         }
//         Console.WriteLine("Unique student names entered:");
//         DisplayStudentNames(studentNames);
//     }
//     private static bool IsValidName(string name)
//     {
//         return !string.IsNullOrWhiteSpace(name);
//     }
//     private static bool IsNameInCollection(ArrayList studentNames,string name)
//     {
//         foreach(object obj in studentNames)
//         {
//             if(obj.ToString().Equals(name,StringComparison.OrdinalIgnoreCase))
//             {
//                 return true;
//             }
//         }
//         return false;
//     }
//     private static void DisplayStudentNames(ArrayList studentNames)
//     {
//         foreach(object obj in studentNames)
//         {
//             Console.WriteLine(obj.ToString());
//         }
//     }
// }



// using System;
// using System.Collections;
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         ArrayList numbers=new ArrayList();
//         while(true)
//         {
//             string command=Console.ReadLine();
//             if(command==null)
//             {
//                continue;

//             }
//             command=command.ToLower();
//             if(command=="add")
//             {
//                 AddNumber(numbers);
//             }
//             else if(command=="remove")
//             {
//                 RemoveNumber(numbers);
//             }
//             else if(command=="display")
//             {
//                 DisplayNumbers(numbers);
//             }
//             else if(command=="exit")
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Invalid command.");
//             }
//         }
//     }
//     private static void AddNumber(ArrayList numbers)
//     {
//         string input=Console.ReadLine();
//         int value;
//         if(int.TryParse(input,out value))
//         {
//             numbers.Add(value);
//             Console.WriteLine(value+" added to the number list.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void RemoveNumber(ArrayList numbers)
//     {
//         string input=Console.ReadLine();
//         int value;
//         if(int.TryParse(input,out value))
//         {
//             if(numbers.Contains(value))
//             {
//                 numbers.Remove(value);
//                 Console.WriteLine(value+" removed from the number list.");
//             }
//             else
//             {
//                 Console.WriteLine(value+" not found in the number list.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid input. Please enter a valid number.");
//         }
//     }
//     private static void DisplayNumbers(ArrayList number)
//     {
//         Console.WriteLine("Current number in the list :");
//         foreach(object obj in numbers)
//         {
//             Console.WriteLine(obj);
//         }
//     }
// }



// using System;
// using System.Collections;
// public class Album
// {
//     public string Title{get; set;}
//     public string Artist{get; set;}
// }

// public class Program
// {
//     public static void Main(String[] args)
//     {
//         ArrayList albums=new ArrayList();
//         while(true)
//         {
//             string title=Console.ReadLine();
//             if(title==null){continue;}
//             if(title.Equals("quit",StringComparison.OrdinalIgnoreCase)){break;}
//             string artist=Console.ReadLine();
//             if(IsValidInput(title)&&IsValidInput(artist))
//             {
//                 Album a=new Album();
//                 a.Title=title;
//                 a.Artist=artist;
//                 albums.Add(a);
//             }
//         }
//         DisplayAlbums(albums);
//     }
//     private static bool IsValidInput(string input)
//     {
//         return !string.IsNullOrWhiteSpace(input);
//     }
//     private static void DisplayAlbums(ArrayList albums)
//     {
//         foreach(object obj in albums)
//         {
//             Album a=(Album)obj;
//             Console.WriteLine("Title: "+a.Title+", Artist: "+a.Artist);
//         }
//     }
// }



// using System;
// using System.Collections.Generic;
// public class Student
// {
//     public int Id{get;set;}
//     public string Name{get;set;}
//     public string Grade{get;set;}
// }
// public class StudentManager
// {
//     public Dictionary<int,Student> Students{get;set;}
//     public StudentManager()
//     {
//         Students=new Dictionary<int,Student>();
//     }
//     public void AddStudent(Student student)
//     {
//         Students[student.Id]=student;
//     }
//     public void DisplayStudents()
//     {
//         Console.WriteLine("Student Information:");
//         foreach(KeyValuePair<int,Student> item in Students)
//         {
//             Student s=item.Value;
//             Console.WriteLine("ID: "+s.Id+", Name: "+s.Name+", Grade: "+s.Grade);
//         }
//     }
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         StudentManager manager=new StudentManager();
//         Console.WriteLine("Enter Number of Students");
//         int count=int.Parse(Console.ReadLine());
//         for(int i=0;i<count;i++)
//         {
//             Console.WriteLine("Enter ID :");
//             int id=int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter Name :");
//             string name=Console.ReadLine();
//             Console.WriteLine("Enter Grade :");
//             string grade=Console.ReadLine();
//             Student student=new Student{Id=id,Name=name,Grade=grade};
//             manager.AddStudent(student);
//         }
//         manager.DisplayStudents();
//     }
// }