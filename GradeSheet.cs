using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal static class GradeSheet
    {
        static double[] averages = new double[10];
        static double[] engGrades = Grades.GetEngGrades();
        static double[] matGrades = Grades.GetMatGrades();
        static double[] sciGrades = Grades.GetSciGrades();

        private static void ComputeAverages()
        {
            for (int i = 0; i < averages.Length; i++)
            {
                averages[i] = Math.Round(((engGrades[i] + matGrades[i] + sciGrades[i]) / 3), 2);
            }
        }

        public static void DisplaySheet()
        {
            Console.Clear();
            ComputeAverages();

            string[] studentNumbers = Student.GetStudentNumbers();
            string[] studentNames = Student.GetStudentNames();

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine(" Student Number |       Name       |   English   | Mathematics |   Science   | Average ");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("  {0,-13} | {1,-16} |    {2,-8} |    {3,-8} |    {4,-7}  |  {5,-1}",
                                                $"{studentNumbers[i]}", $"{studentNames[i]}", $"{Math.Round(engGrades[i], 2)}", $"{Math.Round(matGrades[i], 2)}", 
                                                $"{Math.Round(sciGrades[i], 2)}", $"{Math.Round(averages[i], 2)}"));
            }

            Console.Write("\nEnter to go back home. ");
            Console.ReadLine();
            Program.StartBack();
        }


    }



}