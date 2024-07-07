namespace StudentGradingSystem
{
    internal class Program
    {
        public static void Main()
        {
            Student.CreateStudents();

            StartBack();

            EndSession();
        }

        public static void StartBack()
        {
            Console.Clear();
            Console.WriteLine("STUDENT GRADING SYSTEM");
            Console.WriteLine("Performance Task (PT) - 50%\nWritten Works(WW) - 30%\nQuarterly Exams(QE) - 20%");

            int input = SelectionMenu.ShowSelection();

            switch (input)
            {
                case 1:
                    Console.Clear();
                    Grades.InputGrades();
                    break;
                case 2:
                    GradeSheet.DisplaySheet();
                    break;
                case 3:
                    break;
                default:
                    Console.Write("\nInvalid input.");
                    StartBack();
                    break;
            }
        }

        private static void EndSession()
        {
            Console.WriteLine("Session ended.");
        }
    }
}