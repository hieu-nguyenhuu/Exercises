using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13.Data
{
    internal class Intern : Employee
    {
        public Intern() 
        {
            Type = EmployeeType.Intern;
        }
        public string? Major {  get; set; }
        public string? University { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"{FullName}: {Phone}, {Email}, {Type}, Exp: {Major}, ProSkill: {University}");
        }
    }
}
