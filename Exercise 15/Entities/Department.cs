using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15.Entities
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
