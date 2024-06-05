using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.Items
{
    public class ItemRequestOptions
    {
        public bool? ListOnly { get; set; }
        public List<string>? Codes { get; set; }
        public List<string>? LocationCodes { get; set; }
        public List<int>? CategoryIds { get; set; }
        public List<string>? CategoryCodes { get; set; }
        public bool? IsConstituent { get; set; }
        public bool? KeepInInventory { get; set; }
        public bool? IsResaleable { get; set; }
        public bool? DoNotAllowTicketing { get; set; }
        public bool? Taxable { get; set; }
        public DateTime? FromUpdateDate { get; set; }
        public DateTime? ToUpdateDate { get; set; }
        public DateTime? FromCreateDate { get; set; }
        public DateTime? ToCreateDate { get; set; }
        public int? MaxReturned {  get; set; }
        public List<string>? IncludeRetElements { get; set; }
    }
}
