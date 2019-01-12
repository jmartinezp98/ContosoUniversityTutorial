using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessEntity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo LastName es obligatorio")]
        [StringLength(35, ErrorMessage = "La longitud es de 35")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo FirtsMidName es obligatorio")]
        [StringLength(50, ErrorMessage = "La Longitud es de 50")]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = "El campo EnrollmentDate es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}
