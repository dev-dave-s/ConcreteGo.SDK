using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common {
    [XmlRoot(ElementName = "InvoiceAddress")]
    public class InvoiceAddressRq {

        [XmlElement(ElementName = "Name")]
        public string? Name { get; set; }

        [XmlElement(ElementName = "Addr1")]
        public string? Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public string? Addr2 { get; set; }
    
        [XmlElement(ElementName = "City")]
        public string? City { get; set; }
    
        [XmlElement(ElementName = "State")]
        public string? State { get; set; }
    
        [XmlElement(ElementName = "PostalCode")]
        public string? PostalCode { get; set; }
    
        [XmlElement(ElementName = "Country")]
        public string? Country { get; set; }
    
    }
}