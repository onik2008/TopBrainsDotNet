// using System;
// using System.Collections.Generic;
// public abstract class Property
// {
//     public int PropertyId { get; set; }
//     public string Location { get; set; }
//     public double Area { get; set; }
//     public string PropertyType { get; protected set; }
//     public abstract double CalculatePropertyTax();
// }
// public class Apartment : Property
// {
//     public Apartment()
//     {
//         PropertyType = "Apartment";
//     }
//     public override double CalculatePropertyTax()
//     {
//         return Math.Round(Area * 0.01, 2);
//     }
// }

// public class House : Property
// {
//     public House()
//     {
//         PropertyType = "House";
//     }
//     public override double CalculatePropertyTax()
//     {
//         return Math.Round(Area * 0.02, 2);
//     }
// }
// public class CommercialBuilding : Property
// {
//     public CommercialBuilding()
//     {
//         PropertyType = "CommercialBuilding";
//     }
//     public override double CalculatePropertyTax()
//     {
//         return Math.Round(Area * 0.03, 2);
//     }
// }

// class PropertyManager
// {
//     public static void PrintPropertyTax(Property property)
//     {
//         Console.WriteLine($"Property Tax for {property.PropertyType} (ID: {property.PropertyId}, Location: {property.Location}, Area: {property.Area}): {property.CalculatePropertyTax():F2}");
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the input for n: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         List<Property> properties = new List<Property>();
//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine("Enter the details(Id, Location, Area, Property Type ) :");
//             int id = Convert.ToInt32(Console.ReadLine());
//             string location = Console.ReadLine();
//             double area = Convert.ToDouble(Console.ReadLine());
//             string type = Console.ReadLine();
//             Property property = null;
//             if (type == "Apartment")
//             {
//                 property = new Apartment();
//             }
//             else if (type == "House")
//             {
//                 property = new House();
//             }
//             else if (type == "CommercialBuilding")
//             {
//                 property= new CommercialBuilding();
//             }
//             else
//             {
//                 Console.WriteLine("Invalid property type.");
//                 continue;
//             }
//             property.PropertyId = id;
//             property.Location = location;
//             property.Area = area;
//             properties.Add(property);
//         }
//         foreach(var i in properties)
//         {
//             PropertyManager.PrintPropertyTax(i);
//         }
//     }
// }
