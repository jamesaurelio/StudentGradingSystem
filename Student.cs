using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal static class Student
    {
        static string[] studentNumbers = new string[10];
        static string[] studentNames = new string[10];
        public static void CreateStudents()
        {
            studentNumbers[0] = "2024-01-0001";
            studentNumbers[1] = "2024-01-0002";
            studentNumbers[2] = "2024-01-0003";
            studentNumbers[3] = "2024-01-0004";
            studentNumbers[4] = "2024-01-0005";
            studentNumbers[5] = "2024-01-0006";
            studentNumbers[6] = "2024-01-0007";
            studentNumbers[7] = "2024-01-0008";
            studentNumbers[8] = "2024-01-0009";
            studentNumbers[9] = "2024-01-0010";

            studentNames[0] = "Louise Adams";
            studentNames[1] = "Mike Bailey";
            studentNames[2] = "Charlie Craig";
            studentNames[3] = "Steven Depp";
            studentNames[4] = "Troy Evans";
            studentNames[5] = "Liam Forge";
            studentNames[6] = "Fiona Grover"; 
            studentNames[7] = "Gary Holmes"; 
            studentNames[8] = "Shauna Iris";
            studentNames[9] = "Ivor James";
        }

        public static bool ValidateStudent(string input)
        {
            bool result = false;

            foreach (var student in studentNumbers)
            {
                if (student == input)
                {
                    result = true;
                }
            }

            return result;
        }

        public static int SelectStudent(string input)
        {
            int studentIndex = -1;
            
            studentIndex = Array.IndexOf(studentNumbers, input);
            Console.WriteLine($"\nInput grades for {studentNames[studentIndex]}");

            return (studentIndex);
        }

        public static string[] GetStudentNumbers()
        {
            return studentNumbers;
        }

        public static string[] GetStudentNames()
        {
            return studentNames;
        }
    }
}
