using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.TaxAuthority
{
    [XmlRoot(ElementName = "TaxAuthorityRet")]
    public class TaxAuthorityRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "TaxBasedOn")]
        //1 : Taxable Sales, 2 : Taxable sales plus previous authorities' tax
        public int TaxBasedOn { get; set; }

        [XmlElement(ElementName = "PointOfTaxation")]
        public int PointOfTaxation { get; set; }

        [XmlElement(ElementName = "AllowReciprocation")]
        public bool AllowReciprocation { get; set; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; }
    }
}
