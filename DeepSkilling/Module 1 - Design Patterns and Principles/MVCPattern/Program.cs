namespace MVCPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(148, "Navya", "B");

            StudentView view = new StudentView();

            StudentController controller =
                new StudentController(student, view);

            controller.UpdateView();

            controller.SetStudentName("Bayavarapu");
            controller.SetStudentGrade("A+");

            System.Console.WriteLine("\nAfter Update:\n");

            controller.UpdateView();
        }
    }
}
