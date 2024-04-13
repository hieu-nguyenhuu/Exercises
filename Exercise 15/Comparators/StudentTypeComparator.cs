using Exercise_15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15.Comparators
{
    internal class StudentTypeComparator : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x is OfficialStudent && y is InServiceStudent)
                return 1;
            else if (x is InServiceStudent && y is OfficialStudent) 
                return -1;
            else return 0;
        }
    }
}
