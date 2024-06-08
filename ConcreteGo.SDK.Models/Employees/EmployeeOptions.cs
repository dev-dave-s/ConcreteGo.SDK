using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.Employees
{
    public class EmployeeOptions
    {
        public List<int>? IDs { get; set; }
        public List<string>? Codes { get; set; }
        public List<int>? PlantIDs { get; set; }
        public List<string>? PlantCodes { get; set; }
        public List<string>? PlantTypes { get; set; }
        public bool? ListOnly { get; set; }
        public bool? IncludeInactive { get; set; }
    }
}
