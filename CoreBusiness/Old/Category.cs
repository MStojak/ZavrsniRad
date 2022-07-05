using System.ComponentModel.DataAnnotations;

namespace CoreBusiness.Old
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "NameOfAGood is incorrect.")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }
    }
}