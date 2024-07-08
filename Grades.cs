using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal static class Grades
    {
        static double[] engGrades = new double[10];
        static double[] matGrades = new double[10];
        static double[] sciGrades = new double[10];
        
        public static void InputGrades()
        {
            string responseStudent = "", responseSubject = "";

            do
            {
                Console.Write("Enter student number: ");
                string? input = Console.ReadLine();
                int studentIndex = -1, subjectNum = 0;

                if (Student.ValidateStudent(input))
                {
                    studentIndex = Student.SelectStudent(input);
                    subjectNum = SelectionMenu.SelectSubject();

                    do
                    {
                        switch (subjectNum)
                        {
                            case 1:
                                Console.WriteLine("\nENGLISH");
                                engGrades[studentIndex] = ComputeGrade();
                                Console.WriteLine($"English Grade: {Math.Round(engGrades[studentIndex], 2)}");
                                break;
                            case 2:
                                Console.WriteLine("\nMATHEMATICS");
                                matGrades[studentIndex] = ComputeGrade();
                                Console.WriteLine($"Mathematics Grade: {Math.Round(matGrades[studentIndex], 2)}");
                                break;
                            case 3:
                                Console.WriteLine("\nSCIENCE");
                                sciGrades[studentIndex] = ComputeGrade();
                                Console.WriteLine($"Science Grade: {Math.Round(sciGrades[studentIndex], 2)}");
                                break;
                        }

                        Console.Write("\nAdd grades for another subject? (y/n): ");
                        responseStudent = Console.ReadLine();

                    } while (responseSubject == "y");

                    Console.Write("\nAdd grades for another student? (y/n): ");
                    responseStudent = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid input.");
                    InputGrades();
                }

            } while (responseStudent == "y");

            Program.StartBack();
        }

        public static double ComputeGrade()
        {
            string response = "";
            double perfTasks = 0, writWorks = 0, quarExams = 0, grade = 0;

            do
            {
                int selectedComponent = SelectionMenu.SelectGradeComponent();

                switch (selectedComponent)
                {
                    case 1:
                        perfTasks = perfTasks + ComputePT();
                        break;
                    case 2:
                        writWorks = writWorks + ComputeWW();
                        break;
                    case 3:
                        quarExams = quarExams + ComputeQE();
                        break;
                }

                Console.Write("\nAdd scores for another component? (y/n): ");
                response = Console.ReadLine();

            } while (response == "y");

            grade = (perfTasks + writWorks + quarExams) * 100;

            return grade;
        }
        private static double ComputePT()
        {
            string response = "";
            double rawScore = 0, highestPS = 0, totalPT = 0;

            do
            {
                Console.Write("PT Raw Score: ");
                rawScore = rawScore + Convert.ToDouble(Console.ReadLine());
                Console.Write("PT Highest Possible Score: ");
                highestPS = highestPS + Convert.ToDouble(Console.ReadLine());

                Console.Write("Add another PT? (y/n): ");
                response = Console.ReadLine();

            } while (response == "y");

            totalPT = (rawScore / highestPS) * (0.5);
            return totalPT;
        }
        private static double ComputeWW()
        {
            string response = "";
            double rawScore = 0, highestPS = 0, totalWW = 0;

            do
            {
                Console.Write("WW Raw Score: ");
                rawScore = rawScore + Convert.ToDouble(Console.ReadLine());
                Console.Write("WW Highest Possible Score: ");
                highestPS = highestPS + Convert.ToDouble(Console.ReadLine());

                Console.Write("Add another WW? (y/n): ");
                response = Console.ReadLine();

            } while (response == "y");

            totalWW = (rawScore / highestPS) * (0.3);
            return totalWW;
        }
        private static double ComputeQE()
        {
            string response = "";
            double rawScore = 0, highestPS = 0, totalQE = 0;

            do
            {
                Console.Write("QE Raw Score: ");
                rawScore = rawScore + Convert.ToDouble(Console.ReadLine());
                Console.Write("QE Highest Possible Score: ");
                highestPS = highestPS + Convert.ToDouble(Console.ReadLine());

                Console.Write("Add another QE? (y/n): ");
                response = Console.ReadLine();

            } while (response == "y");

            totalQE = (rawScore / highestPS) * (0.2);
            return totalQE;
        }

        public static double[] GetEngGrades()
        {
            return engGrades;
        }
        public static double[] GetMatGrades()
        {
            return matGrades;
        }
        public static double[] GetSciGrades()
        {
            return sciGrades;
        }
    }
}
