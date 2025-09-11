using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.Api.Client.Models.ItemTypes
{
    public class ItemTypeOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> Names { get; set; } = new List<string>();
    }
}
