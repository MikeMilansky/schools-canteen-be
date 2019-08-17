using System;
using System.Collections.Generic;
using System.Text;
using SchoolCanteen.BE.Data.Entities;

namespace SchoolCanteen.BE.Data.Services
{
    public class StudentService
    {
        private static List<Student> students { get; set; }

        public StudentService()
        {
            students = new List<Student>();
            students.Add(new Student
            {
                Id = 1,
                Name = "Ivan",
                Surname = "Amelyanenka",
                Class = "1A",
                MoneyBalance = 10,
                School = "1"
            });
            students.Add(new Student
            {
                Id = 2,
                Name = "Dzmitry",
                Surname = "Ihnatsenka",
                Class = "1A",
                MoneyBalance = 10,
                School = "1"
            });
            students.Add(new Student
            {
                Id = 3,
                Name = "Nikita",
                Surname = "Reshetnikov",
                Class = "1A",
                MoneyBalance = 10,
                School = "1"
            });
            students.Add(new Student
            {
                Id = 4,
                Name = "Raman",
                Surname = "Laurinuyk",
                Class = "1A",
                MoneyBalance = 10,
                School = "1"
            });
            students.Add(new Student
            {
                Id = 5,
                Name = "Andrey",
                Surname = "Korolev",
                Class = "1A",
                MoneyBalance = 10,
                School = "1"
            });
        }

        public IEnumerable<Student> GetAll()
        {
            return students;
        }
    }
}
