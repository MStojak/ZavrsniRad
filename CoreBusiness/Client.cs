using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CoreBusiness
{
    public class Client
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name must have value.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Adress must have value.")]
        public string? Adress { get; set; }
        [Required(ErrorMessage = "OIB must have value.")]
        public string? OIB { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public OutputData? OutputData { get; set; }
        public WorkOrder? WorkOrder { get; set; }
    }
}
