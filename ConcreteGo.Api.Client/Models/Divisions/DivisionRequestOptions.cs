using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.Api.Client.Models.Divisions
{
    public class DivisionRequestOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> Codes { get; set; } = new List<string>();
        public List<string> Names { get; set; } = new List<string>();
        public List<string> IncludeRetElements { get; set; } = new List<string>();
    }
}
