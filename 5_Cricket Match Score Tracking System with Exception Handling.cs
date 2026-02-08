using System;
using System.Collections.Generic;
public class CricketMatch
{
    public List<int> playerScores = new List<int>();
    public void AddPlayerScore(int score)
    {  
        if(playerScores.Count == 5)
        {
            throw new InvalidOperationException1();
        }
        if(score < 0 || score > 50)
        {
            throw new ArgumentException1();
        }
        playerScores.Add(score);
    }
    public int CalculateTotalScore()
    {
        int totalScores = 0;
        foreach(var i in playerScores)
        {
            totalScores += i;
        }
        return totalScores;
    }
}
public class InvalidOperationException1 : Exception
{
    // string message = "Cannot add more than 5 player scores.";
    public InvalidOperationException1() : base()
    {
        Console.WriteLine("Cannot add more than 5 player scores.");
    }
}
public class ArgumentException1 : Exception
{
    // string message = "Invalid score. Score must be between 0 and 50.";
    public ArgumentException1 () : base()
    {
        Console.WriteLine("Invalid score. Score must be between 0 and 50.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            CricketMatch match = new CricketMatch();
            string[] input = (Console.ReadLine() ?? " ").Split(" ");
            int[] scores = Array.ConvertAll(input, Convert.ToInt32);
            foreach(var i in scores)
            {
                match.AddPlayerScore(i);
            }
            Console.WriteLine($"Total Score of the cricket team: {match.CalculateTotalScore()}");


        }
        catch(InvalidOperationException1 ex)
        {
            Console.WriteLine($"1{ex.Message}1");
        }
        catch(ArgumentException1 ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

