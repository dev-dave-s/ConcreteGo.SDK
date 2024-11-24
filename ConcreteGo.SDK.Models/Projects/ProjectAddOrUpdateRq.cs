using ConcreteGo.SDK.Models.Common;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Projects {
    [XmlRoot(ElementName = "ProjectUpdate", Namespace = "")]
    public class ProjectAddOrUpdateRq {
        
        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() { return ID != null; }
        
        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        
        [XmlElement(ElementName = "Name")]
        public string? Name { get; set; }
        
        [XmlElement(ElementName = "CustomerID")]
        public int? CustomerID { get; set; }
        public bool ShouldSerializeCustomerID() { return CustomerID != null; }
        
        [XmlElement(ElementName = "CustomerCode")]
        public string? CustomerCode { get; set; }
        
        [XmlElement(ElementName = "CustomerName")]
        public string? CustomerName { get; set; }
        
        [XmlElement("Action")] // add, edit, update, delete.
        public string Action { get; set; } = string.Empty;
        
        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() { return SetupDate != null; }
        
        [XmlElement(ElementName = "DeliveryAddress")]
        public DeliveryAddress? DeliveryAddress { get; set; } 
        
        [XmlElement(ElementName = "InvoiceAddress")]
        public InvoiceAddress? InvoiceAddress { get; set; } 
        
        [XmlElement(ElementName = "StatementAddress")]
        public StatementAddressRq? StatementAddress { get; set; } 
        
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
        public SalesRq? Sales { get; set; } 
        
        [XmlElement(ElementName = "Taxing")]
        public TaxingRq? Taxing { get; set; } 
        
        [XmlElement(ElementName = "Pricing")]
        public ProjectPricingRq? Pricing { get; set; } 
        
        [XmlElement(ElementName = "Charges")]
        public ChargesRq? Charges { get; set; } 
        
        [XmlElement(ElementName = "Accounting")]
        public AccountingRq? Accounting { get; set; } 
        
        [XmlElement(ElementName = "Distribution")]
        public DistributionRq? Distribution { get; set; } 
        
        [XmlElement(ElementName = "Products")]
        public ProductsRq? Products { get; set; } 
        
    }
}

[XmlRoot(ElementName = "DeliveryAddress")]
public class DeliveryAddressRq {

    [XmlElement(ElementName = "Addr1")]
    public string? Addr1 { get; set; }

    [XmlElement(ElementName = "Addr2")]
    public string? Addr2 { get; set; }

    [XmlElement(ElementName = "Addr3")]
    public string? Addr3 { get; set; }
    
}

[XmlRoot(ElementName = "Instruction")]
public class InstructionRq {

    [XmlElement(ElementName = "Instruction1")]
    public string? Instruction1 { get; set; }

    [XmlElement(ElementName = "Instruction2")]
    public string? Instruction2 { get; set; }

    [XmlElement(ElementName = "Instruction3")]
    public string? Instruction3 { get; set; }
    
}

[XmlRoot(ElementName = "Pricing")]
public class ProjectPricingRq {

    [XmlElement(ElementName = "PriceCategoryCode")]
    public string? PriceCategoryCode { get; set; }

    [XmlElement(ElementName = "PricingPlantCode")]
    public string? PricingPlantCode { get; set; }
    
    // TODO convert to string? 
    [XmlElement(ElementName = "TradeDiscountPercent")]
    public double? TradeDiscountPercent { get; set; }
    public bool ShouldSerializeTradeDiscountPercent() { return TradeDiscountPercent != null; }
    
    [XmlElement(ElementName = "TradeDiscountAmount")]
    public double? TradeDiscountAmount { get; set; }
    public bool ShouldSerializeTradeDiscountAmount() { return TradeDiscountAmount != null; }
    
    [XmlElement(ElementName = "TermCode")]
    public string? TermCode { get; set; }
    
    [XmlElement(ElementName = "ZoneCode")]
    public string? ZoneCode { get; set; }
    
    [XmlElement(ElementName = "ApplyZoneCharges")]
    public bool? ApplyZoneCharges { get; set; }
    
    [XmlElement(ElementName = "AllowPriceChangeInOrderEntry")]
    public bool? AllowPriceChangeInOrderEntry { get; set; }
    
    [XmlElement(ElementName = "ControlPricePrintInOE")]
    public bool? ControlPricePrintInOE { get; set; }
    
    [XmlElement(ElementName = "PrintPricesOnTicket")]
    public bool? PrintPricesOnTicket { get; set; }
    
    [XmlElement(ElementName = "RestrictOrderstoCustomerProducts")]
    public bool? RestrictOrderstoCustomerProducts { get; set; }
    
    [XmlElement(ElementName = "AllowAutomaticPriceAjustment")]
    public bool? AllowAutomaticPriceAjustment { get; set; }
}


[XmlRoot(ElementName = "Products")]
public class ProductsRq {

    [XmlAttribute("Method")] // PUT|PATCH - PATCH defualt
    public string Method { get; set; } = string.Empty;
    
    [XmlElement(ElementName = "MixProduct")]
    public List<MixProductRq>? MixProduct { get; set; } = new List<MixProductRq>();

    [XmlElement(ElementName = "ExtraProduct")]
    public List<ExtraProductRq>? ExtraProduct { get; set; } = new List<ExtraProductRq>();

}

[XmlRoot(ElementName = "MixProduct")]
public class MixProductRq {

    [XmlAttribute("Action")] // UPSERT|DELETE
    public string Action { get; set; } = String.Empty;
    
    [XmlElement(ElementName = "PlantID")]
    public int? PlantID { get; set; }
    public bool ShouldSerializePlantID() { return PlantID != null; }
    
    [XmlElement(ElementName = "PlantCode")]
    public string? PlantCode { get; set; }
    
    [XmlElement(ElementName = "ItemID")]
    public int? ItemID { get; set; }
    public bool ShouldSerializeItemID() { return ItemID != null; }
    
    [XmlElement(ElementName = "ItemCode")]
    public string? ItemCode { get; set; }
    
    [XmlElement(ElementName = "ShortDescription")]
    public string? ShortDescription { get; set; }
    
    [XmlElement(ElementName = "Description")]
    public string? Description{ get; set; }
    
    [XmlElement(ElementName = "BatchCode")]
    public string? BatchCode { get; set; }
    
    [XmlElement(ElementName = "Slump")]
    public double? Slump { get; set; }
    public bool ShouldSerializeSlump() { return Slump != null; }
    
    [XmlElement(ElementName = "UsageCode")]
    public string? UsageCode { get; set; }
    
    [XmlElement(ElementName = "AllowAuto")]
    public bool? AllowAuto { get; set; }
    
    [XmlElement(ElementName = "Pricing")]
    public PricingRq? Pricing { get; set; }

    [XmlElement(ElementName = "AssocProduct")]
    public List<AssocProductRq>? AssocProduct { get; set; } = new List<AssocProductRq>();

}

[XmlRoot(ElementName = "AssocProduct")]
public class AssocProductRq {
    
    [XmlElement(ElementName = "PlantID")]
    public int? PlantID { get; set; }
    public bool ShouldSerializePlantID() { return PlantID != null; }
    
    [XmlElement(ElementName = "PlantCode")]
    public string? PlantCode { get; set; }
    
    [XmlElement(ElementName = "ItemID")]
    public int? ItemID { get; set; }
    public bool ShouldSerializeItemID() { return ItemID != null; }
    
    [XmlElement(ElementName = "ItemCode")]
    public string? ItemCode { get; set; }
    
    // Required if adding
    [XmlElement(ElementName = "ShortDescription")]
    public string? ShortDescription { get; set; }
   
    [XmlElement(ElementName = "Description")]
    public string? Description{ get; set; }
    
    [XmlElement(ElementName = "Pricing")]
    public PricingRq? Pricing { get; set; }
}

[XmlRoot(ElementName = "ExtraProduct")]
public class ExtraProductRq {
    
    [XmlElement(ElementName = "PlantID")]
    public int? PlantID { get; set; }
    public bool ShouldSerializePlantID() { return PlantID != null; }
    
    [XmlElement(ElementName = "PlantCode")]
    public string? PlantCode { get; set; }
    
    [XmlElement(ElementName = "ItemID")]
    public int? ItemID { get; set; }
    public bool ShouldSerializeItemID() { return ItemID != null; }
    
    [XmlElement(ElementName = "ItemCode")]
    public string? ItemCode { get; set; }
    
    // Required if adding
    [XmlElement(ElementName = "ShortDescription")]
    public required string ShortDescription { get; set; }
    
    [XmlElement(ElementName = "Description")]
    public required string Description{ get; set; }
    
    [XmlElement(ElementName = "Pricing")]
    public PricingRq? Pricing { get; set; }
    
}

