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
}