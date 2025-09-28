using System.ComponentModel.DataAnnotations;

namespace EF_Assignment_01.Model
{
    public class Topic
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
