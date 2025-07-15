using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Items
{
    [XmlRoot(ElementName = "ItemUpdate", Namespace = "")]
    public class ItemAddOrUpdateRq
    {
        [XmlElement(ElementName = "Action")]
        public string Action { get; set; } = string.Empty;

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryCode")]
        public string CategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }

        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; } = string.Empty;

        [XmlElement(ElementName = "Constituent")]
        public bool? Constituent { get; set; }

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }

        [XmlElement(ElementName = "IsConstituent")]
        public bool IsConstituent { get; set; } = false;

        [XmlElement(ElementName = "IsResaleable")]
        public bool IsResaleable { get; set; } = false;

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string CategoryAccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ProductLink")]
        public string ProductLink { get; set; } = string.Empty;

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        [XmlElement(ElementName = "UOM")]
        public UOM UOM { get; set; } = null!;

        [XmlElement(ElementName = "Sales")]
        public SalesRequest Sales { get; set; } = null!;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;

        [XmlElement(ElementName = "TaxOverrides")]
        public TaxOverrides TaxOverrides { get; set; } = null!;

        // Include Ret
        public List<string> IncludeRetElement { get; set; } = new List<string>();
    }

    [XmlRoot(ElementName = "Sales")]
    public class SalesRequest
    {
        [XmlElement(ElementName = "Taxable")]
        public bool? Taxable { get; set; }

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool? TradeDiscountable { get; set; }

        [XmlElement(ElementName = "TermDiscountable")]
        public bool? TermDiscountable { get; set; }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string? NonTaxableReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ExpirationDate")]
        public DateTime? ExpirationDate { get; set; }
    }
}
