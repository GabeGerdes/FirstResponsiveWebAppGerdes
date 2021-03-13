using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FirstResponsiveWebAppGerdes.Models
{
    public class AgeFinder
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please use a number.")]
        [Range(1900,2021, ErrorMessage ="Please use a number between 2021 and 1900.")]
        public int? BirthYear { get; set; }

        public int? AgeThisYear()
        {
            int? age = 0;
            const int thisYear = 2021;
            age = thisYear - BirthYear;
            return age;
        }
    }
}
