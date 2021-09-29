using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation_Assignment1.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            EmployeeList = new List<ItemList>()
           {
        new ItemList { Text = "Khushbu", Value = 1 },
        new ItemList { Text = "Mohan", Value = 2 },
        new ItemList { Text = "John", Value = 3 },
        new ItemList { Text = "Martin", Value = 4 },
        new ItemList { Text = "Due", Value = 5 }
           };
        }

        public int EmployeeId { get; set; }
        public List<ItemList> EmployeeList { get; set; }

    }
}
