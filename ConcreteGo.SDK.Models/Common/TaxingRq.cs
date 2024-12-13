using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common {
    [XmlRoot(ElementName = "Taxing")]
    public class TaxingRq {

        [XmlElement(ElementName = "TaxID")]
        public string? TaxID { get; set; }
        public bool ShouldSerializeTaxID() { return TaxID != null; }

        [XmlElement(ElementName = "TaxCode")]
        public string? TaxCode { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public bool? Taxable { get; set; }
        public bool ShouldSerializeTaxable() { return Taxable != null; }
    
        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; }
    
        [XmlElement(ElementName = "TaxExcempt")]
        public List<TaxExcemptRq>? TaxExcempt { get; set; } = new List<TaxExcemptRq>();
    
    }

    [XmlRoot(ElementName = "TaxExcempt")]
    public class TaxExcemptRq {

        [XmlElement(ElementName = "TaxAuthorityCode")]
        public string? TaxAuthorityCode { get; set; }

        [XmlElement(ElementName = "TaxExemptID")]
        public string? TaxExemptID { get; set; }
    
    }
}