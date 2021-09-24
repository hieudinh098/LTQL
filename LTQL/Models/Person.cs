using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "ID không được để trống")]
        public string PersonID { get; set; }
        
        [Required(ErrorMessage = "Tên không được để trống")]
        [MinLength(3)]
        public string PersonName { get; set; }
        

    }
}