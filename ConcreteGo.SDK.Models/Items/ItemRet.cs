using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Items
{
    [XmlRoot("ItemRet")]
    public class ItemRet
    {

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

        [XmlElement(ElementName = "Constituent")]
        public bool Constituent { get; set; }

        [XmlElement(ElementName = "ItemTypeID")]
        public int ItemTypeID { get; set; }

        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; } = string.Empty;

        [XmlElement(ElementName = "Resaleable")]
        public bool Resaleable { get; set; }

        [XmlElement(ElementName = "KeepInInventory")]
        public bool KeepInInventory { get; set; }

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool DoNotAllowTicketing { get; set; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string CategoryAccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SetupDate")]
        public DateTime SetupDate { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [XmlElement(ElementName = "UOM")]
        public UOM UOM { get; set; } = null!;

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; } = null!;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;
    }

    [XmlRoot(ElementName = "UOM")]
    public class UOM
    {

        [XmlElement(ElementName = "OrderedQuantityUnitCode")]
        public string OrderedQuantityUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "OrderedQuantityUnit")]
        public string OrderedQuantityUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "OrderedExtensionCode")]
        public string OrderedExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "DeliveredQuantityUnitCode")]
        public string DeliveredQuantityUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "DeliveredQuantityUnit")]
        public string DeliveredQuantityUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "TicketExtensionCode")]
        public string TicketExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceQuantityUnitCode")]
        public string PriceQuantityUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceQuantityUnit")]
        public string PriceQuantityUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string PriceExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "BatchUnitCode")]
        public string BatchUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "BatchUnit")]
        public string BatchUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "InventoryUnitCode")]
        public string InventoryUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "InventoryUnit")]
        public string InventoryUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "PurchaseUnitCode")]
        public string PurchaseUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PurchaseUnit")]
        public string PurchaseUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "ReportingUnitCode")]
        public string ReportingUnitCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ReportingUnit")]
        public string ReportingUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "DosageQuantity")]
        public string _DosageQuantity { get; set; } = string.Empty;
        [XmlIgnore]
        public double? DosageQuantity
        {
            get
            {
                double value;
                if (double.TryParse(_DosageQuantity, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public string _PerCemWeightDivisor { get; set; } = string.Empty;
        [XmlIgnore]
        public double? PerCemWeightDivisor
        {
            get
            {
                double value;
                if (double.TryParse(_PerCemWeightDivisor, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "UseDosageQuantityUOMInMixDesign")]
        public UseDosageQuantityUOMInMixDesign UseDosageQuantityUOMInMixDesign { get; set; } = null!;
    }

    [XmlRoot(ElementName = "UseDosageQuantityUOMInMixDesign")]
    public class UseDosageQuantityUOMInMixDesign
    {

        [XmlElement(ElementName = "Enable")]
        public bool Enable { get; set; }

        [XmlElement(ElementName = "DosageQuantityExtensionCode")]
        public string DosageQuantityExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PerCemWeightDivisor")]
        public string _PerCemWeightDivisor { get; set; } = string.Empty;

        [XmlIgnore]
        public decimal? PerCemWeightDivisor
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_PerCemWeightDivisor, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "DosageQuantity")]
        public string _DosageQuantity { get; set; } = string.Empty;

        [XmlIgnore]
        public decimal? DosageQuantity
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_DosageQuantity, out value))
                {
                    return value;
                }
                return null;
            }
        }
    }

    [XmlRoot(ElementName = "Sales")]
    public class Sales
    {

        [XmlElement(ElementName = "Taxable")]
        public bool Taxable { get; set; }

        [XmlElement(ElementName = "TradeDiscountable")]
        public bool TradeDiscountable { get; set; }

        [XmlElement(ElementName = "TermDiscountable")]
        public bool TermDiscountable { get; set; }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ExpirationDate")]
        public DateTime ExpirationDate { get; set; }
    }

    [XmlRoot(ElementName = "Mix")]
    public class Mix
    {


        [XmlElement(ElementName = "Strength")]
        public string _Strength { get; set; } = string.Empty;
        [XmlIgnore]
        public double? Strength
        {
            get
            {
                double value;
                if (double.TryParse(_Strength, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "StrengthUnit")]
        public string StrengthUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "Slump")]
        public string _Slump { get; set; } = string.Empty;

        [XmlIgnore]
        public double? Slump
        {
            get
            {
                double value;
                if (double.TryParse(_Slump, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "WaterCementRatio")]
        public string _WaterCementRatio { get; set; } = string.Empty;
        [XmlIgnore]
        public double? WaterCementRatio
        {
            get
            {
                double value;
                if (double.TryParse(_WaterCementRatio, out value))
                {
                    return value;
                }
                return null;
            }
        }
        [XmlElement(ElementName = "AggregateSize")]
        public string _AggregateSize { get; set; } = string.Empty;
        [XmlIgnore]
        public double? AggregateSize
        {
            get
            {
                double value;
                if (double.TryParse(_AggregateSize, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "CementType")]
        public string _CementType { get; set; } = string.Empty;
        [XmlIgnore]
        public double? CementType
        {
            get
            {
                double value;
                if (double.TryParse(_CementType, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "DaysToStrength")]
        public string _DaysToStrength { get; set; } = string.Empty;
        [XmlIgnore]
        public double? DaysToStrength
        {
            get
            {
                double value;
                if (double.TryParse(_DaysToStrength, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "MaximumWater")]
        public string _MaximumWater { get; set; } = string.Empty;
        [XmlIgnore]
        public double? MaximumWater
        {
            get
            {
                double value;
                if (double.TryParse(_MaximumWater, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "MinCementContent")]
        public string _MinCementContent { get; set; } = string.Empty;
        [XmlIgnore]
        public double? MinCementContent
        {
            get
            {
                double value;
                if (double.TryParse(_MinCementContent, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PercentAirVolume")]
        public string _PercentAirVolume { get; set; } = string.Empty;
        [XmlIgnore]
        public double? PercentAirVolume
        {
            get
            {
                double value;
                if (double.TryParse(_PercentAirVolume, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "WaterHoldback")]
        public string _WaterHoldback { get; set; } = string.Empty;
        [XmlIgnore]
        public double? WaterHoldback
        {
            get
            {
                double value;
                if (double.TryParse(_WaterHoldback, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "LightweightCubicFeet")]
        public string _LightweightCubicFeet { get; set; } = string.Empty;
        [XmlIgnore]
        public double? LightweightCubicFeet
        {
            get
            {
                double value;
                if (double.TryParse(_LightweightCubicFeet, out value))
                {
                    return value;
                }
                return null;
            }
        }
    }

    [XmlRoot(ElementName = "Location")]
    public class Location
    {

        [XmlElement(ElementName = "LocationID")]
        public int LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "MixDesign")]
        public MixDesign MixDesign { get; set; } = null!;
        [XmlElement(ElementName = "Cost")]
        public Cost Cost { get; set; } = null!;
    }

    [XmlRoot(ElementName = "MixDesign")]
    public class MixDesign
    {

        [XmlElement(ElementName = "Material")]
        public List<ApiItemMaterial> Material { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Cost")]
    public class Cost
    {
        [XmlElement(ElementName = "StandardCost")]
        public decimal StandardCost { get; set; }
        [XmlElement(ElementName = "CostExtensionCode")]
        public string CostExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CostEffectiveDate")]
        public string _CostEffectiveDate { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? CostEffectiveDate
        {
            get
            {
                DateTime value;
                if (DateTime.TryParse(_CostEffectiveDate, out value))
                {
                    return value;
                }
                return null;
            }
        }


        [XmlElement(ElementName = "PreviousCost")]
        private string _PreviousCost { get; set; } = string.Empty;

        [XmlIgnore]
        public decimal? PreviousCost
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_PreviousCost, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PreviousCostExtensionCode")]
        public string PreviousCostExtensionCode { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Locations")]
    public class Locations
    {

        [XmlElement(ElementName = "Location")]
        public List<Location> Location { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Material")]
    public class ApiItemMaterial
    {

        [XmlElement(ElementName = "Sort")]
        public int Sort { get; set; }

        [XmlElement(ElementName = "ItemID")]
        public int ItemID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "Quantity")]
        public string _Quantity { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? Quantity
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_Quantity, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "DosageQuantity")]
        public string _DosageQuantity { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? DosageQuantity
        {
            get
            {
                decimal value;
                if (decimal.TryParse(_DosageQuantity, out value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Unit")]
        public string Unit { get; set; } = string.Empty;
    }
}
