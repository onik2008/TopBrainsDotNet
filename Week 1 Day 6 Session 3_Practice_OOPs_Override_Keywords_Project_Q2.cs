// using System;

// class Shape
// {
//     public string ShapeName { get; set; } = "";
//     public virtual double CalculateArea()
//     {
//         return 0;
//     }
// }
// class Rectangle : Shape
// {
//     double height{get; set;}
//     double  width{get; set;}
//     public Rectangle(double height, double width)
//     {
//         ShapeName = "Rectangle";
//         this.height = height;
//         this.width = width;
//     }
//     public override double CalculateArea()
//     {
//         return height * width;
//     }
// }
// class Circle : Shape
// {
//     double radius{get; set;}
//     public Circle(double radius)
//     {
//         ShapeName = "Circle";
//         this.radius = radius;
//     }

//     public override double CalculateArea()
//     {
//         double ans = Math.PI * Math.Pow(radius, 2);
//         return Math.Round(ans, 2);
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         int n = Convert.ToInt32(Console.ReadLine());

//         while (n <= 0)
//         {
//             Console.WriteLine("Please enter a valid Positive integer");
//             n = Convert.ToInt32(Console.ReadLine());
//         }
//         Shape[] shapes = new Shape[n];
//         for(int i=0; i<n; i++)
//         {
//             Console.WriteLine("Enter the Shape Type and its attributes(Either Rectangle or Circle): ");
//             string Type = Console.ReadLine().ToLower();
//             if(Type == "rectangle")
//             {
//                 double height = Convert.ToDouble(Console.ReadLine());
//                 double width = Convert.ToDouble(Console.ReadLine());
//                 shapes[i] = new Rectangle(height, width);
//             }
//             else if(Type == "circle")
//             {
//                 double radius = Convert.ToDouble(Console.ReadLine());
//                 shapes[i] = new Circle(radius);
//             }
//             else
//             {
//                 Console.WriteLine("Wrong Shape Type.");
//             }
//         }
//         Console.WriteLine("Area of the Shapes: ");
//         for(int i=0; i<n; i++){
//             Console.WriteLine($"Area of shape {i+1} ({shapes[i].ShapeName}) : { shapes[i].CalculateArea():F2}");
//         }
//     }
// }

