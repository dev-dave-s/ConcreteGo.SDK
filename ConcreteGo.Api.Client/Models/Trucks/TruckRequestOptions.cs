using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.Api.Client.Models.Trucks
{
    public class TruckRequestOptions
    {
        public List<int> Ids { get; set; } = new List<int>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<int> PlantIDs { get; set; } = new List<int>();
        public List<string> PlantCodes { get; set; } = new List<string>();
        public bool? ListOnly { get; set; }
        public bool? IncludeInactive { get; set; }
        public DateTime? FromStatusTimeStamp { get; set; }
        public DateTime? ToStatusTimeStamp { get; set; }
        public DateTime? FromLocationUpdateTime { get; set; }
        public DateTime? ToLocationUpdateTime { get; set; }
    }
}
