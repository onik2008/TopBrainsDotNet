/*
3
M101 Paracetamol 50 2027
3
M102 Aspirin 40 2026
1
2
M101 60
1
4
*/

using System;
using System.Collections.Generic;

class InvalidPriceException : Exception
{
    public InvalidPriceException(string Message) : base(Message){}
}
class InvalidExpiryYearException : Exception
{
    public InvalidExpiryYearException(string Message) : base(Message){}
}
public class DuplicateMedicineException : Exception
{
    public DuplicateMedicineException(string message) : base(message) { }
}

class Medicine
{
    public string Id{get; set;}
    public string Name{get; set;}
    public int Price{get; set;}
    public int ExpiryYear{get; set;}
    public Medicine(string Id, string Name, int Price, int ExpiryYear)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        this.ExpiryYear = ExpiryYear;
    }
    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price}, Expiry Year: {ExpiryYear}.";
    }
}
public class MedicineNotFoundException : Exception
{
    public MedicineNotFoundException(string message) : base(message) { }
}

class MedicineUtilityClass
{
    private SortedDictionary<int, List<Medicine>> medicines;
    public MedicineUtilityClass()
    {
        medicines= new SortedDictionary<int, List<Medicine>>();
    }
    public void AddMedicine(Medicine medicine)
    {
        if(medicine.Price <= 0)
        {
            throw new InvalidPriceException("Price must be greater than zero!");
        }
        if(medicine.ExpiryYear < DateTime.Now.Year)
        {
            throw new InvalidExpiryYearException($"Expiry year should be greater than this year {DateTime.Now.Year}");
        }
        if (!medicines.ContainsKey(medicine.ExpiryYear))
        {
            medicines[medicine.ExpiryYear] = new List<Medicine>(){medicine};
        }
        else
        {
            foreach(var i in medicines[medicine.ExpiryYear])
            {
                if(i.Id == medicine.Id)
                {
                    throw new DuplicateMedicineException("Medicine with same ID already exists!");
                }
            }
            medicines[medicine.ExpiryYear].Add(medicine);
        }   
        Console.WriteLine("Medicine Added Successfully!");
    }
    public void GetAllMedicines()
    {
        Console.WriteLine("<<<<<<<<<<<<<< Showing All Medicines >>>>>>>>>>>>>>");
        foreach(var i in medicines)
        {
            Console.WriteLine($"\nExpiry Year{i.Key}");
            foreach(var medicine in i.Value)
            {
                Console.WriteLine(medicine);
            }
            Console.WriteLine();
        }
    }

    public void UpdateMedicinePrice(string id, int newPrice)
    {
        if(newPrice <= 0)
        {
            throw new InvalidPriceException("Price must be greater than zero!");
        }
        foreach(var meds in medicines)
        {
            for(int i=0; i<meds.Value.Count; i++)
            {
                if(meds.Value[i].Id == id)
                {
                    meds.Value[i].Price = newPrice;
                    Console.WriteLine($"Medicine {id}'s Price {newPrice} Successfully Updated!");
                    return;
                }
            }
        }
        throw new MedicineNotFoundException("Medicine not found!");

    }
}
class Program
{
    public static void Main(string[] args){
    bool exit = false;
    MedicineUtilityClass medicineUtility = new MedicineUtilityClass();
    while(!exit){
        try
        {
            Console.WriteLine("\n--- Pharmacy Medicine Inventory ---");
            Console.WriteLine("1. Display all medicines");
            Console.WriteLine("2. Update medicine price");
            Console.WriteLine("3. Add medicine");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            if(!int.TryParse(Console.ReadLine(), out int Choice))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }
            switch(Choice)
            {
                case 1:
                {
                    medicineUtility.GetAllMedicines();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Enter id and new Price(in one line)");
                    string[] str = (Console.ReadLine() ?? "").Split(" ");
                    string id = str[0];
                    int newPrice = Convert.ToInt32(str[1]);
                    medicineUtility.UpdateMedicinePrice(id, newPrice);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter medicine details in this format");
                    Console.WriteLine("<id> <Name> <Price> <Expiry Year>");
                    string[] str = (Console.ReadLine() ?? "").Split(" ");
                    Medicine medicine = new Medicine(str[0], str[1], Convert.ToInt32(str[2]), Convert.ToInt32(str[3]));
                    medicineUtility.AddMedicine(medicine);
                    break;
                }
                case 4:
                    exit = true;
                    Console.WriteLine("Exiting The Program!!!!");
                    break;
                default:
                Console.WriteLine("Invalid Input!");
                break;   
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    }

}
