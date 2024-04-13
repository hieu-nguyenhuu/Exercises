using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15.Exceptions
{
    internal class DepartmentException : Exception
    {
        public DepartmentException() { }
        public DepartmentException(string message) : base(message) { }
    }
}
