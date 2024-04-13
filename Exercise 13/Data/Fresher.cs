using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13.Data
{
    internal class Fresher : Employee
    {
        public Fresher() 
        {
            Type = EmployeeType.Fresher;
        }
        public DateTime GraduationDate { get; set; }
        public string? GraduationRank { get; set; }
        public string? Education {  get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"{FullName}: {Phone}, {Email}, {Type}, Exp: {GraduationRank}, ProSkill: {Education}");
        }
    }
}
