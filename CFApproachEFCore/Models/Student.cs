using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFApproachEFCore.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("StudentName", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(10)")]
        public string Gender { get; set; }

        public int Age { get; set; }

        public int Standard { get; set; }
    }
}
