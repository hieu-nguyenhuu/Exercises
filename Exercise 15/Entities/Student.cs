using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15.Entities
{
    internal abstract class Student
    {
        public int StudentId { get; set; }
        public string? FullName { get; set; }
        public DateTime Birthday { get; set; }
        public int EntryYear { get; set; }
        public int EntryGrade { get; set; }
        public Department Department { get; set; }
        public List<StudyResult> StudyResults { get; set; } = new List<StudyResult>();
    }
}
