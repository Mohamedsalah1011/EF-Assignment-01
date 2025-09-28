using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Assignment_01.Model
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string FName { get; set; }

        [Required, MaxLength(50)]
        public string LName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public int Age { get; set; }

        [Column("Dep_Id")]
        public int DepId { get; set; }

        [ForeignKey("Dep_Id")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Stud_Course> StudCourses { get; set; }
    }
}
