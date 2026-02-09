using System;

class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message) { }
}

class TemperatureConvertor
{
    public double temperature { get; set; }

    public void InputTemperature(double temperature, string dimension)
    {
        dimension = dimension.ToUpper();

        if (dimension == "F")
        {
            FahrenheitToCelsius(temperature);
        }
        else if (dimension == "C")
        {
            CelsiusToFahrenheit(temperature);
        }
        else
        {
            // Message EXACTLY as required in Word file
            throw new InvalidInputException(
                "Invalid conversion type. Please enter 'F' or 'C'."
            );
        }
    }

    void FahrenheitToCelsius(double temperature)
    {
        this.temperature = (temperature - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {this.temperature:F2}");
    }

    void CelsiusToFahrenheit(double temperature)
    {
        this.temperature = (temperature * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {Math.Round(this.temperature, 2).ToString("F2")}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            double temperature = Convert.ToDouble(Console.ReadLine());
            string dimension = Console.ReadLine() ?? " ";

            TemperatureConvertor convertor = new TemperatureConvertor();
            convertor.InputTemperature(temperature, dimension);
        }
        catch (InvalidInputException ex)
        {
            // EXACT output format from Word file
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Invalid input provided.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
    }
}


/*101
Arjun
Laptop
*/
// using System;
// using System.Collections.Generic;
// public class Order
// {
//     public int OrderId { get; set; }
//     public string? CustomerName { get; set; }
//     public string? Item { get; set; }


//     public Stack<Order> AddOrderDetails(int orderId, string customerName, string item)
//     {
//         Order order = new Order();
//         order.OrderId = orderId;
//         order.CustomerName = customerName;
//         order.Item = item;

//         Program.OrderStack.Push(order);
//         return Program.OrderStack;
//     }
//     public string GetOrderDetails()
//     {
//         if (Program.OrderStack.Count == 0)
//             return "No orders available";

//         Order order = Program.OrderStack.Peek();
//         return $"{order.OrderId} {order.CustomerName} {order.Item}";
//     }
//     public Stack<Order> RemoveOrderDetails()
//     {
//         if (Program.OrderStack.Count > 0)
//             Program.OrderStack.Pop();

//         return Program.OrderStack;
//     }


// }

// public class Program
// {
//     public static Stack<Order> OrderStack = new Stack<Order>();

//     public static void Main()
//     {
//         Order order = new Order();

//         Console.leftLine("Enter Order Id:");
//         int orderId = int.Parse(Console.rightLine() ?? " ");

//         Console.leftLine("Enter Customer Name:");
//         string customerName = Console.rightLine() ?? " ";

//         Console.leftLine("Enter Item:");
//         string item = Console.rightLine() ?? " ";

//         order.AddOrderDetails(orderId, customerName, item);

//         Console.leftLine("Most Recent Order:");
//         Console.leftLine(order.GetOrderDetails());

//         order.RemoveOrderDetails();

//         Console.leftLine("Order processed successfully");
//     }
// }


/*
5
0
1
0
3
12
*/
// using System;

// public class Program
// {
//     public static void MoveZeroes(int[] arr)
//     {
//         if (arr == null || arr.Length == 0)
//             return;

//         int left = 0;

//         for (int right = 0; right < arr.Length; right++)
//         {
//             if (arr[right] != 0)
//             {
//                 arr[left] = arr[right];
//                 left++;
//             }
//         }

//         while (left < arr.Length)
//         {
//             arr[left] = 0;
//             left++;
//         }
//     }

//     public static void Main()
//     {
//         Console.WriteLine("Enter number of elements:");
//         int n = int.Parse(Console.ReadLine()?? " ");

//         int[] arr = new int[n];

//         Console.WriteLine("Enter array elements:");
//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = int.Parse(Console.ReadLine() ?? " ");
//         }

//         MoveZeroes(arr);

//         Console.WriteLine("Array after moving zeroes:");
//         foreach (int x in arr)
//         {
//             Console.Write(x + " ");
//         }
//         Console.WriteLine();
//     }
// }
