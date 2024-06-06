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
        public string _ID { get; set; }
        public int? ID { get { if (int.TryParse(_ID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryCode")]
        public string CategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "Constituent")]
        public string _Constituent { get; set; }
        public bool? Constituent { get { if (bool.TryParse(_Constituent, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemTypeID")]
        public string _ItemTypeID { get; set; }
        public int? ItemTypeID { get { if (int.TryParse(_ItemTypeID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; } = string.Empty;

        [XmlElement(ElementName = "Resaleable")]
        public string _Resaleable { get; set; }
        public bool? Resaleable { get { if (bool.TryParse(_Resaleable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "KeepInInventory")]
        public string _KeepInInventory { get; set; }
        public bool? KeepInInventory { get { if (bool.TryParse(_KeepInInventory, out var value)) return value; return null; } }

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public string _DoNotAllowTicketing { get; set; }
        public bool? DoNotAllowTicketing { get { if (bool.TryParse(_DoNotAllowTicketing, out var value)) return value; return null; } }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CategoryAccountLinkCode")]
        public string CategoryAccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SetupDate")]
        public string _SetupDate { get; set; }
        public DateTime? SetupDate { get { if (DateTime.TryParse(_SetupDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UpdateDate")]
        public string _UpdateDate { get; set; }
        public DateTime? UpdateDate { get { if (DateTime.TryParse(_UpdateDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UOM")]
        public UOM UOM { get; set; } = null!;

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; } = null!;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;
        [XmlElement(ElementName = "TaxOverrides")]
        public TaxOverrides TaxOverrides { get; set; } = null!;
    }

    [XmlRoot("TaxOverrides")]
    public class TaxOverrides
    {
        [XmlElement("TaxOverride")]
        public List<TaxOverride> TaxOverride { get; set; } = null!;
    }

    [XmlRoot("TaxOverride")]
    public class TaxOverride
    {
        [XmlElement("TaxAuthorityID")]
        public int TaxAuthorityID { get; set; }
        [XmlElement("TaxAuthorityCode")]
        public string TaxAuthorityCode { get; set; } = string.Empty;
        [XmlElement("TaxLocationID")]
        public string _TaxLocationID { get; set; }
        public int? TaxLocationID { get { if (int.TryParse(_TaxLocationID, out var value)) return value; return null; } }
        [XmlElement("TaxLocationCode")]
        public string TaxLocationCode { get; set; } = string.Empty;
        [XmlElement("OverrideTaxable")]
        public string _OverrideTaxable { get; set; }
        public bool? OverrideTaxable { get { if (bool.TryParse(_OverrideTaxable, out var value)) return value; return null; } }
        [XmlElement("OverrideTaxRateLocationID")]
        public string _OverrideTaxRateLocationID { get; set; }
        public int? OverrideTaxRateLocationID { get { if (int.TryParse(_OverrideTaxRateLocationID, out var value)) return value; return null; } }
        [XmlElement("OverrideTaxRateLocationCode")]
        public string OverrideTaxRateLocationCode { get; set; } = string.Empty;
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
        public string _Enable { get; set; }
        public bool? Enable { get { if (bool.TryParse(_Enable, out var value)) return value; return null; } }

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
        public string _Taxable { get; set; }
        public bool? Taxable { get { if (bool.TryParse(_Taxable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TradeDiscountable")]
        public string _TradeDiscountable { get; set; }
        public bool? TradeDiscountable { get { if (bool.TryParse(_TradeDiscountable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TermDiscountable")]
        public string _TermDiscountable { get; set; }
        public bool? TermDiscountable { get { if (bool.TryParse(_TermDiscountable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ExpirationDate")]
        private string _ExpirationDate { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? ExpirationDate
        {
            get
            {
                if (DateTime.TryParse(_ExpirationDate, out var value))
                { return value; }
                return null;
            }
        }
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
        public string _LocationID { get; set; }
        public int? LocationID { get { if (int.TryParse(_LocationID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "MixDesign")]
        public MixDesign MixDesign { get; set; } = null!;
        [XmlElement(ElementName = "Cost")]
        public Cost Cost { get; set; } = null!;

        [XmlElement(ElementName = "Batching")]
        public Batching Batching { get; set; } = null!;

        [XmlElement(ElementName = "Pricings")]
        public Pricings Pricings { get; set; } = null!;

        [XmlElement(ElementName = "BatchCodes")]
        public BatchCodes BatchCodes { get; set; } = null!;

        [XmlElement(ElementName = "AutoProducts")]
        public AutoProducts AutoProducts { get; set; } = null!;
    }

    [XmlRoot("AutoProducts")]
    public class AutoProducts
    {
        [XmlElement("AutoProduct")]
        public List<AutoProduct> AutoProduct { get; set; } = null!;
    }

    [XmlRoot("AutoProduct")]
    public class AutoProduct
    {
        [XmlElement("Code")]
        public string Code { get; set; } = string.Empty;
        [XmlElement("Quantity")]
        private string _Quantity { get; set; } = string.Empty;
        [XmlIgnore]
        public double? Quantity
        {
            get
            {
                if(double.TryParse(_Quantity, out var value))
                {
                    return value;
                }
                return null;
            }
        }
        [XmlElement("LoadQuantity")]
        private string _LoadQuantity { get; set; } = string.Empty;
        public double? LoadQuantity 
        {
            get
            {
                if(double.TryParse(_LoadQuantity, out var value))
                {
                    return value;
                }
                return null;
            }
        }
    }

    [XmlRoot("BatchCodes")]
    public class BatchCodes
    {
        [XmlElement("BatchCode")]
        public List<BatchCode> BatchCode { get; set; } = null!;
    }

    [XmlRoot("BatchCode")]
    public class BatchCode
    {
        [XmlElement("Code")]
        public string Code { get; set; } = string.Empty;
        [XmlElement("SortLineNumber")]
        private string _SortLineNumber { get; set; } = string.Empty;
        [XmlIgnore]
        public int? SortLineNumber
        {
            get
            {
                if(int.TryParse(_SortLineNumber, out var value))
                {
                    return value;
                }
                return null;
            }
        }
        [XmlElement("Description")]
        public string Description { get; set; } = string.Empty;
        [XmlElement("ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;
        [XmlElement("UpdateDate")]
        private string _UpdateDate { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? UpdateDate
        {
            get
            {
                if(DateTime.TryParse(_UpdateDate, out var value))
                {
                    return value;
                }
                return null;
            }
        }
    }

    [XmlRoot(ElementName = "Batching")]
    public class Batching
    {
        [XmlElement("SpecificGravity")]
        public string _SpecificGravity { get; set; } = string.Empty;
        [XmlIgnore]
        public double? SpecificGravity
        {
            get
            {
                if(double.TryParse(_SpecificGravity, out var value))
                    { return value; }
                return null;
            }
        }
        [XmlElement("MoisturePercent")]
        public string _MoisturePercent { get; set; } = string.Empty;
        [XmlIgnore]
        public double? MoisturePercent
        {
            get
            {
                if (double.TryParse(_MoisturePercent, out var value))
                    { return value; }
                return null;

            }
        }
        [XmlElement("BatchUnit")]
        public string BatchUnit { get; set; } = string.Empty;
        [XmlElement("MaximumBatchSize")]
        public string _MaximumBatchSize { get; set; } = string.Empty;
        [XmlIgnore]
        public double? MaximumBatchSize
        {
            get
            {
                if(double.TryParse(_MaximumBatchSize, out var value))
                {
                    return value;
                }
                return null;
            }
        }
        [XmlElement("MixerTime")]
        public string _MixerTime { get; set; } = string.Empty;
        [XmlIgnore]
        public int? MixerTime
        {
            get
            {
                if (int.TryParse(_MixerTime, out var value))
                { return value; }
                return null;
            }
        }
        [XmlElement("DownloadToBatchSystem")]
        public bool DownloadToBatchSystem { get; set; }
    }

    [XmlRoot(ElementName = "Pricings")]
    public class Pricings
    {

        [XmlElement(ElementName = "Pricing")]
        public List<Pricing> Pricing { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Pricing")]
    public class Pricing
    {

        [XmlElement(ElementName = "PriceCategoryCode")]
        public string PriceCategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceCategoryName")]
        public string PriceCategoryName { get; set; } = string.Empty;

        [XmlElement(ElementName = "Price")]
        public string _Price { get; set; } = string.Empty;
        [XmlIgnore]
        public double? Price
        {
            get
            {
                if(double.TryParse(_Price, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PriceExtensionCode")]
        public string PriceExtensionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceEffectiveDate")]
        public string _PriceEffectiveDate { get; set; } = string.Empty;
        public DateTime? PriceEffectiveDate
        {
            get
            {
                if(DateTime.TryParse(_PriceEffectiveDate, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PreviousPrice")]
        public string _PreviousPrice { get; set;} = string.Empty;
        public double? PreviousPrice
        {
            get
            {
                if (double.TryParse(_PreviousPrice, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PreviousPriceExtensionCode")]
        public string PreviousPriceExtensionCode { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "MixDesign")]
    public class MixDesign
    {

        [XmlElement(ElementName = "Material")]
        public List<Material> Material { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Cost")]
    public class Cost
    {
        [XmlElement(ElementName = "StandardCost")]
        public string _StandardCost { get; set; }
        public decimal? StandardCost { get { if (decimal.TryParse(_StandardCost, out var value)) return value; return null; } }
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
    public class Material
    {

        [XmlElement(ElementName = "Sort")]
        public string _Sort { get; set; }
        public int? Sort { get { if (int.TryParse(_Sort, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemID")]
        public string _ItemID { get; set; }
        public int? ItemID { get { if (int.TryParse(_ItemID, out var value)) return value; return null; } }

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
