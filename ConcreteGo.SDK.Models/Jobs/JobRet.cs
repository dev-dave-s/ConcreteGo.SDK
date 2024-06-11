using ConcreteGo.SDK.Models.Customers;
using ConcreteGo.SDK.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Jobs
{
    public class JobRet
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

        [XmlElement(ElementName = "Owner")]
        public string Owner { get; set; }

        [XmlElement(ElementName = "Architect")]
        public string Architect { get; set; }

        [XmlElement(ElementName = "Engineer")]
        public string Engineer { get; set; }

        [XmlElement(ElementName = "GeneralContractor")]
        public string GeneralContractor { get; set; }

        [XmlElement(ElementName = "JobBidDate")]
        public string _JobBidDate { get; set; } = string.Empty;

        public DateTime? JobBidDate { get { if (DateTime.TryParse(_JobBidDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "JobAwardDate")]
        public string _JobAwardDate { get; set; } = string.Empty;
        public DateTime? JobAwardDate { get { if (DateTime.TryParse(_JobAwardDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "JobBeginDate")]
        public string _JobBeginDate { get; set; } = string.Empty;
        public DateTime? JobBeginDate { get { if (DateTime.TryParse(_JobBeginDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "JobCompletionDate")]
        public string _JobCompletionDate { get; set; } = string.Empty;
        public DateTime? JobCompletionDate { get { if (DateTime.TryParse(_JobCompletionDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UpdateDate")]
        public string _UpdateDate { get; set;} = string.Empty;
        public DateTime? UpdateDate { get { if (DateTime.TryParse(_UpdateDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "CustomerRet")]
        public CustomerRet CustomerRet { get; set; }
    }
}
