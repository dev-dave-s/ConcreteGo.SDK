using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Items
{
    [XmlRoot(ElementName = "ItemUpdate", Namespace = "")]
    public class ItemAddOrUpdateRq
    {
        [XmlElement(ElementName = "Action")]
        public string? Action { get; set; }

        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() { return ID.HasValue; }

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }

        [XmlElement(ElementName = "CategoryCode")]
        public string? CategoryCode { get; set; }

        [XmlElement(ElementName = "Description")]
        public string? Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }
        public bool ShouldSerializeItemTypeID() { return ItemTypeID.HasValue; }

        [XmlElement(ElementName = "ItemType")]
        public string? ItemType { get; set; }

        [XmlElement(ElementName = "Constituent")]
        public bool? Constituent { get; set; }
        public bool ShouldSerializeConstituent() { return Constituent.HasValue; }

        [XmlElement(ElementName = "Resaleable")]
        public bool? Resaleable { get; set; }
        public bool ShouldSerializeResaleable() { return Resaleable.HasValue; }

        [XmlElement(ElementName = "KeepInInventory")]
        public bool? KeepInInventory { get; set; }
        public bool ShouldSerializeKeepInInventory() { return KeepInInventory.HasValue; }

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool? DoNotAllowTicketing { get; set; }
        public bool ShouldSerializeDoNotAllowTicketing() { return DoNotAllowTicketing.HasValue; }

        [XmlElement(ElementName = "IsConstituent")]
        public bool? IsConstituent { get; set; }
        public bool ShouldSerializeIsConstituent() { return IsConstituent.HasValue; }

        [XmlElement(ElementName = "IsResaleable")]
        public bool? IsResaleable { get; set; }
        public bool ShouldSerializeIsResaleable() { return IsResaleable.HasValue; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string? AccountLinkCode { get; set; }

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string? CategoryAccountLinkCode { get; set; }

        [XmlElement(ElementName = "ProductLink")]
        public string? ProductLink { get; set; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() { return SetupDate.HasValue; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }
        public bool ShouldSerializeUpdateDate() { return UpdateDate.HasValue; }

        [XmlElement(ElementName = "UOM")]
        public UOM? UOM { get; set; }

        [XmlElement(ElementName = "Sales")]
        public SalesRequest? Sales { get; set; }

        [XmlElement(ElementName = "Mix")]
        public Mix? Mix { get; set; }

        [XmlElement(ElementName = "Locations")]
        public Locations? Locations { get; set; }

        [XmlElement(ElementName = "TaxOverrides")]
        public TaxOverrides? TaxOverrides { get; set; }

        // Include Ret
        public List<string>? IncludeRetElement { get; set; }
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
