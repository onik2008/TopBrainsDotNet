// using System;
// using System.Runtime.CompilerServices;
// public class MyException : Exception
// {
//     public MyException() : base("Error: Arrays must have the same length for addition")
//     {
//         // Console.WriteLine("Error: Arrays must have the same length for addition");
//     }
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         try{
//             Console.WriteLine("Enter the values for array1: ");
//             string[] input1 = (Console.ReadLine() ?? "").Split(" ") ;
//             int[] arr1 = Array.ConvertAll(input1, Convert.ToInt32);

//             Console.WriteLine("Enter the value of array2");
//             string[] input2 = (Console.ReadLine() ?? "").Split(" ") ;
//             int[] arr2 = Array.ConvertAll(input2, Convert.ToInt32);

//             if(input1.Length != input2.Length)
//             {
//                 throw new MyException();
//             }

//             int n = arr1.Length;
//             int[] arr3 = new int[n];
            
//             for(int i=0; i<n; i++)
//             {
//                 arr3[i] = arr1[i] + arr2[i];
//             }
//             Console.WriteLine("Enter index to access an element: ");
//             int index = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine($"Value at index {index} in the sum array is: {arr3[index]}");
//         }
//         catch(MyException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch(FormatException ex)
//         {
//             Console.WriteLine("Error: Invalid input format. Please enter integers only.");
//             Console.WriteLine($"Exception Message: {ex.Message}");
//         }
//         catch(IndexOutOfRangeException ex)
//         {
//             Console.WriteLine("Error: Index out of range for the sum array.");
//             Console.WriteLine($"Exception Message: {ex.Message}");
//         }
//         catch(Exception ex)
//         {
//             Console.WriteLine($"Exception Message: {ex.Message}");
//         }
//         finally
//         {
//             Console.WriteLine("Exception Handling executed");
//         }
//     }
// }
// /*

// 10 20 30 40
// 40 30 20 10
// 2


// 1 2 3 1
// 3 2 1 a
// 2

// 1 2 3
// 1 2
// 2

// 11 12
// 10 12
// 3

// 1 2 3 a

// */