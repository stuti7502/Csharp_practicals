﻿using System.Diagnostics;

class Student
{
    public static string Name;
    public static decimal[] Marks = new decimal[5];
    public static decimal AverageMarks { get; set; }

    public static decimal CalculateAverageMarks(out decimal AverageMarks)
    {
        decimal sum = 0;
        for (var i = 0; i < 5; i++)
        {
            sum += Marks[i];
        }
        AverageMarks = sum / 5;
        return AverageMarks;
    }



    public static string CalculateGrade(decimal[] marks)
    {
        decimal amarks = 0;
        CalculateAverageMarks(out amarks);
        switch (amarks)
        {
            case var a when a > 90:
                return "A";
            case var a when a > 80:
                return "B";
            case var a when a > 70:
                return "C";
            case var a when a < 70:
                return "D";
            default:
                return "Wrong Input";
        }
    }

    public enum Options
    {

        Aggregate = 1,

        MinMark = 2,

        MaximumMark = 3,

        Grade = 4

    }

    public static void Main()
    {
        Console.WriteLine("Enter Name of a Student");
        Name = Console.ReadLine();
        for (var i = 0; i < 5; i++)
        {
             Console.WriteLine($"Enter the marks of {i + 1} subject");
             Marks[i] = Convert.ToDecimal(Console.ReadLine());
        }

    Continue_here:
        Console.WriteLine();
        Console.WriteLine("Choose an option to perform");
        Console.WriteLine("1 - Average marks");
        Console.WriteLine("2 - Displays the minimum marks of the student");
        Console.WriteLine("3 - Displays the maximum mark");
        Console.WriteLine("4 - Displays grade");
        decimal amarks = 0;
        CalculateAverageMarks(out amarks);
        Console.WriteLine();
        Console.WriteLine("Enter your choice:");
        try
        {
            string options1 = Console.ReadLine();
            Options op1 = (Options)Convert.ToInt32(options1);


            switch (op1)
            {
                case Options.Aggregate:
                    Console.WriteLine("Average Marks " + amarks);
                    break;
                case Options.MinMark:
                    Console.WriteLine("Minimum Marks obtained " + Marks.Min());
                    break;
                case Options.MaximumMark:
                    Console.WriteLine("Maximum Marks obtained " + Marks.Max());
                    break;
                case Options.Grade:
                    Console.WriteLine("Grade " + CalculateGrade(Marks));
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    goto Continue_here;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        string cont;

    yesno:
        Console.WriteLine();
        Console.WriteLine("Do you want to choose another option 'yes' or 'no'? ");
        cont = Console.ReadLine().ToUpper();



        if (cont == "YES")
        {
            goto Continue_here;
        }
        else if (cont == "NO")
        {
            return;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Please type yes or no only");
            goto yesno;
        }


    }

}

