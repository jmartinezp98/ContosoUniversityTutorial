using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    class Enrollment
    {
        
        public int Id { get; set; }

        
        public int CourseId { get; set; }


        public Course Course { get; set; }

        
        public int StudentId { get; set; }

        
        public string Grade { get; set; }
    }
}
