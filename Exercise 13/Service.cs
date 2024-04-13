using Exercise_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Service
    {
        private EmployeeManagement _employeeManagement = new EmployeeManagement();
        private Validations _validations = new Validations();
        public Service() 
        {
            Employee experience = new Experience
            {
                Id = 1,
                FullName = "Nguyen Huu Hieu",
                BirthDay = DateTime.Parse("22/02/2001"),
                Phone = "84339458388",
                Email = "hieunh31@fpt.com",
                ExpInYear = 2,
                ProSkill = ".NET"
            };
            Employee fresher = new Fresher
            {
                Id = 2,
                FullName = "Nguyen Duy Dat",
                BirthDay = DateTime.Parse("29/08/2001"),
                Phone = "84339458388",
                Email = "datnd29@fpt.com",
                GraduationRank = "good",
                Education = "Haui"
            };
            Employee intern = new Intern
            {
                Id = 3,
                FullName = "Dang Dinh Thanh",
                BirthDay = DateTime.Parse("18/04/2001"),
                Phone = "84339458388",
                Email = "thanhdd@fpt.com",
                Major = "IT",
                University = "Huce"
            };
            _employeeManagement.addOrUpdateEmployee(experience);
            _employeeManagement.addOrUpdateEmployee(intern);
            _employeeManagement.addOrUpdateEmployee(fresher);
        }

        public void addOrUpdate()
        {
            int id = inputBegin("Id: ", 0);
            Console.Write("Fullname: ");
            string? fullName = Console.ReadLine();
            Console.Write("Birthday: ");
            string? inBirthday = Console.ReadLine();
            _validations.birthdayValidate(inBirthday, out DateTime birthday);
            Console.Write("Phone: ");
            string? phone = Console.ReadLine();
            _validations.phoneValidate(phone);
            Console.Write("Email: ");
            string? email = Console.ReadLine();
            _validations.emailvalidate(email);
            Console.WriteLine("Type: 1.Experience 2.Fresher 3.Intern");
            int type = inputBetween("Select: ", 1, 3);
            if (type == 1)
            {
                int expInYear = inputBegin("Experience in Year: ", 0);
                Console.Write("Proskill: ");
                string? proSkill = Console.ReadLine();
                Employee experience = new Experience
                {
                    Id = id,
                    FullName = fullName,
                    BirthDay = birthday,
                    Phone = phone,
                    Email = email,
                    ExpInYear = expInYear,
                    ProSkill = proSkill
                };
                _employeeManagement.addOrUpdateEmployee(experience);
            }
            else if (type == 2)
            {
                Console.Write("Graduation Rank (good/excellent): ");
                string? graduationRank = Console.ReadLine();
                Console.Write("University: ");
                string? education = Console.ReadLine();
                Employee fresher = new Fresher
                {
                    Id = id,
                    FullName = fullName,
                    BirthDay = birthday,
                    Phone = phone,
                    Email = email,
                    GraduationRank = graduationRank,
                    Education = education
                };
                _employeeManagement.addOrUpdateEmployee(fresher);
            }
            else
            {
                Console.Write("Major: ");
                string? major = Console.ReadLine();
                Console.Write("University: ");
                string? university = Console.ReadLine();
                Employee intern = new Intern
                {
                    Id = id,
                    FullName = fullName,
                    BirthDay = birthday,
                    Phone = phone,
                    Email = email,
                    Major = major,
                    University = university
                };
                _employeeManagement.addOrUpdateEmployee(intern);
            }
        }
        public void removeEmployee()
        {
            int id = inputBegin("Insert id for removing employee: ", 0);
            bool success = _employeeManagement.removeEmployee(id);
            if (success)
            {
                Console.WriteLine("Sucessfully remove employee");
            }
            else
                Console.WriteLine("No match employee");
        }
        public void listEmployees()
        {
            Console.WriteLine("Employee Count: {0}", _employeeManagement.employeeCount());
            Console.WriteLine("Type for Employee listed: 1.Experience 2.Fresher 3.Intern");
            int type = inputBetween("Select: ", 1, 3);
            var listEmployee = _employeeManagement.listType(type);
            foreach ( Employee employee in listEmployee )
            {
                Console.WriteLine(employee.FullName);
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
}
