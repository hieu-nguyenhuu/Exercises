
using Exercise_13.Data;

namespace Exercise_13
{
    internal class Exercise_13
    {
        static void Main(string[] args)
        {
            Service _service = new Service();
            
            while (true)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Employee Management: ");
                Console.WriteLine("1. Add or Update employee");
                Console.WriteLine("2. Remove employee");
                Console.WriteLine("3. List employees");
                Console.WriteLine("4. Exist");
                int input = 0;
                bool success = false;
                while (!success)
                {
                    Console.Write("Select: ");
                    success = int.TryParse(Console.ReadLine(), out input );
                    if (success && (input < 1 || input > 4))
                        success = false;
                }
                if (input == 1)
                {
                    while (true)
                    {
                        try
                        {
                            _service.addOrUpdate();
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (input == 2)
                {
                    _service.removeEmployee();
                }
                else if (input == 3)
                {
                    _service.listEmployees();
                }
                else if (input == 4) break;
            }

        }
    }
}
