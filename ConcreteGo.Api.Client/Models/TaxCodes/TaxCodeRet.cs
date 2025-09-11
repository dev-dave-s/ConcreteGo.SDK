using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.TaxCodes
{
    [XmlRoot(ElementName = "TaxCodeRet")]
    public class TaxCodeRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "TaxLocations")]
        public TaxLocations TaxLocations { get; set; }
    }

    [XmlRoot(ElementName = "TaxLocations")]
    public class TaxLocations
    {

        [XmlElement(ElementName = "TaxLocation")]
        public TaxLocation TaxLocation { get; set; }
    }

    [XmlRoot(ElementName = "TaxLocation")]
    public class TaxLocation
    {

        [XmlElement(ElementName = "TaxAuthorityID")]
        public int TaxAuthorityID { get; set; }

        [XmlElement(ElementName = "TaxAuthorityCode")]
        public string TaxAuthorityCode { get; set; }

        [XmlElement(ElementName = "TaxLocationID")]
        public int TaxLocationID { get; set; }

        [XmlElement(ElementName = "TaxLocationCode")]
        public string TaxLocationCode { get; set; }
    }
}
