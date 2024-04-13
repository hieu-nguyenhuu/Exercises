using Exercise_13.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class EmployeeManagement
    {
        public List<Employee> employees { get; private set; } = new List<Employee>();
        public Employee? findById(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }
        public void addOrUpdateEmployee(Employee employee)
        {
            var emp = findById(employee.Id);
            if(emp != null)
            {
                if(emp.Type == EmployeeType.Experience)
                {
                    var newEmp = emp as Experience;
                    var updateEmp = employee as Experience;
                    newEmp.FullName = updateEmp.FullName;
                    newEmp.BirthDay = updateEmp.BirthDay;
                    newEmp.Phone = updateEmp.Phone;
                    newEmp.Certificates = updateEmp.Certificates;
                    newEmp.Email = updateEmp.Email;
                    newEmp.ExpInYear = updateEmp.ExpInYear;
                    newEmp.ProSkill = updateEmp.ProSkill;
                }
                if (emp.Type == EmployeeType.Fresher)
                {
                    var newEmp = emp as Fresher;
                    var updateEmp = employee as Fresher;
                    newEmp.FullName = updateEmp.FullName;
                    newEmp.BirthDay = updateEmp.BirthDay;
                    newEmp.Phone = updateEmp.Phone;
                    newEmp.Certificates = updateEmp.Certificates;
                    newEmp.Email = updateEmp.Email;
                    newEmp.GraduationDate = updateEmp.GraduationDate;
                    newEmp.GraduationRank = updateEmp.GraduationRank;
                    newEmp.Education = updateEmp.Education;
                }
                else
                {
                    var newEmp = emp as Intern;
                    var updateEmp = employee as Intern;
                    newEmp.FullName = updateEmp.FullName;
                    newEmp.BirthDay = updateEmp.BirthDay;
                    newEmp.Phone = updateEmp.Phone;
                    newEmp.Certificates = updateEmp.Certificates;
                    newEmp.Email = updateEmp.Email;
                    newEmp.Major = updateEmp.Major;
                    newEmp.University = updateEmp.University;
                }
            }
            else
            {
                employees.Add(employee);
                Employee.Employee_Count++;
            }
                
        }
        public bool removeEmployee(int id)
        {
            var removeEmployee = findById(id);
            if (removeEmployee != null)
            {
                employees.Remove(removeEmployee);
                Employee.Employee_Count--;
                return true;
            }
            else return false;
        }
        public List<Employee> listType(int i)
        {
            return employees.Where(e => e.Type == (EmployeeType)i).ToList();
        }
        public int employeeCount()
        {
            return Employee.Employee_Count;
        }
    }
}
