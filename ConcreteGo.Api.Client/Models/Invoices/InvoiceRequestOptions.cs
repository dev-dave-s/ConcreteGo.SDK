using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.Api.Client.Models.Invoices
{
    public class InvoiceRequestOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> InvoiceNumbers { get; set; } = new List<string>();
        public List<int> CustomerIDs { get; set; } = new List<int>();
        public List<string> CustomerCodes { get; set; } = new List<string>();
        public List<string> CustomerNames { get; set; } = new List<string>();
        public List<int> DivisionIDs { get; set; } = new List<int>();
        public List<string> DivisionCodes { get; set; } = new List<string>();
        public DateTime? FromInvoiceDate { get; set; }
        public DateTime? ToInvoiceDate { get; set; }
        public bool? ListOnly { get; set; }
        public bool? IncludeRemovedInvoice { get; set; }
    }
}
