using System;
using System.Collections.Generic;
class CricketMatch
{
    public List<int> playerScores = new List<int>(new int[5]);
    public int CurrentIndex{get; set;} = 0;
    public void AddPlayerScore(int score)
    {
        if(CurrentIndex >= 5) throw new InvalidOperationException("Cannot add more than 5 player scores.");

        if(score < 0 || score > 50) throw new ArgumentException("Invalid score. Score must be between 0 and 50.");

        playerScores[CurrentIndex] = score;
        CurrentIndex++;
    } 
    public int CalculateTotalScore()
    {
        int sum = 0;
        foreach(var i in playerScores)
        {
            sum += i;
        }
        return sum;
    }

}
class Program
{
    public static void Main(string[] args)
    {
        try
        {
        string[] input = (Console.ReadLine()?? " "). Split(" ");    
        int[] scores = Array.ConvertAll(input, Convert.ToInt32);
        CricketMatch match = new CricketMatch();
        foreach(var i in scores)
        {
            match.AddPlayerScore(i);
        }
        Console.WriteLine($"Total score of the cricket team: {match.CalculateTotalScore()}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}