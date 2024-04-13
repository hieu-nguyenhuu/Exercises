using System.Security.Cryptography;

namespace Exercise_4
{
    internal class Exercise_4
    {
        static void Main(string[] args)
        {
            Town town = new Town();
            var family1 = new Family { HomeNumber = 1};
            family1.born(new Person { Name = "Hieu", Age = 23, Id = 1, Job = "student" });
            var family2 = new Family { HomeNumber = 2};
            family2.born(new Person { Name = "Dat", Age = 23, Id = 2, Job = "worker" });
            var family3 = new Family { HomeNumber = 3};
            family3.born(new Person { Name = "Thanh", Age = 23, Id = 3, Job = "Staff" });
            town.addFamily(family1);
            town.addFamily(family2);
            town.addFamily(family3);
            Console.WriteLine("Town Management: ");
            while (true)
            {
                Console.Write("Person Name: ");
                string? name = Console.ReadLine();
                long id = inputLongBegin("Id: ", 0);
                while (town.existingPerson(id))
                {
                    Console.WriteLine("Person with Id {0} already exist.", id);
                    id = inputLongBegin("Other Id: ", 0);
                } 
                int age = inputIntBegin("Age: ", 0);
                Console.Write("Job: ");
                string? job = Console.ReadLine();
                var newPerson = new Person 
                {
                    Name = name,
                    Id = id,
                    Age = age,
                    Job = job
                };
                int homeNumber = inputIntBegin("Home Number: ", 0);
                var existingFamily = town.existFamily(homeNumber);
                if (existingFamily != null)
                {
                    existingFamily.born(newPerson);
                }
                else
                {
                    var newFamily = new Family { HomeNumber = homeNumber };
                    newFamily.born(newPerson);
                    town.addFamily(newFamily);
                }
                Console.Write("Continue (y/n): ");
                string? input = Console.ReadLine();
                if (input?.ToLower() == "n")
                    break;
            }
            foreach(var family in town.families)
            {
                Console.WriteLine("Home Number: {0}, has {1} people", family.HomeNumber, family.NumberOfPeople);
                foreach(var person in family.people)
                {
                    Console.WriteLine("\t{0}, {1}, {2}, {3}", person.Name, person.Id, person.Age, person.Job);
                }
            }
            Console.ReadKey();
        }
        private static int inputIntBegin(string inputString, int begin)
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
        private static long inputLongBegin(string inputString, long begin)
        {
            bool success = false;
            long result = long.MinValue;
            while (!success)
            {
                Console.Write(inputString);
                success = long.TryParse(Console.ReadLine(), out result);
                if (success && result < begin)
                    success = false;
            }
            return result;
        }
    }
    public class Person
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Job { get; set; }
    }
    public class Family
    {
        public List<Person> people { get; private set; } = new List<Person>();
        public int HomeNumber { get; set; }
        public int NumberOfPeople
        {
            get
            {
                return people.Count;
            }
        }
        public void born(Person person)
        {
            //var existPerson = people.Where(x => x.Id == person.Id).FirstOrDefault();
            //if(existPerson != null)
            //{
            //    Console.WriteLine("Existing a person with that Id");
            //}
            //else
            people.Add(person);
        }
        public void dead(int id)
        {
            var deadPerson = people.Where(p => p.Id == id).FirstOrDefault();
            if (deadPerson != null)
            {
                people.Remove(deadPerson);
            }
            else
                Console.WriteLine($"There isnt any member with id: {id}");
        }
    }
    public class Town
    {
        public List<Family> families { get; private set; } = new List<Family>();
        public string? Name { get; set; }
        public Family? existFamily(int homeNumber)
        {
            var existFamily = families.Where(f => f.HomeNumber == homeNumber).FirstOrDefault();
            if (existFamily != null)
            {
                return existFamily;
            }
            else return null;
        }
        public bool existingPerson(long id)
        {
            foreach (var family in families)
            {
                foreach (var person in family.people)
                    if (person.Id == id)
                        return true;
            }
            return false;
        }
        public void addFamily(Family family)
        {
            families.Add(family);
        }
        public void removeFamily(int homeNumber)
        {
            var removeFamily = families.Where(x => x.HomeNumber == homeNumber).FirstOrDefault();
            if (removeFamily != null)
                families.Remove(removeFamily);
            else
                Console.WriteLine("There isnt any family with home number: {0}", homeNumber);
        }
    }
}
