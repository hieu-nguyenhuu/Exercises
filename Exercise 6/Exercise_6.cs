namespace Exercise_6
{
    internal class Exercise_6
    {
        static void Main(string[] args)
        {
            ClassManagement classManagement = new ClassManagement();
            Class newClass1 = new Class { ClassName = "6A" };
            newClass1.addStudent(new Student { Name = "Hieu", Age = 23, Address = "BN" });
            classManagement.addClass(newClass1);
            Class newClass2 = new Class { ClassName = "7A" };
            newClass2.addStudent(new Student { Name = "Minh", Age = 27, Address = "TQ" });
            classManagement.addClass(newClass2 );

            Console.WriteLine("Class Management: ");
            while (true)
            {
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Show student with age");
                Console.WriteLine("3. Count the number of student");
                Console.WriteLine("4. Exit");
                int input = inputBetween("Select: ", 1, 4);
                if (input == 1)
                {
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    int age = inputBegin("Age: ", 0);
                    Console.Write("Address: ");
                    string? address = Console.ReadLine();
                    Console.Write("Class Name: ");
                    string? className = Console.ReadLine();
                    classManagement.addStudent(className, new Student { Name = name, Age = age, Address = address });
                }
                else if (input == 2)
                {
                    int age = inputBegin("Age: ", 0);
                    classManagement.showStudent(age);
                }
                else if (input == 3)
                {
                    int age = inputBegin("Age: ", 0);
                    Console.Write("Address: ");
                    string? address = Console.ReadLine();
                    classManagement.countNumberStudent(age, address);
                }
                else if (input == 4)
                    break;
            }
            Console.ReadKey();
        }
        private static int inputBetween(string inputString, int begin, int end)
        {
            bool success = false;
            int result = int.MinValue;
            while (!success)
            {
                Console.Write(inputString);
                success = int.TryParse(Console.ReadLine(), out result);
                if (success && (result > end || result < begin))
                    success = false;
            }
            return result;
        }
        private static int inputBegin(string inputString, int begin)
        {
            bool success = false;
            int result = int.MinValue;
            while (!success)
            {
                Console.Write(inputString);
                success = int.TryParse(Console.ReadLine(), out result);
                if (success && result < begin)
                    success = false;
            }
            return result;
        }
    }
    public class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Age}, {Address}";
        }
    }
    public class Class
    {
        public List<Student> students { get; private set; } = new List<Student>();
        public string? ClassName { get; set; }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public override string ToString()
        {
            string result = "";
            foreach (var student in students)
            {
                result = result + student.ToString() + "\n";
            }
            return result;
        }
    }
    public class ClassManagement
    {
        public List<Class> classes { get; private set; } = new List<Class>();
        public void addClass(Class Class)
        {
            classes.Add(Class);
        }
        public void addStudent(string? className, Student student)
        {
            var existClass = classes.FirstOrDefault(c => c.ClassName?.ToLower() == className?.ToLower());
            if (existClass == null)
            {
                var newClass = new Class { ClassName = className };
                newClass.addStudent(student);
                addClass(newClass);
            }
            else
                existClass.addStudent(student);

        }
        public void showStudent(int age)
        {
            foreach (var Class in classes)
            {
                foreach (var student in Class.students)
                    if (student.Age == age)
                        Console.WriteLine(student.ToString());
            }
        }
        public void countNumberStudent(int age, string? address)
        {
            int count = 0;
            foreach (var Class in classes)
            {
                count += Class.students.Where(s => s.Age == age && s.Address?.ToLower() == address?.ToLower()).Count();
            }
            Console.WriteLine("There are {0} students at age {1} in {2}", count, age, address);
        }
    }

}
