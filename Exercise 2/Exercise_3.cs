namespace Exercise_3
{
    internal class Exercise_3
    {
        static void Main(string[] args)
        {
            CandidateManager candidateManager = new CandidateManager();
            while (true)
            {
                Console.WriteLine("Candidate Management:");
                Console.WriteLine("1. Add new candidate");
                Console.WriteLine("2. Search candidate by Id");
                Console.WriteLine("3. Show list of Candidate");
                Console.WriteLine("4. Exit");
                int input = inputBetween("Select: ", 1, 4);

                if (input == 1)
                {
                    //int id = inputBegin("Id: ", 0);
                    Console.Write("Name: ");
                    string? name = Console.ReadLine();
                    Console.Write("Address: ");
                    string? address = Console.ReadLine();
                    int priorityLevel = inputBegin("Priority Level: ", 0);
                    Console.WriteLine("Grade: 1.GradeA, 2.GradeB, 3.GradeC");
                    int grade = inputBetween("Select: ", 1, 3);
                    Candidate candidate;
                    if (grade == 1) candidate = new GradeA { Name = name, Address = address, PriorityLevel = priorityLevel };
                    else if (grade == 2) candidate = new GradeB { Name = name, Address = address, PriorityLevel = priorityLevel };
                    else candidate = new GradeC { Name = name, Address = address, PriorityLevel = priorityLevel };
                    candidateManager.addCandidate(candidate);
                    Console.WriteLine("____________________");
                }
                else if (input == 2)
                {
                    int id = inputBegin("Candidate Id: ", 0);
                    var candidate = candidateManager.searchCandidateById(id);
                    if (candidate == null)
                        Console.WriteLine("No Match Candidate");
                    else
                        Console.WriteLine($"{candidate.Name}: {candidate.Address}, {candidate.Grade}, {candidate.PriorityLevel}");
                    Console.WriteLine("____________________");
                }
                else if (input == 3)
                {
                    var candidates = candidateManager.showCandidateList();
                    foreach(var can in candidates)
                        Console.WriteLine($"{can.Name}: {can.Address}, {can.Grade}, {can.PriorityLevel}");
                    Console.WriteLine("____________________");
                }
                else if (input == 4)
                    break;
            }
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
    public class CandidateManager
    {
        private static List<Candidate> candidates = new List<Candidate>
        {
            new GradeA{Id = 1, Name = "Hieu", Address = "An Dong", PriorityLevel = 2 },
            new GradeB{Id = 2, Name = "Dat", Address = "Lac Ve", PriorityLevel= 2 }
        };
        public void addCandidate(Candidate candidate)
        {
            int maxId = candidates.Max(candidate => candidate.Id);
            candidate.Id = maxId + 1;
            candidates.Add(candidate);
        }
        public List<Candidate> showCandidateList()
        {
            return candidates;
        }
        public Candidate? searchCandidateById(int id)
        {
            return candidates.Where(c => c.Id == id).FirstOrDefault();
        }
    }

    public class Candidate
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PriorityLevel { get; set; }
        public GradeType Grade { get; protected set; }
        public enum GradeType
        {
            GradeA, GradeB, GradeC
        }
    }
    public class GradeA : Candidate 
    {
        public int Math { get; set; }
        public int Physics { get; set; }
        public int Chemicals { get; set; }
        public GradeA()
        {
            Grade = GradeType.GradeA;
        }
    }
    public class GradeB : Candidate
    {
        public int Math { get; set; }
        public int Chemicals { get; set; }
        public int Biology { get; set; }
        public GradeB()
        {
            Grade = GradeType.GradeB;
        }
    }
    public class GradeC : Candidate
    {
        public int Literature { get; set; }
        public int History { get; set; }
        public int Geographic { get; set; }
        public GradeC()
        {
            Grade = GradeType.GradeC;
        }
    }
}
