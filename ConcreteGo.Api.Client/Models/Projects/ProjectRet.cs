using ConcreteGo.Api.Client.Models.Common;
using ConcreteGo.Api.Client.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Projects
{
    [XmlRoot(ElementName = "ProjectRet")]
    public class ProjectRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerID")]
        public int CustomerID { get; set; }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; } = string.Empty;

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
        public string Contact { get; set; } = string.Empty;

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; } = string.Empty;

        [XmlElement(ElementName = "Cellular")]
        public string Cellular { get; set; } = string.Empty;

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerJob")]
        public string CustomerJob { get; set; } = string.Empty;

        [XmlElement(ElementName = "PurchaseOrder")]
        public string PurchaseOrder { get; set; } = string.Empty;

        [XmlElement(ElementName = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [XmlElement(ElementName = "ShippingCustomerCode")]
        public string ShippingCustomerCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ReferenceCustomerCode")]
        public string ReferenceCustomerCode { get; set; } = string.Empty;

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
        public decimal? PriceEscalationAmount { get; set; }

        [XmlElement(ElementName = "PriceEscalationDate")]
        public DateTime? PriceEscalationDate { get; set; }


        [XmlElement(ElementName = "Latitude")]
        public string Latitude { get; set; } = string.Empty;

        [XmlElement(ElementName = "Longitude")]
        public string Longitude { get; set; } = string.Empty;

        [XmlElement(ElementName = "JobsiteRadius")]
        public decimal? JobSiteRadius { get; set; }


        [XmlElement(ElementName = "UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [XmlElement(ElementName = "CustomerRet")]
        public CustomerRet CustomerRet { get; set; }

        [XmlElement(ElementName = "Products")]
        public Products Products { get; set; }

    }

    [XmlRoot(ElementName = "Products")]
    public class Products
    {

        [XmlElement(ElementName = "MixProduct")]
        public List<MixProduct> MixProduct { get; set; }
    }

    [XmlRoot(ElementName = "MixProduct")]
    public class MixProduct
    {

        [XmlElement(ElementName = "PlantID")]
        public int? PlantID { get; set; }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ItemID")]
        public int? ItemID { get; set; }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "BatchCode")]
        public string BatchCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Slump", IsNullable = true)]
        public int? Slump { get; set; }

        [XmlElement(ElementName = "AllowAuto")]
        public bool AllowAuto { get; set; }

        [XmlElement(ElementName = "Pricing")]
        public Pricing Pricing { get; set; }
    }


    [XmlRoot(ElementName = "DeliveryAddress")]
    public class DeliveryAddress
    {

        [XmlElement(ElementName = "Addr1")]
        public string Addr1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Addr2")]
        public string Addr2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Addr3")]
        public string Addr3 { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Instruction")]
    public class Instruction
    {

        [XmlElement(ElementName = "Instruction1")]
        public string Instruction1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Instruction2")]
        public string Instruction2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "Instruction3")]
        public string Instruction3 { get; set; } = string.Empty;
    }
}
