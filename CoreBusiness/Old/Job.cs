using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness.Old
{
    public class Job
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category must have value.")]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "NameOfAGood is too long.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Supplier must be named.")]
        public int SupplierId { get; set; }
        public DateOnly? Deadline { get; set; }
        public string? Location { get; set; }
        [Required(ErrorMessage = "Have to describe the job.")]
        public string? Description { get; set; }
        public bool IsTaken { get; set; }
        public bool IsDone { get; set; }
    }
}
