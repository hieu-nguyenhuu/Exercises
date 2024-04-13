using Exercise_15.Comparators;
using Exercise_15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    internal class Service
    {
        private StudentManagement _studentManagement;
        private Validations _validations;
        public Service(StudentManagement studentManagement, Validations validations) 
        {
            _studentManagement = studentManagement;
            _validations = validations;

            initializeDB();
        }
        private void initializeDB()
        {
            Student student1 = new OfficialStudent
            {
                FullName = "Nguyen Huu Hieu",
                Birthday = DateTime.Parse("22/02/2001"),
                EntryYear = 2019,
                EntryGrade = 26,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20191, AverageGrade = 2.89},
                    new StudyResult{Semeter = 20192, AverageGrade = 2.91},
                    new StudyResult{Semeter = 20201, AverageGrade = 3.3},
                    new StudyResult{Semeter = 20202, AverageGrade = 3.5}
                }
            };
            Student student2 = new OfficialStudent
            {
                FullName = "Nguyen Dinh Hai",
                Birthday = DateTime.Parse("22/10/2002"),
                EntryYear = 2020,
                EntryGrade = 28,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20201, AverageGrade = 3.5},
                    new StudyResult{Semeter = 20202, AverageGrade = 3.2},
                    new StudyResult{Semeter = 20211, AverageGrade = 3.9}
                }
            };
            Student student3 = new InServiceStudent
            {
                FullName = "Nguyen Duy Nam",
                Birthday = DateTime.Parse("16/4/2000"),
                EntryYear = 2018,
                EntryGrade = 19,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20181, AverageGrade = 3.0},
                    new StudyResult{Semeter = 20182, AverageGrade = 2.19},
                    new StudyResult{Semeter = 20191, AverageGrade = 2.5}
                },
                LinkPlace = "BN"
            };
            Student student4 = new InServiceStudent
            {
                FullName = "Nguyen Van Vinh",
                Birthday = DateTime.Parse("18/03/1995"),
                EntryYear = 2020,
                EntryGrade = 22,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20201, AverageGrade = 3.2},
                    new StudyResult{Semeter = 20202, AverageGrade = 3.1},
                    new StudyResult{Semeter = 20211, AverageGrade = 2.9}
                },
                LinkPlace = "HY"
            };
            _studentManagement.addStudent(student1, "EE");
            _studentManagement.addStudent(student2, "EE");
            _studentManagement.addStudent(student3, "EE");
            _studentManagement.addStudent(student4, "EE");

            Student student5 = new OfficialStudent
            {
                FullName = "Nguyen The Duc",
                Birthday = DateTime.Parse("11/01/2001"),
                EntryYear = 2019,
                EntryGrade = 25,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20191, AverageGrade = 2.98},
                    new StudyResult{Semeter = 20192, AverageGrade = 2.7},
                    new StudyResult{Semeter = 20201, AverageGrade = 3.2},
                    new StudyResult{Semeter = 20202, AverageGrade = 3.3}
                }
            };
            Student student6 = new OfficialStudent
            {
                FullName = "Nguyen The Dat",
                Birthday = DateTime.Parse("22/10/2002"),
                EntryYear = 2020,
                EntryGrade = 24,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20201, AverageGrade = 3.0},
                    new StudyResult{Semeter = 20202, AverageGrade = 3.2},
                    new StudyResult{Semeter = 20211, AverageGrade = 2.5}
                }
            };
            Student student7 = new InServiceStudent
            {
                FullName = "Nguyen Van Khoi",
                Birthday = DateTime.Parse("16/4/2000"),
                EntryYear = 2018,
                EntryGrade = 19,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20181, AverageGrade = 3.0},
                    new StudyResult{Semeter = 20182, AverageGrade = 2.2},
                    new StudyResult{Semeter = 20191, AverageGrade = 2.8}
                },
                LinkPlace = "BN"
            };
            Student student8 = new InServiceStudent
            {
                FullName = "Nguyen Huu Huan",
                Birthday = DateTime.Parse("18/03/1995"),
                EntryYear = 2020,
                EntryGrade = 22,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult { Semeter = 20201, AverageGrade = 3.5 },
                    new StudyResult { Semeter = 20202, AverageGrade = 2.9 },
                    new StudyResult { Semeter = 20211, AverageGrade = 3.3 }
                },
                LinkPlace = "BG"
            };
            _studentManagement.addStudent(student5, "IT");
            _studentManagement.addStudent(student6, "IT");
            _studentManagement.addStudent(student7, "IT");
            _studentManagement.addStudent(student8, "IT");

            Student student9 = new OfficialStudent
            {
                FullName = "Nguyen Duy Dat",
                Birthday = DateTime.Parse("29/08/2001"),
                EntryYear = 2019,
                EntryGrade = 22,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20191, AverageGrade = 2.5},
                    new StudyResult{Semeter = 20192, AverageGrade = 2.9},
                    new StudyResult{Semeter = 20201, AverageGrade = 3.3},
                    new StudyResult{Semeter = 20202, AverageGrade = 3.0}
                }
            };
            Student student10 = new OfficialStudent
            {
                FullName = "Nguyen Thi Huyen",
                Birthday = DateTime.Parse("22/10/2000"),
                EntryYear = 2018,
                EntryGrade = 24,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20181, AverageGrade = 3.1},
                    new StudyResult{Semeter = 20182, AverageGrade = 2.5},
                    new StudyResult{Semeter = 20191, AverageGrade = 3.5}
                }
            };
            Student student11 = new InServiceStudent
            {
                FullName = "Nguyen Khanh Duy",
                Birthday = DateTime.Parse("16/4/2000"),
                EntryYear = 2018,
                EntryGrade = 25,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult{Semeter = 20181, AverageGrade = 3.0},
                    new StudyResult{Semeter = 20182, AverageGrade = 2.2},
                    new StudyResult{Semeter = 20191, AverageGrade = 3.5}
                },
                LinkPlace = "VP"
            };
            Student student12 = new InServiceStudent
            {
                FullName = "Dang Thi Uyen",
                Birthday = DateTime.Parse("02/04/2001"),
                EntryYear = 2020,
                EntryGrade = 25,
                StudyResults = new List<StudyResult>
                {
                    new StudyResult { Semeter = 20201, AverageGrade = 3.5 },
                    new StudyResult { Semeter = 20202, AverageGrade = 2.8 },
                    new StudyResult { Semeter = 20211, AverageGrade = 3.1 }
                },
                LinkPlace = "BN"
            };
            _studentManagement.addStudent(student9, "ET");
            _studentManagement.addStudent(student10, "ET");
            _studentManagement.addStudent(student11, "ET");
            _studentManagement.addStudent(student12, "ET");
        }
        public void addStudent()
        {
            Console.WriteLine("Type Student: 1.Official 2.InService");
            int studentType = inputInt("Select: ", 1, 2);
            Console.Write("Name: ");
            string? studentName = Console.ReadLine();
            bool success = false;
            DateTime birthday = DateTime.Now;
            while (!success)
            {
                Console.Write("Birthday (between 1900 - 2020): ");
                success = DateTime.TryParse(Console.ReadLine(), out birthday);
                //if (success && (birthday.Year > 2020 || birthday.Year < 1900))
                //    success = false;
            }
            _validations.checkBirthday(birthday);

            success = false;
            int entryYear = inputInt($"Entry Year (between 1990 - 2024): ");
            _validations.checkEntryYear(entryYear);
            int entryGrade = inputInt("Entry Grade (between 0 - 30): ");
            _validations.checkEntryGrade(entryGrade);

            Console.Write("Department Name: ");
            string? departmentName = Console.ReadLine();
            _validations.checkDepartmentExist(departmentName);

            int numberOfSemeter = inputInt("Number of semeter (between 1 - 10): ", 1, 10);
            List<StudyResult> studyResults = new List<StudyResult>();
            for(int i = 0; i < numberOfSemeter; i++)
            {
                int semeter = entryYear * 10 + i + 1;
                double average = inputDouble($"Semeter {semeter} Average Grade (between 0.0 - 4.0): ", 0, 4);
                studyResults.Add(new StudyResult { AverageGrade = average, Semeter = semeter });
            }
            string? place;
            Student newStudent;
            if (studentType == 2)
            {
                Console.Write("Link Place: ");
                place = Console.ReadLine();
                newStudent = new InServiceStudent
                {
                    FullName = studentName,
                    Birthday = birthday,
                    EntryGrade = entryGrade,
                    EntryYear = entryYear,
                    StudyResults = studyResults,
                    LinkPlace = place
                };
                _studentManagement.addStudent(newStudent, departmentName);
            }
            else
            {
                newStudent = new OfficialStudent
                {
                    FullName = studentName,
                    Birthday = birthday,
                    EntryGrade = entryGrade,
                    EntryYear = entryYear,
                    StudyResults = studyResults
                };
                _studentManagement.addStudent(newStudent, departmentName);
            }
        }
        public void checkStudent()
        {
            int inputId = -1;
            bool success = false;
            while (!success)
            {
                Console.Write("Input Student Id (id > 0): ");
                success = int.TryParse(Console.ReadLine(), out inputId);
                //if (success && inputId < 1)
                //    success = false;
            }
            Student? student = _studentManagement.findStudentById(inputId);
            if(student == null) 
                Console.WriteLine("Not Exist Student with id {0}", inputId);
            else if(student is  OfficialStudent)
                Console.WriteLine("Student with id {0} is Official Student", inputId);
            else
                Console.WriteLine("Student with id {0} is InService Student", inputId);
        }
        public void averageGradeOfStudent()
        {
            int inputId = inputInt("Input Student Id: ");
            _validations.checkStudentExist(inputId);
            int semeter = inputInt("Semeter of Student: ");
            var result = _studentManagement.averageGradeOfStudent(inputId, semeter);
            if (result == null)
                Console.WriteLine($"No Exist semeter {semeter} of Student id {inputId}");
            else
                Console.WriteLine($"Average grade of Student {inputId} in semeter {semeter} is {result}");
        }
        public void numberOfOfficialStudent()
        {
            Console.Write("Input Department Name: ");
            string? name = Console.ReadLine();
            _validations.checkDepartmentExist(name);
            var result = _studentManagement.numberOfOfficalStudent(name);
            Console.WriteLine($"Department {name?.ToUpper()} has {result} official students");
        }
        public void maxGradeStudents()
        {
            var result = _studentManagement.maxGradeStudents();
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Department.Name}: {student.FullName}, {student.EntryGrade}");
            }
        }
        public void inServiceStudent()
        {
            Console.Write("Input Place: ");
            string? place = Console.ReadLine();
            var result = _studentManagement.inServiceStudentWithPlace(place);
            foreach (var students in result)
            {
                if (students.Count > 0)
                {
                    Console.WriteLine($"{students.First().Department.Name}: ");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"\t{student.FullName} : {student.LinkPlace}");
                    }
                }
            }
        }
        public void studentWithAverageGrade()
        {
            var result = _studentManagement.studentsWithAverageGrade();
            foreach (var students in result)
            {
                if (students.Count > 0)
                {
                    Console.WriteLine($"{students.First().Department.Name}: ");
                    foreach(var student in students)
                        Console.WriteLine($"\t{student.FullName}: {student.StudyResults.Last().AverageGrade}");
                }
            }
        }
        public void highestGradeStudentEachDepartment()
        {
            var result = _studentManagement.highestGradeStudentEachDepartment();
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Department.Name}: {student.FullName}: {student.StudyResults.Max(r => r.AverageGrade)}");
            }
        }
        public void printStudentByDepartment()
        {
            Console.WriteLine("Before sorting");
            foreach (var department in _studentManagement.departments)
            {
                Console.WriteLine($"{department.Name}: ");
                foreach (var student in department.Students)
                    Console.WriteLine($"{student.FullName}");
            }
        }
        public void sortStudentTypeAsc()
        {
            Console.WriteLine("Sort student by type");
            foreach (var department in _studentManagement.departments)
            {
                Console.WriteLine($"{department.Name}: ");
                department.Students.Sort(new StudentTypeComparator());
                foreach(var student in department.Students)
                    Console.WriteLine($"{student.FullName}: {student}");
            }
        }
        public void sortStudentEntryYearDesc()
        {
            Console.WriteLine("Sort student by entry year");
            foreach (var department in _studentManagement.departments)
            {
                Console.WriteLine($"{department.Name}: ");
                department.Students.Sort(new EntryYearComparator());
                foreach (var student in department.Students)
                    Console.WriteLine($"{student.FullName}: {student.EntryYear}");
            }
        }
        public void studentStatisticByEntryYear()
        {
            var result = _studentManagement.studentStatisticsByEntryYear();
            foreach (var dictKey in result)
            {
                Console.WriteLine($"{dictKey.Key.Name}: ");
                foreach (var dictValue in dictKey.Value)
                {
                    Console.WriteLine($"\t{dictValue.Key}: {dictValue.Value} students");
                }
            }
        }
        private int inputInt(string inputString, int begin, int end)
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
        private int inputInt(string inputString)
        {
            bool success = false;
            int result = int.MinValue;
            while (!success)
            {
                Console.Write(inputString);
                success = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
        private double inputDouble(string inputString, double begin, double end)
        {
            bool success = false;
            double result = double.MinValue;
            while (!success)
            {
                Console.Write(inputString);
                success = double.TryParse(Console.ReadLine(), out result);
                if (success && (result > end || result < begin))
                    success = false;
            }
            return result;
        }
    }
}
