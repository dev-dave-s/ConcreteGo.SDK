using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common
{
    [XmlRoot(ElementName = "InvoiceAddress")]
    public class InvoiceAddress
    {

        [XmlElement(ElementName = "Addr1")]
        public object Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public object Addr2 { get; set; }

        [XmlElement(ElementName = "City")]
        public object City { get; set; }

        [XmlElement(ElementName = "State")]
        public object State { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public object PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public object Country { get; set; }
    }
}
