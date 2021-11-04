using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Employees
    {
        
        public int id { get; set; }
        
        [Required()]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$",ErrorMessage ="Name must start with uppercase and can only have letters")]
        [Display(Name="name")]
        [StringLength(20,MinimumLength =2,ErrorMessage ="Name must be between 2 and 20 characters")]
        public string Name{ get; set; }

        [Required()]
        [StringLength(30,MinimumLength =5,ErrorMessage ="Position must be between 5 and 20 characters")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Department can't be empty")]
        public string Department{ get; set; }

        [Required()]
        [EmailAddress()]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Grade can't be empty")]
        public int Grade{ get; set; }

        [Required(ErrorMessage = "Gender can't be empty")]
        public string Gender{ get; set; }
    }
}
