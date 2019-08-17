using System;

namespace SchoolCanteen.BE.Entities.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal MoneyBalance { get; set; }
        public string Class { get; set; }
        public string School { get; set; }
    }
}
