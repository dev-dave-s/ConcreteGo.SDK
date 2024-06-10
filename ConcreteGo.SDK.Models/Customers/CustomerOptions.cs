using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.Customers
{
    public class CustomerOptions
    {
        public List<int>? IDs { get; set; }
        public List<string>? Codes { get; set; }
        public List<string>? Names { get; set; }
        public int? MaxReturned { get; set; }
        public bool? ListOnly { get; set; }
        public bool? InActive { get; set; }
        public DateTime? FromSetupDate { get; set; }
        public DateTime? ToSetupDate { get; set; }
        public DateTime? FromUpdateDate { get; set; }
        public DateTime? ToUpdateDate { get; set; }
        public List<string>? SalesAnalysisCodes { get; set; }
        public List<string>? SalesmanCodes { get; set; }
        public List<string>? SalesmanNames { get; set; }
        public List<string>? PriceCategoryCodes { get; set; }
        public List<string>? PricingPlantCodes { get; set; }
        public List<string>? TermsCodes { get; set; }
        public List<string>? ZoneCodes { get; set; }
        public List<string>? StatementCycles { get; set; }
        public List<string>? AccountingCategoryCodes { get; set; }
        //SUNDRYCHARGE, USERDEFINEDFIELD
        public List<string>? IncludeRetElement { get; set; }
    }
}
