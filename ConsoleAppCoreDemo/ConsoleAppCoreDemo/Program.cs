using System;

namespace ConsoleAppCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("press any key");
            //Console.ReadKey();
            Console.WriteLine("Please enter your name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter test score 1:");
            int testscore1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter test score 2:");
            int testscore2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter test score 3:");
            int testscore3 = Convert.ToInt32(Console.ReadLine());

            int averageTestScore = (testscore1 + testscore2 + testscore3) / 3;
            Console.WriteLine($"student average score is :{averageTestScore}");
            string letterGrade = String.Empty;
            Console.WriteLine($"Student {studentName}");
            Console.WriteLine($"The average test score is {averageTestScore}");
            //Calculate student letter grade based on the average test score
            if (averageTestScore >= 90)
            {
                letterGrade = "A";
            }
            if (averageTestScore >= 80 && averageTestScore < 90)
            {
                letterGrade = "B";
            }
            if (averageTestScore >= 70 && averageTestScore < 80)
            {
                letterGrade = "C";
            }
            if (averageTestScore >= 60 && averageTestScore < 70)
            {
                letterGrade = "D";
            }
            if (averageTestScore < 60)
            {
                letterGrade = "F";
            }
            Console.WriteLine($"Your letter grade is {letterGrade}");
        }
    }
}
