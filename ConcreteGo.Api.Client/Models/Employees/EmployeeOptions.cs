using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.Api.Client.Models.Employees
{
    public class EmployeeOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<int> PlantIDs { get; set; } = new List<int>();
        public List<string> PlantCodes { get; set; } = new List<string>();
        public List<string> PlantTypes { get; set; } = new List<string>();
        public bool? ListOnly { get; set; }
        public bool? IncludeInactive { get; set; }
    }
}
