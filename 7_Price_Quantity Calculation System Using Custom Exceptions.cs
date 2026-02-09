using System;
class InvalidPriceException : SystemException
{
    public InvalidPriceException(): base("Price must be greater than zero")
    {
        
    }
    public InvalidPriceException(string Message) : base(Message)
    {
        
    }
}
class InvalidQuantityException : SystemException
{
    public InvalidQuantityException(): base("Quantity must be greater than zero")
    {
        
    }
    public InvalidQuantityException(string Message) : base(Message)
    {
        
    }
}
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the Price and Quantity 1 by 1 :");

            Double Price = Convert.ToDouble(Console.ReadLine());
            if(Price <= 0) throw new InvalidPriceException("Price must be greater than zero");

            int Quantity = int.Parse(Console.ReadLine() ?? " ");
            if(Quantity <= 0) throw new InvalidQuantityException("Quantity must be greater than zero");

            Console.WriteLine($"Total cost is {Math.Round((Price * Quantity),1).ToString("F1")}");

        }
        catch(FormatException)
        {
            Console.WriteLine($"Error: Please enter a valid number.");
        }
        catch(SystemException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

