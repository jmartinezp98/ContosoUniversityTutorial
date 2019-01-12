using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntity
{
    public class Course
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Title es obligatorio")]
        [StringLength(50, ErrorMessage = "La Longitud es de 20")]
        public string Title { get; set; }

        [Required(ErrorMessage = "El campo credits es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Debe de se un numero entero")]
        public int Credits { get; set; }
        [Required(ErrorMessage ="el campo es obligatorio")]
        [Range(0, int.MaxValue,ErrorMessage ="debe ser un numero entero")]
        [ForeignKey("Department")]
        public int departamentid { get; set; }
        public Department department { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
