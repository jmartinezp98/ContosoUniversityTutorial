using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessEntity
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo LastName es Obligatorio")]
        [StringLength(35, ErrorMessage = "La Longitud es de 35 Caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo FirstMidName es Obligatorio")]
        [StringLength(50, ErrorMessage = "La longitud es de 50 Caracteres")]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = "El campo HireDate es Obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }

        public virtual ICollection<OfficeAsignment> OfficeAsignments  { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
