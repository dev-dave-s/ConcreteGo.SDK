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
        public PricingRq? Pricing { get; set; } 
        
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
public class ProductPricingRq {
[XmlElement(ElementName = "EstimatedQuantity")]
        public double? EstimatedQuantity { get; set; }
        public bool ShouldSerializeEstimatedQuantity() { return EstimatedQuantity != null; }
    
        [XmlElement(ElementName = "EstimatedQuantityUnitID")]
        public int? EstimatedQuantityUnitID { get; set; }
        public bool ShouldSerializeEstimatedQuantityUnitID() { return EstimatedQuantityUnitID != null; }
        
        [XmlElement(ElementName = "EstimatedQuantityUnitCode")]
        public int? EstimatedQuantityUnitCode { get; set; }
        public bool ShouldSerializeEstimatedQuantityUnitCode() { return EstimatedQuantityUnitCode != null; }
    
        [XmlElement(ElementName = "EstimatedQuantityUnit")]
        public int? EstimatedQuantityUnit { get; set; }
        public bool ShouldSerializeEstimatedQuantityUnit() { return EstimatedQuantityUnit != null; }
        
        [XmlElement(ElementName = "Price")]
        public double? Price { get; set; }
        public bool ShouldSerializePrice() { return Price != null; }
    
        [XmlElement(ElementName = "PriceUnitID")]
        public int? PriceUnitID { get; set; }
        public bool ShouldSerializePriceUnitID() { return PriceUnitID != null; }
    
        [XmlElement(ElementName = "PriceUnitCode")]
        public string? PriceUnitCode { get; set; }
    
        [XmlElement(ElementName = "PriceUnit")]
        public string? PriceUnit { get; set; }
    
        [XmlElement(ElementName = "PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
    
        [XmlElement(ElementName = "EffectiveDate")]
        public DateTime? EffectiveDate { get; set; }
        public bool ShouldSerializeEffectiveDate() { return EffectiveDate != null; }
    
        [XmlElement(ElementName = "PreviousPrice")]
        public double? PreviousPrice { get; set; }
        public bool ShouldSerializePreviousPrice() { return PreviousPrice != null; }
    
        [XmlElement(ElementName = "PreviousPriceUnitID")]
        public int? PreviousPriceUnitID { get; set; }
        public bool ShouldSerializePreviousPriceUnitID() { return PreviousPriceUnitID != null; }
    
        [XmlElement(ElementName = "PreviousPriceUnitCode")]
        public int? PreviousPriceUnitCode { get; set; }
        public bool ShouldSerializePreviousPriceUnitCode() { return PreviousPriceUnitCode != null; }
    
        [XmlElement(ElementName = "PreviousPriceUnit")]
        public string? PreviousPriceUnit { get; set; }
    
        [XmlElement(ElementName = "PreviousPriceExtensionCode")]
        public string? PreviousPriceExtensionCode { get; set; }
    
        [XmlElement(ElementName = "CreateSeperatedInvoice")]
        public bool? CreateSeperatedInvoice{ get; set; }
        public bool ShouldSerializeCreateSeperatedInvoice() { return CreateSeperatedInvoice != null; }
    
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
    public ProductPricingRq? Pricing { get; set; }

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
    public ProductPricingRq? Pricing { get; set; }
    
}

