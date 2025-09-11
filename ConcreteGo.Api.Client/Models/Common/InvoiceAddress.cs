using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Common
{
    [XmlRoot(ElementName = "InvoiceAddress")]
    public class InvoiceAddress
    {

        [XmlElement(ElementName = "Addr1")]
        public string Addr1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Addr2")]
        public string Addr2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "City")]
        public string City { get; set; } = string.Empty;

        [XmlElement(ElementName = "State")]
        public string State { get; set; } = string.Empty;

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; } = string.Empty;
    } 
}
