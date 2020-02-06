using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentWork.Models
{
    public class list
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string name { get; set; }
    }
}
