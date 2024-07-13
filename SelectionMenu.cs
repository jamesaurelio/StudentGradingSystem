using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal static class SelectionMenu
    {
        static List<string> selectionMenu = new List<string>();
        static List<string> subjects = new List<string>();
        static List<string> gradeComponents = new List<string>();

        public static void CreateSelections()
        {
            selectionMenu.Add("Add Grades");
            selectionMenu.Add("Display Grades Sheet");
            selectionMenu.Add("End Session");

            gradeComponents.Add("Performance Tasks");
            gradeComponents.Add("Written Works");
            gradeComponents.Add("Quarterly Exams");

            subjects.Add("English");
            subjects.Add("Mathematics");
            subjects.Add("Science");
        }

        public static int ShowSelection()
        {
            int input = 0;

            Console.WriteLine("\nSelect action below:");

            for (int i = 0; i < selectionMenu.Count; i++)
            {
                Console.WriteLine($"Select {i + 1} to {selectionMenu[i]}");
            }

            Console.Write("Input selection: ");
            input = Convert.ToInt16(Console.ReadLine());

            ProcessSelection(input);

            return input;
        }

        private static void ProcessSelection(int input)
        {
            if (input <= selectionMenu.Count)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("Invalid input.");
                selectionMenu.Clear();
                ShowSelection();
            }
        }

        public static int SelectSubject()
        {
            int input = 0;

            Console.WriteLine("Select subject below: ");
            
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine($"Select {i + 1} for {subjects[i]}");
            }

            Console.Write("Input selection: ");
            input = Convert.ToInt16(Console.ReadLine());

            ProcessSelectedSubject(input);

            return input;
        }

        private static void ProcessSelectedSubject(int input)
        {
            if (input <= subjects.Count)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("\nInvalid input.");
                SelectSubject();
            }
        }

        public static int SelectGradeComponent()
        {
            int input = 0;

            Console.WriteLine("Select component below: ");

            for (int i = 0; i < gradeComponents.Count; i++)
            {
                Console.WriteLine($"Select {i + 1} for {gradeComponents[i]}");
            }

            Console.Write("Input selection: ");
            input = Convert.ToInt16(Console.ReadLine());

            ProcessSelectedComponent(input);

            return input;
        }

        private static void ProcessSelectedComponent(int input)
        {
            if (input <= gradeComponents.Count)
            {
                Console.Write("");
            }
            else
            {
                Console.Write("\nInvalid input.");
                SelectSubject();
            }
        }
    }
}
