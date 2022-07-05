using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class Assignment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Description must have value.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Format must have value.")]
        public string? Format { get; set; }
        [Required(ErrorMessage = "Binding Type must have value.")]
        public string? BindingType { get; set; }
        [Required(ErrorMessage = "Paper Type must have value.")]
        public string? PaperType { get; set; }
        public string? MachineType { get; set; }
        [Required(ErrorMessage = "Book Cover must have value.")]
        public string? BookCover { get; set; }
        [Required(ErrorMessage = "Book Cover Paper Type must have value.")]
        public string? BookCoverPaperType { get; set; }
        [Required(ErrorMessage = "Book Cover Plastic Type must have value.")]
        public string? BookCoverPlasticType { get; set; }
        public string? BookCoverAdditional { get; set; }
        public string? BookAdditional { get; set; }
        
        public WorkOrder? WorkOrder { get; set; }
    }
}
