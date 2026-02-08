// // using System;
// // using System.Collections;
// // class Animal
// // {
// //     public string Species{get; set;}
// //     public string Name{get; set;}
// //     public override string ToString()
// //     {
// //         return $"{Species} {Name}";
// //     }
// // }
// // class Program1
// // {
// //     public static void Main(string[] args)
// //     {
// //         ArrayList arr1 = new ArrayList();
// //         arr1.Add(1);
// //         arr1.Add("hi");
// //         Animal animal1 = new Animal()
// //         {
// //             Species = "Dog",
// //             Name = "Jackson",
// //         };
// //         arr1.Add(animal1);
// //         Console.WriteLine($"Count of the arraylist is: {arr1.Count}");
// //         foreach(var i in arr1){
// //             Console.Write($"{i} ");
// //         }
// //         Console.WriteLine();
// //         ArrayList arr2 = new ArrayList();
// //         arr2.Add(2);
// //         arr2.Add("hey");

// //         arr1.AddRange(arr2);
// //         Console.WriteLine($"Count of the arraylist is: {arr1.Count}");
// //         foreach(var i in arr1){
// //             Console.Write($"{i} ");
// //         }
// //         Console.WriteLine();
// //         arr1.Add(arr2);
// //         Console.WriteLine($"Count of the arraylist is: {arr1.Count}");
// //         foreach(var i in arr1){
// //             Console.Write($"{i} ");
// //         }
// //         Console.WriteLine();
// //         object x = arr1[0];
// //         Console.WriteLine(x);
        
// //     }
// // }
// // Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler

// // using System;
// // using System.Numerics;
// // class AddClass<T> where T : INumber<T>
// // {
// //     // public static T Add<T>(int a, int b) where T : INumber<T>
// //     // {
// //     //     return a + b ;
// //     // }
// //     public static T Add<T>(T a, T b)
// //     {
// //         return (dynamic)a + (dynamic)b;
// //     }

// // }

// // public class HelloWorld
// // {
// //     public static void Main(string[] args)
// //     {
// //         Console.WriteLine(AddClass.Add(DateTime.Now, DateTime.Now));
// //     }
// // }



// // using System;
// // using System.Collections.Generic;
// // namespace GenericHashSetDemo
// // {
// // class Program
// // {
// // static void Main()
// // {
// // //Creating HashSet and Adding Elements to HashSet using Collection Initializer 
// // HashSet<string> hashSetCountries = new HashSet<string>()
// // {
// // "Bangladesh",
// // "Nepal"
// // };
// // //Adding Elements to HashSet using Add Method
// // hashSetCountries.Add("INDIA");
// // hashSetCountries.Add("USA");
// // hashSetCountries.Add("UK");
// // //Adding Duplicate Elements will not give compile time error
// // //But duplicate elements are simply ignored and will not be added into the collection
// // hashSetCountries.Add("UK");
// // hashSetCountries.Add("INDIA");
// // Console.WriteLine($"HashSet Elements Count Before Removing: {hashSetCountries.Count}");
// // foreach (var item in hashSetCountries)
// // {
// // Console.WriteLine(item);
// // }
// // //Removing element Bangladesh from HashSet Using Remove() method
// // hashSetCountries.Remove("Bangladesh");
// // Console.WriteLine($"\nHashSet Elements Count After Removing Bangladesh: {hashSetCountries.Count}");
// // foreach (var item in hashSetCountries)
// // {
// // Console.WriteLine(item);
// // }
// // //Remove Element from HashSet Using RemoveWhere() method where element length is > 3
// // // int NumberOfElementRemoved =
// //  hashSetCountries.RemoveWhere(x => x.Length > 3);
// // // Console.WriteLine($"\nHashSet Elements Count After Removeing {NumberOfElementRemoved} Elements : {hashSetCountries.Count}");
// // foreach (var item in hashSetCountries)
// // {
// // Console.WriteLine(item);
// // }
// // //Remove All Elements Using Clear method
// // hashSetCountries.Clear();
// // Console.WriteLine($"\nHashSet Elements Count After Clear: {hashSetCountries.Count}");
// // Console.ReadKey();
// // }
// // }
// // }


// using System;
// using System.Collections.Generic;
// namespace GenericHashSetDemo
// {
// class Program
// {
// static void Main()
// {
// //Creating HashSet Collection1
// HashSet<string> hashSetCountries1 = new HashSet<string>();
// //Adding Elements to HashSet using Add Method
// hashSetCountries1.Add("IND");
// hashSetCountries1.Add("USA");
// hashSetCountries1.Add("UK");
// hashSetCountries1.Add("NZ");
// hashSetCountries1.Add("BAN");
// Console.WriteLine("HashSet 1 Elements");
// foreach (var item in hashSetCountries1)
// {
// Console.WriteLine(item);
// }
// //Creating HashSet Collection2
// HashSet<string> hashSetCountries2 = new HashSet<string>();
// //Adding Elements to HashSet using Add Method
// hashSetCountries2.Add("IND");
// hashSetCountries2.Add("USA");
// hashSetCountries2.Add("SA");
// hashSetCountries2.Add("SL");
// hashSetCountries2.Add("ZIM");
// Console.WriteLine("\nHashSet 2 Elements");
// foreach (var item in hashSetCountries2)
// {
// Console.WriteLine(item);
// }
// //Using SymmetricExceptWith method
// hashSetCountries1.SymmetricExceptWith(hashSetCountries2);
// Console.WriteLine("\nHashSet 1 Elements After SymmetricExceptWith ");
// foreach (var item in hashSetCountries1)
// {
// Console.WriteLine(item);
// }
// Console.ReadKey();
// }
// }
// }
