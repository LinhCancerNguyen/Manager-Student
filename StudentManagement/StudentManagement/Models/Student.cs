using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Class { get; set; }

    }
}
