using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal static class Student
    {
        static List<string> studentNumbers = new List<string>();
        static List<string> studentNames = new List<string>();

        private static void CreateStudents()
        {
            studentNumbers.Add("2024-01-0001");
            studentNumbers.Add("2024-01-0002");
            studentNumbers.Add("2024-01-0003");
            studentNumbers.Add("2024-01-0004");
            studentNumbers.Add("2024-01-0005");
            studentNumbers.Add("2024-01-0006");
            studentNumbers.Add("2024-01-0007");
            studentNumbers.Add("2024-01-0008");
            studentNumbers.Add("2024-01-0009");
            studentNumbers.Add("2024-01-0010");
        
            studentNames.Add("Louise Adams");
            studentNames.Add("Mike Bailey");
            studentNames.Add("Charlie Beckham");
            studentNames.Add("Steven Holmes");
            studentNames.Add("Harry Manson");
            studentNames.Add("Liam Miller");
            studentNames.Add("Gary Monroe");
            studentNames.Add("Fiona Smith");
            studentNames.Add("Ivor Watson");
            studentNames.Add("Shauna Williams");
        }

        public static bool ValidateStudent(string input)
        {
            CreateStudents();

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

        public static string SelectStudent(string input)
        {
            int nameIndex = -1;
            
            nameIndex = studentNumbers.IndexOf(input);

            return (studentNames[nameIndex]);
        }
    }
}
