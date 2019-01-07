using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    interface IStudent
    {
        IEnumerable<Student> GetStudents { get; }
        Student GetStudent(int Id);
        void Add(Student _Student);
        void Edit(int Id);
        void Remove(int Id);
    }
}
