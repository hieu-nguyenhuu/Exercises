using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15.Exceptions
{
    internal class BirthdayException : Exception
    {
        public BirthdayException() { }
        public BirthdayException(string message) : base(message) { }
    }
}
