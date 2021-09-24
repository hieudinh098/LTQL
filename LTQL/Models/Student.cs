using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    public class Student
    {[Key]
        public String StudentID { get; set; }
        public String StudentName { get; set; }
    }
}