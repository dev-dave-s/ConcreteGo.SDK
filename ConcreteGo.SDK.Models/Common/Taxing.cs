using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common
{
    [XmlRoot(ElementName = "Taxing")]
    public class Taxing
    {

        [XmlElement(ElementName = "TaxID")]
        public int TaxID { get; set; }

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Taxable")]
        public string Taxable { get; set; } = string.Empty;

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; } = string.Empty;
        
        [XmlElement(ElementName = "TaxExcempt")]
        public TaxExcempt TaxExcempt{ get; set; }
    }
    
    
    [XmlRoot(ElementName = "TaxExcempt")]
    public class TaxExcempt
    {
        
        [XmlElement(ElementName = "TaxAuthorityCode")]
        public string TaxAuthorityCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "TaxExemptID")]
        public string TaxExemptID { get; set; } = string.Empty;
    }
}
