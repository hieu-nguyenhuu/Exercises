using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Exceptions
    {
        public class BirthdayException : Exception 
        {
            public BirthdayException() { }
            public BirthdayException(string message) : base(message) { }
        }
        public class PhoneException : Exception
        {
            public PhoneException() { }
            public PhoneException(string message) : base(message) { }
        }
        public class EmailException : Exception
        {
            public EmailException() { }
            public EmailException(string message) : base(message) { }
        }
    }
}
