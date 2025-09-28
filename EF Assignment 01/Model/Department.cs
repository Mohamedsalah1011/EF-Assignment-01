using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Assignment_01.Model
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Column("Ins_ID")]
        public int InsId { get; set; }

        public DateTime HiringDate { get; set; }

        [ForeignKey("Ins_ID")]
        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
