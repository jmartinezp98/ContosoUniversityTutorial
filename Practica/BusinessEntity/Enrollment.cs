using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntity
{
     public class Enrollment
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Course")]
        [Required(ErrorMessage = "El campo CouseId es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe de se un numero entero")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Student")]
        [Required(ErrorMessage = "El campo StudentId es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe de se un numero entero")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required(ErrorMessage = "El campo Grade es obligatorio")]
        [StringLength(5, ErrorMessage = "La longitud es de 5 caracteres")]
        public string grade { get; set; } 
    }
}
