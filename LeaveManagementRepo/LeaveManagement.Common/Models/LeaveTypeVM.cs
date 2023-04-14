using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required] // You have to have an input of type ID in this instance

        public string Name { get; set; }

        [Display(Name = "Default Number Of Days")] // Changes the 'DefaultDays to this instead.
        [Required]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]
        public int DefaultDays { get; set; }


    }
}
