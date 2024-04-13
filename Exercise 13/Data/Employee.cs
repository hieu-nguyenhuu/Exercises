using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13.Data
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Phone {  get; set; }
        public string? Email { get; set; }
        public EmployeeType Type { get; protected set; }
        public static int Employee_Count { get; set; }
        public List<Certificate> Certificates { get; set; } = new List<Certificate>();
        public abstract void ShowInfo();
    }
    public enum EmployeeType
    {
        Experience = 1, Fresher, Intern
    }
}
