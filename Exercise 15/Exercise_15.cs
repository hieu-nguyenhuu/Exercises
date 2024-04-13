using Exercise_15.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Exercise_15
{
    internal class Exercise_15
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<StudentManagement>()
            .AddSingleton<Validations>()
            .AddSingleton<Service>()
            .BuildServiceProvider();
            var _service = serviceProvider.GetService<Service>();

            while (true)
            {
                Console.WriteLine("Student Management:");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Check official student");
                Console.WriteLine("3. Get average grade of student by semeter");
                Console.WriteLine("4. Get amount of official student of department");
                Console.WriteLine("5. Get the student with highest entry grade of each department");
                Console.WriteLine("6. Get the list of InService students with given LinkPlace");
                Console.WriteLine("7. Get the list of student having the last average grade greater than 3.2");
                Console.WriteLine("8. Get the list of student having the highest average point");
                Console.WriteLine("9. Sort the student by type");
                Console.WriteLine("10. Sort the student by entry year");
                Console.WriteLine("11. Total the student by entry year");
                Console.WriteLine("12. Exit");
                bool success = false;
                int input = -1;
                while (!success)
                {
                    Console.Write("Select: ");
                    success = int.TryParse(Console.ReadLine(), out input);
                    if(success && (input < 1 || input > 12)) 
                        success = false;
                }
                try
                {
                    switch (input)
                    {
                        case 1:
                            _service?.addStudent();
                            break;
                        case 2:
                            _service?.checkStudent();
                            break;
                        case 3:
                            _service?.averageGradeOfStudent();
                            break;
                        case 4:
                            _service?.numberOfOfficialStudent();
                            break;
                        case 5:
                            _service?.maxGradeStudents();
                            break;
                        case 6:
                            _service?.inServiceStudent();
                            break;
                        case 7:
                            _service?.studentWithAverageGrade();
                            break;
                        case 8:
                            _service?.highestGradeStudentEachDepartment();
                            break;
                        case 9:
                            _service?.printStudentByDepartment();
                            _service?.sortStudentTypeAsc();
                            break;
                        case 10:
                            _service?.printStudentByDepartment();
                            _service?.sortStudentEntryYearDesc();
                            break;
                        case 11:
                            _service?.studentStatisticByEntryYear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("---------------------------------------\n");
                }
                if (input == 12)
                    break;
            }

            Console.ReadKey();
            if (_service is IDisposable disposableService)
            {
                disposableService.Dispose();
            }
        }
    }
}
