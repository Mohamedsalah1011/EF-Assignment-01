using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment_01.Model
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }

        [MaxLength(100)]
        public string Adress { get; set; }

        public decimal HourRate { get; set; }

        [Column("Dept_ID")]
        public int DeptId { get; set; }

        [ForeignKey("Dept_ID")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Course_Inst> CourseInsts { get; set; }
    }

}
