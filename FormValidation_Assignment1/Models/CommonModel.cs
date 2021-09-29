using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation_Assignment1.Models
{
    public class CommonModel
    {

        public IEnumerable<EmployeeViewModel> Teachers { get; set; }
        public IEnumerable<UserViewModel> Students { get; set; }
    }
}
