using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.UOMs
{
    public class UOMRequestOptions
    {
        public List<int>? IDs { get; set; }
        public List<string>? Codes { get; set; }
        public List<string>? Names { get; set; }
    }
}
