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
    
        [XmlElement(ElementName = "EstimatedQuantityUnitID")]
        public int? EstimatedQuantityUnitID { get; set; }
    
        [XmlElement(ElementName = "EstimatedQuantityUnitCode")]
        public int? EstimatedQuantityUnitCode { get; set; }
    
        [XmlElement(ElementName = "EstimatedQuantityUnit")]
        public int? EstimatedQuantityUnit { get; set; }
    
        [XmlElement(ElementName = "Price")]
        public double? Price { get; set; }
    
        [XmlElement(ElementName = "PriceUnitID")]
        public int? PriceUnitID { get; set; }
    
        [XmlElement(ElementName = "PriceUnitCode")]
        public string? PriceUnitCode { get; set; }
    
        [XmlElement(ElementName = "PriceUnit")]
        public string? PriceUnit { get; set; }
    
        [XmlElement(ElementName = "PriceExtensionCode")]
        public string? PriceExtensionCode { get; set; }
    
        [XmlElement(ElementName = "EffectiveDate")]
        public DateTime? EffectiveDate { get; set; }
    
        [XmlElement(ElementName = "PreviousPrice")]
        public double? PreviousPrice { get; set; }
    
        [XmlElement(ElementName = "PreviousPriceUnitID")]
        public int? PreviousPriceUnitID { get; set; }
    
        [XmlElement(ElementName = "PreviousPriceUnitCode")]
        public int? PreviousPriceUnitCode { get; set; }
    
        [XmlElement(ElementName = "PreviousPriceUnit")]
        public string? PreviousPriceUnit { get; set; }
    
        [XmlElement(ElementName = "PreviousPriceExtensionCode")]
        public string? PreviousPriceExtensionCode { get; set; }
    
        [XmlElement(ElementName = "CreateSeperatedInvoice")]
        public bool? CreateSeperatedInvoice{ get; set; }

    }
}