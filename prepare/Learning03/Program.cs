using System.Runtime.InteropServices;
using registration.courses

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Student student = new Student("Gary", "1234");
        Person instructor = new Instructor("Bob");
        Schedule schedule = new Schedule(student);


        while (keepRunning)
        {
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("Choose option:");

            string response = Console.ReadLine();

            if (response == "1")
            {
                schedule.Display();
            }
            else if (response == "2")
            {
                Console.WriteLine("Course number?");
                string courseNumber = Console.ReadLine();
                Course course = new Course(courseNumber, 0, 0, "M/W");
                schedule.AddCourse(course);
            }

        }
    }
}