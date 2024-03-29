﻿/* 6. Create a C# console application that prompts the user to Input a student's name and their exam marks.
      Based on the provided marks, determine, and display the corresponding grade for the student.
      The grading scale is as follows:
        - If the marks are between 75 and 100 (inclusive), assign Grade A.
        - For marks between 60 and 74 (inclusive), assign Grade B
        - For marks between 50 and 59 (inclusive), assign Grade C
        - For marks between 40 and 49 (inclusive), assign Grade D
        - If the marks are below 40, the student has failed.
        - Display the student's name along with their assigned grade at the end of the program.
        - Validate the user input so that when the user inputs a value higher than 100 and less than 0 it displays an error message. */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grader");
            Console.WriteLine("**********************");
            Console.WriteLine();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            char grade;
            if (mark >= 75)
            {
                grade = 'A';
            }
            else if (mark >= 60)
            {
                grade = 'B';
            }
            else if (mark >= 50)
            {
                grade = 'C';
            }
            else if (mark >= 40)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            Console.WriteLine("**********************");
            if (mark > 100 || mark < 0)
            {
                Console.WriteLine("Invalid Mark!");
            }
            else if (grade != 'F')
            {
                Console.WriteLine($"{name} has Passed!");
                Console.WriteLine($"Grade = {grade}");
            }
            else
            {
                Console.WriteLine($"{name} has Failed!");
            }
            Console.ReadLine();
        }
    }
}
