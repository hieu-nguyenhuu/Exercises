using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13.Data
{
    internal class Experience : Employee
    {
        public Experience() 
        {
            Type = EmployeeType.Experience;
        }
        public int ExpInYear { get; set; }
        public string? ProSkill {  get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"{FullName}: {Phone}, {Email}, {Type}, Exp: {ExpInYear}, ProSkill: {ProSkill}");
        }
    }
}
