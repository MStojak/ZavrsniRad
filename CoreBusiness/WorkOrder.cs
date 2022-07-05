using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class WorkOrder
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Client must have value.")]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "Assignment must have value.")]
        public int AssignmentId { get; set; }
        [Required(ErrorMessage = "Book must have name.")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "You must enter a value for total number of books in this work order.")]
        public int TotalNumberOfBooks { get; set; }
        public int NumberOfBooksInPackage { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDone { get; set; }

        public Client? Client { get; set; }
        public Assignment? Assignment { get; set; }
    }
}
