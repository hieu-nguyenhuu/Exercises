using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise_13.Exceptions;

namespace Exercise_13
{
    internal class Validations
    {
        public void phoneValidate(string? phone)
        {
            if (phone == null || phone.Length != 11) throw new PhoneException("Phone must have 11 numbers");
            if (phone[0] != '8' || phone[1] != '4') throw new PhoneException("Phone number must start with 84");
        }
        public void emailvalidate(string? email)
        {
            if (!email.ToLower().EndsWith("@fpt.com")) throw new EmailException("Email have to end with @fpt.com");
        }
        public void birthdayValidate(string? birthday, out DateTime validBirthday)
        {
            var success = DateTime.TryParse(birthday, out validBirthday);
            if (!success) { throw new BirthdayException("Invalid birthday"); }
            else if (validBirthday.Year < 1900 || validBirthday.Year > 2024)
                throw new BirthdayException("Year of birth must between 1900 and 2024");
        }
    }
}
