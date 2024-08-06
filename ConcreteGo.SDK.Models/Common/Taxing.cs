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
        public object TaxID { get; set; }

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public string Taxable { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public object NonTaxableReasonCode { get; set; }
    }
}
