using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentWork.Models
{
    public class Register
    {
        [Key]
        public int user_id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string user_name { get; set; }
        [Required(ErrorMessage ="Required")]
        public string user_email { get; set; }
        [Required(ErrorMessage ="Required")]
        public string user_password { get; set; }
    }
}
