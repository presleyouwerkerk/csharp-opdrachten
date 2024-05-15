
namespace student_staff_console_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            Student student1 = new("Presley", "Straat 1", "Computer Science", 2023, 15000);
            Student student2 = new("Lisa", "Laan 2", "Physics", 2022, 16000);
            Student student3 = new("John", "Weg 3", "Biology", 2024, 17000);

            Staff teacher1 = new("David", "Park 4", "Computer Science Department", 5000);
            Staff teacher2 = new("Emma", "Hof 5", "Physics Department", 5500);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(teacher1.ToString());
            Console.WriteLine(teacher2.ToString());
        }
    }
}
