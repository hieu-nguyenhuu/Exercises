using Exercise_15.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15.Comparators
{
    internal class EntryYearComparator : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x?.EntryYear > y?.EntryYear) return -1;
            else if (x?.EntryYear < y?.EntryYear) return 1;
            return 0;   
        }
    }
}
