using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Student
    {

        public void AverageScore()
        {
            
            int totalScore = 0;
            int numOfStudents = 0;
            int tempScore = 0;


            while (tempScore != -1)
            {
                Console.WriteLine("****Please enter a students grade.  When you're complete enter -1 to exit****");
                
                
                string scoreStr = Console.ReadLine();
                bool success = Int32.TryParse(scoreStr, out tempScore);
                if (success && tempScore >= 0 && tempScore <= 20)
                {
                    totalScore += tempScore;
                    numOfStudents++;
                } else if (!success || tempScore < -1 || tempScore > 20)
                {

                    Console.WriteLine("\nPlease write a number between 1 and 20\n\n");
                }

                
            }
            
            Console.WriteLine("\n\nThe average score of the " + numOfStudents + " students in the class is: " + (double)totalScore / (double)numOfStudents);
        }


    }
}
