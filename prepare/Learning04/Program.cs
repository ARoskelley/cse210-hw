using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mAssignment = new MathAssignment("Thing one", "Fractions", "7.3", "8-19");
        Console.WriteLine(mAssignment.GetSummary());
        Console.WriteLine(mAssignment.GetHomeworkList());

        WritingAssignment wAssignment = new WritingAssignment("Thing two", "European History", "The cause of world war II");
        Console.WriteLine(wAssignment.GetSummary());
        Console.WriteLine(wAssignment.GetWritingInformation());
    }
}