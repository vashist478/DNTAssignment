using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation_Assignment1.Models
{
    public class CascadingModel
    {
        public IEnumerable<Country> Country { get; set; }
        public IEnumerable<State> State { get; set; }
        public IEnumerable<UserViewModel> EmployeeList { get; set; }
    }
}
