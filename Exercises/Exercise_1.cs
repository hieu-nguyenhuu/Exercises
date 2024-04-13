namespace Exercises_1
{
    internal class Exercise_1
    {
        private static List<Officer> officers = new List<Officer>();
        static void Main(string[] args)
        {
            var officerManager = new OfficerManagement();
            while (true)
            {
                Console.WriteLine("OfficerManagement:");
                Console.WriteLine("1. Add new officer");
                Console.WriteLine("2. Search officer with name");
                Console.WriteLine("3. Show list of Officer");
                Console.WriteLine("4. Exit");
                int input = inputInt("Select: ", 1, 4);
                if (input == 1)
                {
                    Console.WriteLine("1. Add Worker");
                    Console.WriteLine("2. Add Engineer");
                    Console.WriteLine("3. Add Staff");
                    int officerType = inputInt("Select: ", 1, 3);

                    Console.Write("Name:");
                    string? name = Console.ReadLine();
                    int age = inputInt("Age: ", 1, 150);
                    Console.WriteLine("Sex: 1.Male, 2.Female, 3.Other");
                    int sex = inputInt("Select: ", 1, 3);
                    Console.Write("Address: ");
                    string? address = Console.ReadLine();
                    if (officerType == 1)
                    {
                        int level = inputInt("Worker Level: ", 1, 10);
                        var newWorker = new Worker
                        {
                            Name = name,
                            Age = age,
                            OfficerSex = (Officer.Sex)sex,
                            Address = address,
                            Level = level
                        };
                        officerManager.addOfficer(newWorker);
                    }
                    else if (officerType == 2)
                    {
                        Console.Write("Engineer Major:");
                        string? major = Console.ReadLine();
                        var newEngineer = new Engineer
                        {
                            Name = name,
                            Age = age,
                            OfficerSex = (Officer.Sex)sex,
                            Address = address,
                            Major = major
                        };
                        officerManager.addOfficer(newEngineer);
                    }
                    else
                    {
                        Console.Write("Staff Job:");
                        string? job = Console.ReadLine();
                        var newStaff = new Staff
                        {
                            Name = name,
                            Age = age,
                            OfficerSex = (Officer.Sex)sex,
                            Address = address,
                            Job = job
                        };
                        officerManager.addOfficer(newStaff);
                    }
                    Console.WriteLine("____________________");
                }
                else if (input == 2)
                {
                    Console.Write("Search Name: ");
                    string? searchName = Console.ReadLine();
                    var officers = officerManager.searchOfficer(searchName);
                    if (officers.Count == 0)
                        Console.WriteLine("No match officer");
                    foreach (var officer in officers)
                    {
                        Console.WriteLine($"{officer}: {officer.Name}, {officer.Age}, {officer.OfficerSex}, {officer.Address}");
                    }
                    Console.WriteLine("____________________");
                }
                else if (input == 3)
                {
                    var officers = officerManager.showListOfficers();
                    foreach (var officer in officers)
                    {
                        Console.WriteLine($"{officer}: {officer.Name}, {officer.Age}, {officer.OfficerSex}, {officer.Address}");
                    }
                    Console.WriteLine("____________________");
                }
                else if (input == 4)
                    break;
            }
            Console.ReadKey();

        }
        private static int inputInt(string inputString, int begin, int end)
        {
            bool success = false;
            int result = -1;
            while (!success)
            {
                Console.Write(inputString);
                success = int.TryParse(Console.ReadLine(), out result);
                if (success && (result > end || result < begin))
                    success = false;
            }
            return result;
        }
    }
    public class OfficerManagement
    {
        public static List<Officer> offiers = new List<Officer>()
        {
            new Engineer{Name = "Hieu", Address = "Bac Ninh", OfficerSex = Officer.Sex.Male, Age = 23, Major = "Automation"},
            new Staff{Name = "Dat", Address = "An Dong", OfficerSex = Officer.Sex.Male, Age = 23, Job = "Telecom"},
        };

        public void addOfficer(Officer officer)
        {
            offiers.Add(officer);
        }
        public List<Officer> searchOfficer(string? name)
        {
            return offiers.Where(t => t.Name?.ToLower() == name?.ToLower()).ToList();
        }
        public List<Officer> showListOfficers()
        {
            return offiers;
        }
    }

    public class Officer
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Sex OfficerSex { get; set; }
        public string? Address { get; set; }
        public enum Sex
        {
            Male = 1, Female, Other
        }
    }
    public class Worker : Officer
    {
        public int Level { get; set; }
    }
    public class Engineer : Officer
    {
        public string? Major { get; set; }
    }
    public class Staff : Officer
    {
        public string? Job { get; set; }
    }
}
