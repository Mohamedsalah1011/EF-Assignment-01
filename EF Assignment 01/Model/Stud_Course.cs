using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Assignment_01.Model
{
    public class Stud_Course
    {
        [Key]
        [Column(Order = 0)]
        public int stud_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Course_ID { get; set; }

        public int Grade { get; set; }
    }
}
