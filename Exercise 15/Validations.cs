using Exercise_15.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    internal class Validations
    {
        private StudentManagement _studentManagement;
        public Validations(StudentManagement studentManagement) 
        {
            _studentManagement = studentManagement;
        }
        public void checkBirthday(DateTime birthday)
        {
            if (birthday.Year < 1900 || birthday.Year > 2020)
            {
                throw new BirthdayException("Birthday year must be between 1900 - 2020");
            }
        }
        public void checkEntryYear(int year)
        {
            if (year < 1990 || year > 2024)
                throw new Exception("Entry year must be between 1990 - 2024");
        }
        public void checkEntryGrade(int grade)
        {
            if ((grade < 0) || grade > 30)
            {
                throw new Exception("Entry grade must be between 0 - 30");
            }
        }
        public void checkDepartmentExist(string? name)
        {
            if (!_studentManagement.isDepartmentExist(name))
                throw new DepartmentException("No Exist Department");
        }
        public void checkStudentExist(int id)
        {
            if (_studentManagement.findStudentById(id) == null)
            {
                throw new Exception($"No Exist Student with id {id}");
            }
        }
    }
}
