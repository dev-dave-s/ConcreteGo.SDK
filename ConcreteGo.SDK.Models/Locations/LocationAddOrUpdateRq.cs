using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.locations
{
    [XmlRoot(ElementName = "LocationUpdate", Namespace = "")]
    public class LocationAddOrUpdateRq
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortName")]
        public string ShortName { get; set; } = string.Empty;

        [XmlElement(ElementName = "AddressLine1")]
        public string AddressLine1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "AddressLine2")]
        public string AddressLine2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "City")]
        public string City { get; set; } = string.Empty;

        [XmlElement(ElementName = "State")]
        public string State { get; set; } = string.Empty;

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; } = string.Empty;

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PhoneNumber1")]
        public string PhoneNumber1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "PhoneNumber2")]
        public string PhoneNumber2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; } = string.Empty;

        [XmlElement(ElementName = "CompanyID")]
        public int? CompanyID { get; set; }

        [XmlElement(ElementName = "CompanyCode")]
        public string CompanyCode { get; set; } = string.Empty;
    }
}
