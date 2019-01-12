using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntity
{
    public class OfficeAsignment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Instructor")]
        [Required(ErrorMessage = "El campo InstructorId es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe de se un numero entero")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        [Required(ErrorMessage = "El campo Location es obligatorio")]
        [StringLength(30, ErrorMessage = "La longitud es de 30 Caracteres")]
        public string Location { get; set; }
    }
}
