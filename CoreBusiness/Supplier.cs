using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "NameOfAGood is incorrect.")]
        public string? Name { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "OIB is incorrect.")]
        public string? OIB { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Mail is incorrect.")]
        public string? Mail { get; set; }
        public string? MobilePhone { get; set; }
        [Required]
        public string? Location { get; set; }
        public InputData? InputData { get; set; }
    }
}
