using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Common.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
      public List<LeaveAllocationVM> LeaveAllocations { get; set; } //Declares a list of type leaveallocationsvm
    }
}
