using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Plants
{
    [XmlRoot(ElementName = "PlantUpdate", Namespace = "")]
    public class PlantAddOrUpdateRq
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Action")]
        public string Action { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "Address1")]
        public string Address1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Address2")]
        public string Address2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Address3")]
        public string Address3 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [XmlElement(ElementName = "LocationID")]
        public int? LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CompanyID")]
        public int? CompanyID { get; set; }

        [XmlElement(ElementName = "CompanyCode")]
        public string CompanyCode { get; set; } = string.Empty;
    }
}
