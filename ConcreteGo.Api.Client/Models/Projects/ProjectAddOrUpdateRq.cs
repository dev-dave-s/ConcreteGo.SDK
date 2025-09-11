using ConcreteGo.Api.Client.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Projects
{
    [XmlRoot(ElementName = "ProjectUpdate", Namespace = "")]
    public class ProjectAddOrUpdateRq
    {

        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string? Name { get; set; }

        [XmlElement(ElementName = "CustomerID")]
        public int? CustomerID { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string? CustomerCode { get; set; }

        [XmlElement(ElementName = "CustomerName")]
        public string? CustomerName { get; set; }

        [XmlElement("Action")] // add, edit, update, delete.
        public string Action { get; set; } = string.Empty;

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }

        [XmlElement(ElementName = "DeliveryAddress")]
        public DeliveryAddress? DeliveryAddress { get; set; }

        [XmlElement(ElementName = "InvoiceAddress")]
        public InvoiceAddress? InvoiceAddress { get; set; }

        [XmlElement(ElementName = "StatementAddress")]
        public StatementAddress? StatementAddress { get; set; }

        [XmlElement(ElementName = "Contact")]
        public string? Contact { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string? Phone { get; set; }

        [XmlElement(ElementName = "Fax")]
        public string? Fax { get; set; }

        [XmlElement(ElementName = "Cellular")]
        public string? Cellular { get; set; }

        [XmlElement(ElementName = "Email")]
        public string? Email { get; set; }

        [XmlElement(ElementName = "RecipientEmail")]
        public string? RecipientEmail { get; set; }

        [XmlElement(ElementName = "CustomerJob")]
        public string? CustomerJob { get; set; }

        [XmlElement(ElementName = "PurchaseOrder")]
        public string? PurchaseOrder { get; set; }

        [XmlElement(ElementName = "ExpirationDate")]
        public string? ExpirationDate { get; set; }

        [XmlElement(ElementName = "ShippingCustomerCode")]
        public string? ShippingCustomerCode { get; set; }

        [XmlElement(ElementName = "ReferenceCustomerCode")]
        public string? ReferenceCustomerCode { get; set; }

        [XmlElement(ElementName = "Sales")]
        public Sales? Sales { get; set; }

        [XmlElement(ElementName = "Taxing")]
        public Taxing? Taxing { get; set; }

        [XmlElement(ElementName = "Pricing")]
        public Pricing? Pricing { get; set; }

        [XmlElement(ElementName = "Charges")]
        public Charges? Charges { get; set; }

        [XmlElement(ElementName = "Accounting")]
        public Accounting? Accounting { get; set; }

        [XmlElement(ElementName = "Distribution")]
        public Distribution? Distribution { get; set; }

        [XmlElement(ElementName = "Products")]
        public Products? Products { get; set; }

    }

}
