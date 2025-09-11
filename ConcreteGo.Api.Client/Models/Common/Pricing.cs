using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Common
{
    [XmlRoot(ElementName = "Pricing")]
    public class Pricing
    {

        [XmlElement(ElementName = "PriceCategoryCode")]
        public string PriceCategoryCode { get; set; }

        [XmlElement(ElementName = "PriceCategoryName")]
        public string PriceCategoryName { get; set; }

        [XmlElement(ElementName = "PriceCategoryDescription")]
        public string PriceCategoryDescription { get; set; }

        [XmlElement(ElementName = "PricingPlantCode")]
        public string PricingPlantCode { get; set; }

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public string _TradeDiscountPercent { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TradeDiscountPercent { get { if (double.TryParse(_TradeDiscountPercent, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public string _TradeDiscountAmount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TradeDiscountAmount { get { if (double.TryParse(_TradeDiscountAmount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TradeDiscountAmountUnitCode")]
        public string TradeDiscountAmountUnitCode { get; set; }

        [XmlElement(ElementName = "TermCode")]
        public string TermCode { get; set; }

        [XmlElement(ElementName = "ZoneCode")]
        public string ZoneCode { get; set; }

        [XmlElement(ElementName = "OverrideChargeRate")]
        public string _OverrideChargeRate { get; set; } = string.Empty;
        [XmlIgnore]
        public double? OverrideChargeRate { get { if (double.TryParse(_OverrideChargeRate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "OverrideChargeEfftiveDate")]
        public string _OverrideChargeEfftiveDate { get; set; } = string.Empty;
        public DateTime? OverrideChargeEfftiveDate { get { if (DateTime.TryParse(_OverrideChargeEfftiveDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ApplyZoneCharges")]
        public bool ApplyZoneCharges { get; set; }

        [XmlElement(ElementName = "AllowPriceChangeInOrderEntry")]
        public bool AllowPriceChangeInOrderEntry { get; set; }

        [XmlElement(ElementName = "ControlPricePrintInOE")]
        public bool ControlPricePrintInOE { get; set; }

        [XmlElement(ElementName = "PrintPricesOnTicket")]
        public bool PrintPricesOnTicket { get; set; }

        [XmlElement(ElementName = "RestrictOrderstoCustomerProducts")]
        public bool RestrictOrderstoCustomerProducts { get; set; }

        [XmlElement(ElementName = "AllowAutomaticPriceAjustment")]
        public string _AllowAutomaticPriceAjustment { get; set; } = string.Empty;
        public bool? AllowAutomaticPriceAjustment { get { if (bool.TryParse(_AllowAutomaticPriceAjustment, out var value)) return value; return null; } }
    }
}
