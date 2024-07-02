using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal class SelectionMenu
    {
        static List<string> selectionMenu = new List<string>();
        static List<string> subjects = new List<string>();
        static List<string> gradeComponents = new List<string>();

        private static void CreateSelections()
        {
            selectionMenu.Add("Add Grades");
            selectionMenu.Add("Display Grades Sheet");

            gradeComponents.Add("Performance Tasks");
            gradeComponents.Add("Written Works");
            gradeComponents.Add("Quarterly Exams");

            subjects.Add("English");
            subjects.Add("Mathematics");
            subjects.Add("Science");
        }

        public static void ShowSelection()
        {
            CreateSelections();

            string input = "";

            Console.WriteLine("\nSelect action below:");

            for (int i = 0; i < selectionMenu.Count; i++)
            {
                Console.WriteLine($"Select {i + 1} to {selectionMenu[i]}");
            }

            Console.Write("Input selection: ");
            input = Console.ReadLine();

            ProcessSelection(input);
        }

        private static void ProcessSelection(string input)
        {
            switch (input)
            {
                case "1":
                    Grades.AddGrades();
                    break;
                case "2":
                    Grades.DisplaySheet();
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    ProcessSelection(input);
                    break;
            }
        }

        public static void SelectSubject()
        {
            string input = "";

            Console.WriteLine("Select subject below: ");
            
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"Select {i + 1} for {subjects[i]}");
            }

            Console.Write("Input selection: ");
            input = Console.ReadLine();

            ProcessSelectedSubject(input);
        }

        private static void ProcessSelectedSubject(string input)
        {
            switch (input)
            {
                case "1":
                    Console.WriteLine("ENGLISH");
                    break; 
                case "2":
                    Console.WriteLine("MATHEMATICS");
                    break;
                case "3":
                    Console.WriteLine("SCIENCE");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    ProcessSelectedSubject(input);
                    break;

            }
        }
    }
}
