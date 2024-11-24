using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common {
    [XmlRoot(ElementName = "Pricing")]
    public class PricingRq {
    
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
}