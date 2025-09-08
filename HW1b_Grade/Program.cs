// HW1b Grade

// Your Name: Ethan Stone
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;

            int studentid;

            double homework;
            double participation;
            double quizzes;
            double midterm1;
            double midterm2;
            double final;

            string studentidAsString;
            string homeworkAsString;
            string participationAsString;
            string quizzesAsString;
            string midterm1AsString;
            string midterm2AsString;
            string finalAsString;

            Console.WriteLine("What is your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter your student id number.");
            studentidAsString = Console.ReadLine();
            Console.WriteLine("What is your percentage grade for homework?");
            homeworkAsString = Console.ReadLine();
            Console.WriteLine("What is your percentage grade for participation?");
            participationAsString = Console.ReadLine();
            Console.WriteLine("What is your percentage grade for quizzes?");
            quizzesAsString = Console.ReadLine();
            Console.WriteLine("What is your percentage grade for the first midterm?");
            midterm1AsString = Console.ReadLine();
            Console.WriteLine("What is your percentage grade for the second midterm?");
            midterm2AsString = Console.ReadLine();
            Console.WriteLine("What is your percentage grade for the final?");
            finalAsString = Console.ReadLine();

            homework = Convert.ToDouble(homeworkAsString);
            participation = Convert.ToDouble(participationAsString);
            quizzes = Convert.ToDouble(quizzesAsString);
            midterm1 = Convert.ToDouble(midterm1AsString);
            midterm2 = Convert.ToDouble(midterm2AsString);
            final = Convert.ToDouble(finalAsString);

            double FinalGrade = (homework * 0.2) + (participation * 0.15) + (quizzes * 0) + (midterm1 * 0.15) + (midterm2 * 0.25) + (final * 0.25);

            Console.WriteLine($"{firstname} {lastname} ({studentidAsString}), your final grade is {FinalGrade}%");
        }
    }
}
