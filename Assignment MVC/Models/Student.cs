using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPROJ.Models
{
    public class Student
    {
       
        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
      
        public string Class { get; set; }

        [ForeignKey("SubjectId")]
        [Display(Name="Subject")]

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

    }
}
