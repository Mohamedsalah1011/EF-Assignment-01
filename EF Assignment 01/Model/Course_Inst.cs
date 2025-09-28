using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Assignment_01.Model
{
    public class Course_Inst
    {
        [Key]
        [Column(Order = 0)]
        public int inst_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Course_ID { get; set; }

        [MaxLength(200)]
        public string evaluate { get; set; }

        [ForeignKey("inst_ID")]
        public virtual Instructor Instructor { get; set; }

        [ForeignKey("Course_ID")]
        public virtual Course Course { get; set; }
    }
}
