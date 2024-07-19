
namespace Homework6
{
 //create a student class private studentID and studentName
    public class Student
    {
        private int studentID;
        private string studentName;

        // create static studentList to hold instances of Student
        public static List<Student> studentList = new List<Student>();

        // Create a constructor to initialize a Student object and add to studentList
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this); 
        }

        // Provide ability to read info in private class to other classes
        public string PublicStudentName
        {
            get { return studentName; }
        }

        // Method to print student ID and name
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create 4 students
            Student student1 = new Student(111, "Alice");
            Student student2 = new Student(222, "Bob");
            Student student3 = new Student(333, "Cathy");
            Student student4 = new Student(444, "David");

            // Create dictionary called "gradebook" to hold names and GPAs
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                {"Alice", 4.0},
                {"Bob", 3.6},
                {"Cathy", 2.5},
                {"David", 1.8}
            };

            // Check if "Tom" is in gradebook and add if not with GPA of 3.3
            //hint: use the ContainsKey 
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            // Calculate average GPA
            double totalGPA = 0;
            foreach (var gpa in gradebook.Values)
            {
                totalGPA += gpa;
            }
            double averageGPA = totalGPA / gradebook.Count;

            // Print average GPA
            Console.WriteLine($"Average GPA: {averageGPA}");

            // Printing information about students with GPA greater than average
            Console.WriteLine("Students with GPA greater than average:");
            foreach (var student in Student.studentList)
            {
                // Accessing studentName using the StudentName property
                if (gradebook.ContainsKey(student.PublicStudentName) && gradebook[student.PublicStudentName] > averageGPA)
                {
                    student.PrintInfo();
                }
            }
        }
    }
}
