using ConcreteGo.SDK.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Projects
{
    [XmlRoot(ElementName = "ProjectRet")]
    public class ProjectRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "CustomerID")]
        public int CustomerID { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime SetupDate { get; set; }

        [XmlElement(ElementName = "DeliveryAddress")]
        public DeliveryAddress DeliveryAddress { get; set; }

        [XmlElement(ElementName = "Instruction")]
        public Instruction Instruction { get; set; }

        [XmlElement(ElementName = "InvoiceAddress")]
        public InvoiceAddress InvoiceAddress { get; set; }

        [XmlElement(ElementName = "StatementAddress")]
        public StatementAddress StatementAddress { get; set; }

        [XmlElement(ElementName = "Contact")]
        public string Contact { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "Cellular")]
        public string Cellular { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "CustomerJob")]
        public string CustomerJob { get; set; }

        [XmlElement(ElementName = "PurchaseOrder")]
        public string PurchaseOrder { get; set; }

        [XmlElement(ElementName = "ExpirationDate")]
        public string ExpirationDate { get; set; }

        [XmlElement(ElementName = "ShippingCustomerCode")]
        public string ShippingCustomerCode { get; set; }

        [XmlElement(ElementName = "ReferenceCustomerCode")]
        public string ReferenceCustomerCode { get; set; }

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; }

        [XmlElement(ElementName = "Taxing")]
        public Taxing Taxing { get; set; }

        [XmlElement(ElementName = "Pricing")]
        public Pricing Pricing { get; set; }

        [XmlElement(ElementName = "Charges")]
        public Charges Charges { get; set; }

        [XmlElement(ElementName = "Accounting")]
        public Accounting Accounting { get; set; }

        [XmlElement(ElementName = "Distribution")]
        public Distribution Distribution { get; set; }

        [XmlElement(ElementName = "EnablePriceEscalation")]
        public bool EnablePriceEscalation { get; set; }

        [XmlElement(ElementName = "PriceEscalationAmount")]
        public string _PriceEscalationAmount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? PriceEscalationAmount { get { if (double.TryParse(_PriceEscalationAmount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PriceEscalationDate")]
        public string _PriceEscalationDate { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? PriceEscalationDate { get { if (DateTime.TryParse(_PriceEscalationDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Latitude")]
        public string Latitude { get; set; }

        [XmlElement(ElementName = "Longitude")]
        public string Longitude { get; set; }

        [XmlElement(ElementName = "JobsiteRadius")]
        public string _JobSiteRadius { get; set; }
        [XmlIgnore]
        public int? JobsiteRadius { get { if (int.TryParse(_JobSiteRadius, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [XmlElement(ElementName = "CustomerRet")]
        public CustomerRet CustomerRet { get; set; }
    }

    [XmlRoot(ElementName = "DeliveryAddress")]
    public class DeliveryAddress
    {

        [XmlElement(ElementName = "Addr1")]
        public object Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public object Addr2 { get; set; }

        [XmlElement(ElementName = "Addr3")]
        public object Addr3 { get; set; }
    }

    [XmlRoot(ElementName = "Instruction")]
    public class Instruction
    {

        [XmlElement(ElementName = "Instruction1")]
        public object Instruction1 { get; set; }

        [XmlElement(ElementName = "Instruction2")]
        public object Instruction2 { get; set; }

        [XmlElement(ElementName = "Instruction3")]
        public object Instruction3 { get; set; }
    }
}
