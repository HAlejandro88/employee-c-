using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.models
{
    public class Employee
    {
        public int EmpoyeeId { get; set; }

        public string EmpoyeeName { get; set; }

        public string Department { get; set; }

        public string DateOfJoining { get; set; }

        public string PhotoFileName { get; set; }
    }
}
