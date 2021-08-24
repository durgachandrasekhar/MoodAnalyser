using System;

namespace MoodAnalyzerAppwithCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Mood Analyser Problem");
            MoodAnalyser analyser = new MoodAnalyser("I am in sad Mood");
            Console.WriteLine(analyser.AnalyserMethod());
            Console.ReadLine();
        }
    }
}