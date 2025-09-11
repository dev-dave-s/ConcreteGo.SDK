using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Employees
{
    [XmlRoot(ElementName = "EmployeeRet")]
    public class EmployeeRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Active")]
        public bool Active { get; set; }

        [XmlElement(ElementName = "EmployeeType")]
        public string EmployeeType { get; set; }

        [XmlElement(ElementName = "Address1")]
        public string Address1 { get; set; }

        [XmlElement(ElementName = "Address2")]
        public string Address2 { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "State")]
        public string State { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "PhoneExt")]
        public string PhoneExt { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "PlantID")]
        public string _PlantID { get; set; }
        [XmlIgnore]
        public int? PlantID
        {
            get
            {
                if (int.TryParse(_PlantID, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; }

        [XmlElement(ElementName = "Payroll")]
        public string Payroll { get; set; }
    }
}
