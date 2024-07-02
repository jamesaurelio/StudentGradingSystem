using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal static class Grades
    {
        static List<float> engGrades = new List<float>();
        static List<float> matGrades = new List<float>();
        static List<float> sciGrades = new List<float>();

        public static void AddGrades()
        {
            string response = "";

            do
            {
                Console.Write("Enter student number: ");
                string input = Console.ReadLine();

                if (Student.ValidateStudent(input))
                {
                    Console.WriteLine($"Input grades for {Student.SelectStudent(input)}");
                    SelectionMenu.SelectSubject();
                }
                else
                {
                    Console.WriteLine("");
                }

                Console.WriteLine("Add grades for another student? (y/n): ");
                response = Console.ReadLine();

            } while (response != "y");

            // Back to selection pane
        }

        public static void ComputeGrade()
        {

        }

        public static void DisplaySheet()
        {
            Console.WriteLine("Display Sheet");
        }
    }
}
