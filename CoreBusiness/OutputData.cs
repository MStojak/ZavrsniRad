using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class OutputData
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Client must have a value.")]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Book must have a name.")]
        public string? BookName { get; set; }
        [Required(ErrorMessage = "Must have value for a book count.")]
        public int BookCount { get; set; }
        public DateTime Deadline { get; set; }
        public int PackageCount { get; set; }
        public bool CertifyDeliveryNote { get; set; } = false;
        public bool IsDone { get; set; }
        public string? Location { get; set; }
        public string? Contact { get; set; }

        public Client? Client { get; set; }

    }
}
