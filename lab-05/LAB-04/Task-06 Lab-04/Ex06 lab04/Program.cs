using System;

namespace marks
{
    class Program
    {
        static void Main()
        {
           
            int[,] testMarks = new int[5, 10]; 
            double[] studentAverages = new double[10]; 

            
            Console.WriteLine("Enter the test marks for 5 courses and 10 students:");

            for (int course = 0; course < 5; course++) 
            {
                Console.WriteLine($"Entering marks for Course {course + 1}:");
                for (int student = 0; student < 10; student++) 
                {
                    Console.Write($"Enter marks for Student {student + 1}: ");
                    testMarks[course, student] = int.Parse(Console.ReadLine());
                }
            }

     
            for (int student = 0; student < 10; student++)
            {
                int totalMarks = 0;
                for (int course = 0; course < 5; course++)
                {
                    totalMarks += testMarks[course, student]; 
                }
                studentAverages[student] = totalMarks / 5.0; 
            }

           
            Console.WriteLine("\nTest Marks for each course and student with averages:");
            for (int course = 0; course < 5; course++)
            {
                Console.Write($"Course {course + 1}: ");
                for (int student = 0; student < 10; student++)
                {
                    Console.Write(testMarks[course, student] + "\t");
                }
                Console.WriteLine(); 
            }

         
            Console.Write("\nAverage :");
            for (int student = 0; student < 10; student++)
            {
                Console.Write($"{studentAverages[student]}    ");
            }
            Console.Write("\n");
        }
    }
}
