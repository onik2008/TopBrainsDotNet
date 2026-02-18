/*
 24.5678, 18.9, null, , 31.0049, error, 29, 17.999, NaN 
 */
using System;
using System.Collections.Generic;
using System.Linq;

interface interface1
{
    public void Parsing(string input, out List<double> result);
}
interface interface2
{
    public void rounding(List<double> result);
}
class Sensor_Data_Normalizer : interface1, interface2
{
    public void Parsing(string? input, out List<double> result)
    {
        result = new List<double>();
        if (input == null)
        {
            return;
        }
        string[] str = input.Split(",");
        for(int i=0; i<str.Length; i++)
        {
            str[i] = str[i].Trim();
            if (double.TryParse(str[i], out double value) && !double.IsNaN(value))
            {
                result.Add(value);
            }
        }  
    }
    public void rounding(List<double> result)
    {
        var res = result.Select(s => Math.Round(s, 2)).ToList();
        result.Clear();
        result.AddRange(res);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        string? input = Console.ReadLine();
        Sensor_Data_Normalizer sensor = new Sensor_Data_Normalizer();
        sensor.Parsing(input, out List<double> result);
        sensor.rounding(result);
        foreach(var i in result)
        {
            Console.Write($"{i:F2} ");
        }
        Console.WriteLine();
    }
}
