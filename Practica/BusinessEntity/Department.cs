using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntity
{
    public class Department
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo Name es Obligatorio")]
        [StringLength(25, ErrorMessage = "La longitud es de 25 Caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Campo budget es Obligatorio")]
        [Range(0, float.MaxValue, ErrorMessage = "Ingrear dato de tipo Float")]
        public float budget { get; set; }

        [Required(ErrorMessage = "El campo StartDate es Obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [ForeignKey("Instructor")]
        [Required(ErrorMessage = "El Campo InstructorId es Obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Ingresar dato de tipo entero")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
