using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment_01.Model
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        public int Duration { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Column("Top_ID")]
        public int TopId { get; set; }
    }
}
