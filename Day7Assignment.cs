// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter number of products: ");
//         int n = int.Parse(Console.ReadLine());

//         // Validation: number of products must be positive
//         if (n <= 0)
//         {
//             Console.WriteLine("Number of products must be greater than 0.");
//             return;
//         }

//         // 2. Create array
//         int[] prices = new int[n];

//         // 3. Accept only positive prices
//         for (int i = 0; i < n; i++)
//         {
//             while (true)
//             {
//                 Console.Write($"Enter price of product {i + 1}: ");
//                 int price = int.Parse(Console.ReadLine());

//                 if (price > 0)
//                 {
//                     prices[i] = price;
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Price must be positive. Try again.");
//                 }
//             }
//         }

//         // 4. Calculate average
//         int sum = 0;
//         for (int i = 0; i < prices.Length; i++)
//         {
//             sum += prices[i];
//         }

//         int average = sum / prices.Length;

//         // 5. Sort array
//         Array.Sort(prices);

//         // 6. Replace prices below average with 0
//         for (int i = 0; i < prices.Length; i++)
//         {
//             if (prices[i] < average)
//             {
//                 prices[i] = 0;
//             }
//         }

//         // 7. Resize array by adding 5 new positions
//         int oldSize = prices.Length;
//         Array.Resize(ref prices, oldSize + 5);

//         // 8. Fill new positions with average price
//         for (int i = oldSize; i < prices.Length; i++)
//         {
//             prices[i] = average;
//         }

//         // 9. Display final array with index
//         Console.WriteLine("\nFinal Array (Index : Value)");
//         for (int i = 0; i < prices.Length; i++)
//         {
//             Console.WriteLine($"Index {i} : {prices[i]}");
//         }
//     }
// }


// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int[,] sales = new int[,]
//         {
//             { 120, 80, 200, 90 },   // Branch 1
//             { 60, 150, 170, 40 },  // Branch 2
//             { 30, 70, 90, 110 }    // Branch 3
//         };
//         int sum = 0;
//         foreach (var i in sales){
//            sum += i;
//         }
//         int avg = sum / sales.Length;
//         int[][] jaggedArray = new int[sales.GetLength(0)][];
//         for(int i=0; i<sales.GetLength(0); i++)
//         {
//             int count = 0;
//             for(int j=0; j<sales.GetLength(1); j++)
//             {
//                 if(sales[i,j] >= avg) count++;
//             }
//             jaggedArray[i] = new int[count];
//             int index = 0;
//             for(int j=0; j<sales.GetLength(1); j++)
//             {
//                 if(sales[i,j] >= avg){
//                 jaggedArray[i][index] = sales[i,j];
//                 index++; 
//                 }
//             }
//         }
//         Console.WriteLine("Jagged Array (Sales >= Product Average):");
//         foreach(var i in jaggedArray)
//         {
//             foreach(int j in i)
//             {
//                 Console.Write($" {j}");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// using System;
// using System.Collections.Generic;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         // int numberOfCustomerTransactions = Convert.ToInt32(Console.ReadLine());
//         List<int> customerList = new List<int>()
//         {
//             101,102,101,103,105,101,102,105
//         };
//         customerList.Add(106);
//         int customerListCount = customerList.Count;
//         HashSet<int> uniqueCustomerList = new HashSet<int>(customerList);
//         int uniqueCustomerListCount = uniqueCustomerList.Count;
//         List<int> cleanedCustomerList = new List<int>(uniqueCustomerList);
//         int cleanedCustomerListCount = cleanedCustomerList.Count;
//         int numberOfduplicateRemoved = customerListCount - uniqueCustomerListCount;
//         foreach(var i in cleanedCustomerList)
//         {
//             Console.Write($"{i} ");
//         }
//         Console.WriteLine();
//         Console.WriteLine("Number of duplicate entries removed: " + numberOfduplicateRemoved);
//     }
// }



// using System;
// using System.Security.Cryptography;
// using Microsoft.VisualBasic;
// using System.Collections.Generic;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the number of Transaction: ");
//         int numberOfTransactions = Convert.ToInt32(Console.ReadLine());
//         Dictionary<int, double> transactionValueDictionary = new Dictionary<int, double>();
//         double total = 0;
//         for(int i=0; i<numberOfTransactions; i++)
//         {
//             int tempKey = Convert.ToInt32(Console.ReadLine());
//             double tempValue = Convert.ToDouble(Console.ReadLine());
//             if(!transactionValueDictionary.ContainsKey(tempKey)){
//                 transactionValueDictionary.Add(tempKey, tempValue);
//                 total += tempValue;
//             }
//         }
//         double avg = total/transactionValueDictionary.Count;
//         SortedList<int, double> transactionValueDictionarySortedList = new SortedList<int, double>();
//         foreach(var i in transactionValueDictionary)
//         {
//             if(i.Value >= avg)
//             {
//                 transactionValueDictionarySortedList.Add(i.Key, i.Value);
//             }
//         }
//         Console.WriteLine ("TransactionId  : Amount");
//         foreach(var i in transactionValueDictionarySortedList)
//         {
//         Console.WriteLine($"{i.Key}        => {i.Value}");
//         }

//     }
// }
/*
5
101
2500
102
1800
103
3200
104
1500
105
2800
*/




// using System;
// using System.Collections.Generic;
// class Program
// {
// 	public static void Main(string[] args)
// 	{
// 		Console.WriteLine("Enter the number of Operations:");
// 		int numberOfOperations = Convert.ToInt32(Console.ReadLine());
// 		Queue<int> OperationsQueue = new Queue<int>();
// 		Stack<int> OperationsStack = new Stack<int>();
// 		for(int i=0; i<numberOfOperations; i++){
// 			int temp = Convert.ToInt32(Console.ReadLine());
// 			OperationsQueue.Enqueue(temp);
// 			OperationsStack.Push(temp);
// 		}
// 		List<string> processed = new List<string>();
// 		while(OperationsQueue.Count>0){
// 			string temp = OperationsQueue.Dequeue().ToString();
// 			processed.Add(temp);
// 		}
// 		List<string> Undo = new List<string>();
// 		for(int i=0; i<2 && OperationsStack.Count>0; i++){
// 			string temp = OperationsStack.Pop().ToString();
// 			Undo.Add(temp);
// 		}
// 		for(int i=0; i<processed.Count; i++){
// 			Console.WriteLine($"Process {i+1} is : {processed[i]}");
// 		}
// 		for(int i=0; i<Undo.Count; i++){
// 			Console.WriteLine($"Undo operation is {i+1}: {Undo[i]}");
// 		}
// 	}
// }		
		


// using System;
// using System.Collections;
// using System.Collections.Generic;
// public class Program
// {
// 	public static void Main(string[] args)
// 	{
// 		int NumberOfUsers = Convert.ToInt32(Console.ReadLine());
// 		Hashtable ht = new Hashtable();
// 		for(int i=0; i<NumberOfUsers; i++)
// 		{
// 			string key = Console.ReadLine() ?? "";
// 			string value = Console.ReadLine() ?? "";
// 			ht.Add(key,value);
// 		}
// 		foreach(DictionaryEntry i in ht)
// 		{
// 			Console.WriteLine($"{i.Key} {i.Value}");
// 		}
// 		ArrayList list = new ArrayList(ht);
//         foreach (DictionaryEntry entry in ht)
//         {
//             list.Add(entry);
//         }

// 		foreach(DictionaryEntry i in list)

// 		{

// 			Console.WriteLine($"{i.Key} {i.Value}");
// 		}
// 	}
// }




