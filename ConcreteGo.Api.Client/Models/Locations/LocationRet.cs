using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Locations
{
    [XmlRoot(ElementName = "LocationRet")]
    public class LocationRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "ShortName")]
        public string ShortName { get; set; }

        [XmlElement(ElementName = "AddressLine1")]
        public string AddressLine1 { get; set; }

        [XmlElement(ElementName = "AddressLine2")]
        public string AddressLine2 { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "State")]
        public string State { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "PhoneNumber1")]
        public string PhoneNumber1 { get; set; }

        [XmlElement(ElementName = "PhoneNumber2")]
        public string PhoneNumber2 { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "CompanyID")]
        public int? CompanyID { get; set; }

        [XmlElement(ElementName = "CompanyCode")]
        public string CompanyCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Divisions")]
        public Divisions Divisions { get; set; }
    }

    [XmlRoot(ElementName = "Divisions")]
    public class Divisions
    {

        [XmlElement(ElementName = "Division")]
        public Division Division { get; set; }
    }

    [XmlRoot(ElementName = "Division")]
    public class Division
    {

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }
}
