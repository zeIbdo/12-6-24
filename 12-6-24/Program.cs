namespace _12_6_24
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Enter Fullname:");
            string fullname = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Ibrahim:
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            User user = new User(fullname, email, password);
            if (user.PasswordChecker(password) == false)
                goto Ibrahim;


            Console.WriteLine("1. Show info\n2. Create new group");
            int choice = int.Parse(Console.ReadLine());

            Group group = null;
            if (choice == 2)
            {
                Console.WriteLine("Enter Group Number:");
                string groupNo = Console.ReadLine();

                Console.WriteLine("Enter Student Limit:");
                int studentLimit = int.Parse(Console.ReadLine());

                group = new Group(groupNo, studentLimit);
            }
            else
            {
                user.ShowInfo();
            }

            while (true)
            {
                Console.WriteLine("1. Show all students\n2. Get student by id\n3. Add student\n0. Quit");
                choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;

                switch (choice)
                {
                    case 1:
                        foreach (var item in group.GetAllStudents())
                        {
                            item.StudentInfo();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Student ID:");
                        int id = int.Parse(Console.ReadLine());
                        var studentById = group.GetStudent(id);
                        if (studentById != null)
                        {
                            studentById.StudentInfo();
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter Student Fullname:");
                        string studentFullname = Console.ReadLine();

                        Console.WriteLine("Enter Student Point:");
                        double point = double.Parse(Console.ReadLine());

                        var student = new Student(studentFullname, point);
                        try
                        {
                            group.AddStudent(student);
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }
        }
    }
}
