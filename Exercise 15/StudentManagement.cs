using Exercise_15.Comparators;
using Exercise_15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    internal class StudentManagement
    {
        public List<Student> students { get; private set; } = new List<Student>();
        public List<Department> departments { get; private set; } = new List<Department> 
        {
            new Department{ Name = "EE"},
            new Department{ Name = "ET"},
            new Department{ Name = "IT"}
        };
        public Student? findStudentById(int id)
        {
            return students.FirstOrDefault(s => s.StudentId == id);
        }
        public bool isDepartmentExist(string? name)
        {
            return departments.Exists(s => s.Name == name?.ToUpper());
        }
        public void addStudent(Student student, string? departmentName)
        {
            departmentName = departmentName?.ToUpper();
            var department = departments.FirstOrDefault(d => d.Name == departmentName);
            if (department == null)
            {
                //department = new Department { Name = departmentName };
                //departments.Add(department);
                Console.WriteLine("Not Exist any department {0}", departmentName);
                return;
            }
            student.StudentId = students.Count + 1;
            department.Students.Add(student);
            student.Department = department;
            students.Add(student);
        }
        public double? averageGradeOfStudent(int studentId, int semeter)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            //if (student == null)
            //{
            //    return null;
            //}
            var result = student?.StudyResults.FirstOrDefault(r => r.Semeter == semeter);
            if (result == null)
            {
                return null;
            }
            return result.AverageGrade;
        }
        public int numberOfOfficalStudent(string? departmentName)
        {
            departmentName = departmentName?.ToUpper();
            var department = departments.FirstOrDefault(d => d.Name == departmentName);
            
            return department.Students.Where(s => s is OfficialStudent).Count();
        }
        public List<Student> maxGradeStudents()
        {
            var result = new List<Student>();
            foreach (var department in departments)
            {
                var student = department.Students.OrderByDescending(s => s.EntryGrade).FirstOrDefault();
                if (student != null)
                    result.Add(student);
            }
            return result;
        }
        public List<List<InServiceStudent>> inServiceStudentWithPlace(string? place)
        {
            var list = new List<List<InServiceStudent>>();
            foreach (var department in departments)
            {
                var students =  department.Students.OfType<InServiceStudent>()
                                                   .Where(s => s.LinkPlace.ToLower() == place?.ToLower())
                                                   .ToList();
                list.Add(students);
            }
            return list;
        }
        public List<List<Student>> studentsWithAverageGrade()
        {
            var list = new List<List<Student>>();
            foreach (var department in departments)
            {
                var students = department.Students.Where(s => s.StudyResults.Last().AverageGrade >= 3.2).ToList();
                list.Add(students);
            }
            return list;
        }
        public List<Student> highestGradeStudentEachDepartment()
        {
            var list = new List<Student>();
            foreach (var department in departments)
            {
                var student =  department.Students
                    .OrderByDescending(s => s.StudyResults.Max(r => r.AverageGrade))
                    .FirstOrDefault();
                if(student != null)
                    list.Add(student);
            }
            return list;
        }
        public List<Student> sortStudentTypeAsc()
        {
            students.Sort(new StudentTypeComparator());
            return students;
        }
        public List<Student> sortStudentEntryYearDesc() 
        {
            students.Sort(new EntryYearComparator());
            return students;
        }

        //Dict<Department, Dict<EntryYear, NumberOfStudent>>
        public Dictionary<Department, Dictionary<int, int>> studentStatisticsByEntryYear()
        {
            var dictResult = new Dictionary<Department, Dictionary<int, int>>();
            foreach (var department in departments)
            {
                var dict = new Dictionary<int, int>();
                foreach (var student in department.Students)
                {
                    dict.TryAdd(student.EntryYear, 0);
                }
                foreach(int i in dict.Keys)
                {
                    dict[i] = department.Students.Count(s => s.EntryYear == i);
                }
                dictResult.Add(department, dict);
            }
            return dictResult;
        }
    }
}
