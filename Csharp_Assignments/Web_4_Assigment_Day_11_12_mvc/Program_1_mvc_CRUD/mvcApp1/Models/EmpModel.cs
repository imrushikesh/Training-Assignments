using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcApp1.Models
{
    public class EmpModel
    {


        [Required (ErrorMessage ="Emp can not be blank")]
        [RegularExpression("\\d{2}", ErrorMessage= "no more than 3 digit")]

        public int empno { get; set; }

        [Required(ErrorMessage="emp name can not be blank")]
        [StringLength(50,MinimumLength =2)]

        public string empname { get; set; }

        [Required(ErrorMessage = "designation can not be blank")]
        [StringLength(50, MinimumLength = 2)]
        public string designation { get; set; }


        [Required(ErrorMessage = "Department name can not be blank")]
        [StringLength(50, MinimumLength = 2)]

        public string deptname { get; set; }
    }
}