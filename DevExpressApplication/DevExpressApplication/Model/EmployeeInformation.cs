using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressApplication.Model
{
   public class EmployeeInformation
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string contact { get; set; }
        public string email { get; set; }

        public string gender { get; set; }

        public bool inCampus { get; set; }

        public DateTime dateOfJoin { get; set; }

    }
}
