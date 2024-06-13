using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Tickets
{
    [XmlRoot("TicketRet")]
    public class TicketRet
    {
        [XmlElement(ElementName = "TicketID")]
        public string _TicketID { get; set; }
        [XmlIgnore]
        public int? TicketID { get { if (int.TryParse(_TicketID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "CreatedDate")]
        public string _CreatedDate { get; set; }
        [XmlIgnore]
        public DateTime? CreatedDate { get { if (DateTime.TryParse(_CreatedDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PlantID")]
        public string _PlantID { get; set; }
        [XmlIgnore]
        public int? PlantID { get { if (int.TryParse(_PlantID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PlantName")]
        public string PlantName { get; set; } = string.Empty;

        [XmlElement(ElementName = "LocationID")]
        public string _LocationID { get; set; }
        [XmlIgnore]
        public int? LocationID { get { if (int.TryParse(_LocationID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "LocationName")]
        public string LocationName { get; set; } = string.Empty;

        [XmlElement(ElementName = "PricingPlantCode")]
        public string PricingPlantCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "TicketCode")]
        public string TicketCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "OrderDate")]
        public string _OrderDate { get; set; }
        [XmlIgnore]
        public DateTime? OrderDate { get { if (DateTime.TryParse(_OrderDate, out var value)) return value; return null; } }

        [XmlElement(ElementName = "OrderID")]
        public string _OrderID { get; set; }
        [XmlIgnore]
        public int? OrderID { get { if (int.TryParse(_OrderID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "OrderCode")]
        public string OrderCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "MixCode")]
        public string MixCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CurrentStatus")]
        public string _CurrentStatus { get; set; }
        public int? CurrentStatus { get { if (int.TryParse(_CurrentStatus, out var value)) return value; return null; } }

        [XmlElement(ElementName = "OrderCurrentStatus")]
        public string _OrderCurrentStatus { get; set; }
        public int? OrderCurrentStatus { get { if (int.TryParse(_OrderCurrentStatus, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PaymentForm")]
        public string _PaymentForm { get; set; }
        public int? PaymentForm { get { if (int.TryParse(_PaymentForm, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TruckCode")]
        public string TruckCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "DriverCode")]
        public string DriverCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "DriverName")]
        public string DriverName { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerID")]
        public string _CustomerID { get; set; }
        public int? CustomerID { get { if (int.TryParse(_CustomerID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "CustomerCode")]
        public string CustomerCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerDivisionCode")]
        public string CustomerDivisionCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "CustomerJob")]
        public string CustomerJob { get; set; } = string.Empty;

        [XmlElement(ElementName = "ProjectID")]
        public string _ProjectID { get; set; } = string.Empty;
        [XmlIgnore]
        public int? ProjectID
        {
            get
            {
                if(int.TryParse(_ProjectID, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "ProjectCode")]
        public string ProjectCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ProjectName")]
        public string ProjectName { get; set; } = string.Empty;

        [XmlElement(ElementName = "LotBlockNumber")]
        public string LotBlockNumber { get; set; } = string.Empty;

        [XmlElement(ElementName = "PurchaseOrder")]
        public string PurchaseOrder { get; set; } = string.Empty;

        [XmlElement(ElementName = "PocketNumber")]
        public string PocketNumber { get; set; } = string.Empty;

        [XmlElement(ElementName = "JobNumber")]
        public string JobNumber { get; set; } = string.Empty;

        [XmlElement(ElementName = "DeliveryAddr1")]
        public string DeliveryAddr1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "DeliveryAddr2")]
        public string DeliveryAddr2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "DeliveryAddr3")]
        public string DeliveryAddr3 { get; set; } = string.Empty;

        [XmlElement(ElementName = "InstructionAddr1")]
        public string InstructionAddr1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "InstructionAddr2")]
        public string InstructionAddr2 { get; set; } = string.Empty;

        [XmlElement(ElementName = "InstructionAddr3")]
        public string InstructionAddr3 { get; set; } = string.Empty;

        [XmlElement(ElementName = "InstructionAddr4")]
        public string InstructionAddr4 { get; set; } = string.Empty;

        [XmlElement(ElementName = "InstructionAddr5")]
        public string InstructionAddr5 { get; set; } = string.Empty;

        [XmlElement(ElementName = "InstructionAddr6")]
        public string InstructionAddr6 { get; set; } = string.Empty;

        [XmlElement(ElementName = "ZoneCode")]
        public string ZoneCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ZoneName")]
        public string ZoneName { get; set; } = string.Empty;

        [XmlElement(ElementName = "RemoveReasonCode")]
        public string RemoveReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "TaxCodeDescription")]
        public string TaxCodeDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "TaxCodeShortDescription")]
        public string TaxCodeShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "Taxable", IsNullable = true)]
        public string _Taxable { get; set; } = string.Empty;
        [XmlIgnore]
        public bool? Taxable
        {
            get
            {
                if (bool.TryParse(_Taxable, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "NonTaxableReasonShortDescription")]
        public string NonTaxableReasonShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "HaulerCode")]
        public string HaulerCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "HaulerName")]
        public string HaulerName { get; set; } = string.Empty;

        [XmlElement(ElementName = "UsageCode")]
        public string UsageCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "UsageShort")]
        public string UsageShort { get; set; } = string.Empty;

        [XmlElement(ElementName = "WeightMasterCode")]
        public string WeightMasterCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "WeightMasterName")]
        public string WeightMasterName { get; set; } = string.Empty;

        [XmlElement(ElementName = "WaterAddedOnJob")]
        public string _WaterAddedOnJob { get; set; } = string.Empty;
        [XmlIgnore]
        public double? WaterAddedOnJob
        {
            get
            {
                if (double.TryParse(_WaterAddedOnJob, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "QBInvoiceEmailChecked")]
        public string _QBInvoiceEmailChecked { get; set; }
        public bool? QBInvoiceEmailChecked { get { if (bool.TryParse(_QBInvoiceEmailChecked, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ScheduledOnJobTime")]
        public string _ScheduledOnJobTime { get; set; } = string.Empty;
        public DateTime? ScheduledOnJobTime
        {
            get
            {
                if (DateTime.TryParse(_ScheduledOnJobTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PrintedTime")]
        public string _PrintedTime { get; set; } = string.Empty;
        public DateTime? PrintedTime
        {
            get
            {
                if (DateTime.TryParse(_PrintedTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "LoadTime")]
        public string _LoadTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? LoadTime
        {
            get
            {
                if (DateTime.TryParse(_LoadTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "LoadedTime")]
        public string _LoadedTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? LoadedTime
        {
            get
            {
                if (DateTime.TryParse(_LoadedTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "ToJobTime")]
        public string _ToJobTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? ToJobTime
        {
            get
            {
                if (DateTime.TryParse(_ToJobTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "OnJobTime")]
        public string _OnJobTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? OnJobTime
        {
            get
            {
                if (DateTime.TryParse(_OnJobTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "UnloadTime")]
        public string _UnloadTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? UnloadTime
        {
            get
            {
                if (DateTime.TryParse(_UnloadTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "EndUnload")]
        public string _EndUnload { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? EndUnload
        {
            get
            {
                if (DateTime.TryParse(_EndUnload, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "WashTime")]
        public string _WashTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? WashTime
        {
            get
            {
                if (DateTime.TryParse(_WashTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "ToPlantTime")]
        public string _ToPlantTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? ToPlantTime
        {
            get
            {
                if (DateTime.TryParse(_ToPlantTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "AtPlantTime")]
        public string _AtPlantTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? AtPlantTime
        {
            get
            {
                if (DateTime.TryParse(_AtPlantTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Active")]
        public string _Active { get; set; }
        public int? Active { get { if (int.TryParse(_Active, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Amount")]
        public string _Amount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? Amount
        {
            get
            {
                if (double.TryParse(_Amount, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TotalAmount")]
        public string _TotalAmount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TotalAmount
        {
            get
            {
                if (double.TryParse(_TotalAmount, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TaxAmount")]
        public string _TaxAmount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TaxAmount
        {
            get
            {
                if (double.TryParse(_TaxAmount, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public string _TradeDiscountPercent { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TradeDiscountPercent
        {
            get
            {
                if (double.TryParse(_TradeDiscountPercent, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public string _TradeDiscountAmount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? TradeDiscountAmount
        {
            get
            {
                if (double.TryParse(_TradeDiscountAmount, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TaxExemptID1")]
        public string TaxExemptID1 { get; set; } = string.Empty;

        [XmlElement(ElementName = "BuildingPermit")]
        public string BuildingPermit { get; set; } = string.Empty;

        [XmlElement(ElementName = "ScheduleDistance")]
        public string _ScheduleDistance { get; set; } = string.Empty;
        [XmlIgnore]
        public double? ScheduleDistance
        {
            get
            {
                if (double.TryParse(_ScheduleDistance, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Removed")]
        public string _Removed { get; set; }
        public bool? Removed { get { if (bool.TryParse(_Removed, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PrintMixWeight")]
        public string _PrintMixWeight { get; set; }
        public bool? PrintMixWeight { get { if (bool.TryParse(_PrintMixWeight, out var value)) return value; return null; } }

        [XmlElement(ElementName = "PaymentTermsCode")]
        public string PaymentTermsCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "PaymentTermsName")]
        public string PaymentTermsName { get; set; } = string.Empty;

        [XmlElement(ElementName = "SalesmanID")]
        public string _SalesmanID { get; set; }
        public int? SalesmanID { get { if (int.TryParse(_SalesmanID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "SalesmanCode")]
        public string SalesmanCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; } = string.Empty;

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string SalesAnalysisCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SchedulingTruckTypeCode")]
        public string SchedulingTruckTypeCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "UpdateTime")]
        public string _UpdateTime { get; set; } = string.Empty;
        [XmlIgnore]
        public DateTime? UpdateTime
        {
            get
            {
                if (DateTime.TryParse(_UpdateTime, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Reviewed")]
        public string _Reviewed { get; set; }
        public bool? Reviewed { get { if (bool.TryParse(_Reviewed, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Suspended")]
        public string _Suspended { get; set; }
        public bool? Suspended { get { if (bool.TryParse(_Suspended, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Invoiced")]
        public string _Invoiced { get; set; }
        public bool? Invoiced { get { if (bool.TryParse(_Invoiced, out var value)) return value; return null; } }

        [XmlElement(ElementName = "CostAmount")]
        public string _CostAmount { get; set; } = string.Empty;
        [XmlIgnore]
        public double? CostAmount
        {
            get
            {
                if (double.TryParse(_CostAmount, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "Products")]
        public Products Products { get; set; } = null!;

        [XmlElement(ElementName = "BatchResult")]
        public BatchResult BatchResult { get; set; } = null!;

        [XmlElement(ElementName = "UserDefinedFields")]
        public UserDefinedFields UserDefinedFields { get; set; } = null!;

        [XmlElement(ElementName = "OrderUserDefinedFields")]
        public OrderUserDefinedFields OrderUserDefinedFields { get; set; } = null!;

        [XmlElement(ElementName = "CustomerUserDefinedFields")]
        public CustomerUserDefinedFields CustomerUserDefinedFields { get; set; } = null!;
    }

    [XmlRoot("UserDefinedFields")]
    public class UserDefinedFields
    {
        [XmlElement("UserDefinedField")]
        public List<UserDefinedField> UserDefinedField { get; set; } = null!;
    }

    [XmlRoot("UserDefinedField")]
    public class UserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot("OrderUserDefinedFields")]
    public class OrderUserDefinedFields
    {
        [XmlElement("OrderUserDefinedField")]
        public List<OrderUserDefinedField> OrderUserDefinedField { get; set; } = null!;
    }

    [XmlRoot("OrderUserDefinedField")]
    public class OrderUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot("CustomerUserDefinedFields")]
    public class CustomerUserDefinedFields
    {
        [XmlElement("CustomerUserDefinedField")]
        public List<CustomerUserDefinedField> CustomerUserDefinedField { get; set; } = null!;
    }

    [XmlRoot("CustomerUserDefinedField")]
    public class CustomerUserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Product")]
    public class Product
    {

        [XmlElement(ElementName = "ProductID")]
        public string _ProductID { get; set; }
        public int? ProductID { get { if (int.TryParse(_ProductID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemID")]
        public string _ItemID { get; set; }
        public int? ItemID { get { if (int.TryParse(_ItemID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "IsMix")]
        public string _IsMix { get; set; }
        public bool? IsMix { get { if (bool.TryParse(_IsMix, out var value)) return value; return null; } }

        [XmlElement(ElementName = "IsAssoc")]
        public string _IsAssoc { get; set; }
        public bool? IsAssoc { get { if (bool.TryParse(_IsAssoc, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ChargeType")]
        public string _ChargeType { get; set; }
        public int? ChargeType { get { if (int.TryParse(_ChargeType, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Price")]
        public string _Price { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? Price
        {
            get
            {
                if (decimal.TryParse(_Price, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PriceUnit")]
        public string PriceUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "OrderQty")]
        public string _OrderQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? OrderQty
        {
            get
            {
                if (decimal.TryParse(_OrderQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "OrderQtyUnit")]
        public string OrderQtyUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "LoadQty")]
        public string _LoadQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? LoadQty
        {
            get
            {
                if (decimal.TryParse(_LoadQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "DelvQty")]
        public string _DelvQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? DelvQty
        {
            get
            {
                if (decimal.TryParse(_DelvQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "DelvQtyUnit")]
        public string DelvQtyUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "AccDelvQty")]
        public string _AccDelvQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? AccDelvQty
        {
            get
            {
                if (decimal.TryParse(_AccDelvQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PreQty")]
        public string _PreQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? PreQty
        {
            get
            {
                if (decimal.TryParse(_PreQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TicketQty")]
        public string _TicketQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? TicketQty
        {
            get
            {
                if (decimal.TryParse(_TicketQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TicketQtyUnit")]
        public string TicketQtyUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "PriceQty")]
        public string _PriceQty { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? PriceQty
        {
            get
            {
                if (decimal.TryParse(_PriceQty, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PriceQtyUnit")]
        public string PriceQtyUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "Slump")]
        public string _Slump { get; set; } = string.Empty;
        public double? Slump
        {
            get
            {
                if(double.TryParse(_Slump, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TrimPercent")]
        public string _TrimPercent { get; set; } = string.Empty;
        [XmlIgnore]
        public decimal? TrimPercent
        {
            get
            {
                if (decimal.TryParse(_TrimPercent, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "TradeDiscountable")]
        public string _TradeDiscountable { get; set; }
        public bool? TradeDiscountable { get { if (bool.TryParse(_TradeDiscountable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Taxable")]
        public string _Taxable { get; set; }
        public bool? Taxable { get { if (bool.TryParse(_Taxable, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Tax1")]
        public string _Tax1 { get; set; }
        public double? Tax1 { get { if (double.TryParse(_Tax1, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Tax2")]
        public string _Tax2 { get; set; }
        public double? Tax2 { get { if (double.TryParse(_Tax2, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Tax3")]
        public string _Tax3 { get; set; }
        public double? Tax3 { get { if (double.TryParse(_Tax3, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Tax4")]
        public string _Tax4 { get; set; }
        public double? Tax4 { get { if (double.TryParse(_Tax4, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Tax5")]
        public string _Tax5 { get; set; }
        public double? Tax5 { get { if (double.TryParse(_Tax5, out var value)) return value; return null; } }

        [XmlElement(ElementName = "TaxAmount")]
        public string _TaxAmount { get; set; }
        public double? TaxAmount { get { if (double.TryParse(_TaxAmount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "Amount")]
        public string _Amount { get; set; }
        public double? Amount { get { if (double.TryParse(_Amount, out var value)) return value; return null; } }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ItemCategoryID")]
        public string _ItemCategoryID { get; set; }
        public int? ItemCategoryID { get { if (int.TryParse(_ItemCategoryID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemCategoryCode")]
        public string ItemCategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ItemCategoryAccountLinkCode")]
        public string ItemCategoryAccountLinkCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ProductLink")]
        public string ProductLink { get; set; } = string.Empty;

        [XmlElement(ElementName = "ItemTypeID")]
        public string _ItemTypeID { get; set; }
        public int? ItemTypeID { get { if (int.TryParse(_ItemTypeID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemTypeName")]
        public string ItemTypeName { get; set; } = string.Empty;

        [XmlElement(ElementName = "Cost")]
        public string _Cost { get; set; }
        public double? Cost { get { if (double.TryParse(_Cost, out var value)) return value; return null; } }

        [XmlElement(ElementName = "CostUnit")]
        public string CostUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "CostAmount")]
        public string _CostAmount { get; set; }
        public double? CostAmount { get { if (double.TryParse(_CostAmount, out var value)) return value; return null; } }
    }

    [XmlRoot(ElementName = "Products")]
    public class Products
    {

        [XmlElement(ElementName = "Product")]
        public List<Product> Product { get; set; } = null!;
    }

    [XmlRoot(ElementName = "Material")]
    public class Material
    {

        [XmlElement(ElementName = "ItemID")]
        public string _ItemID { get; set; }
        public int? ItemID { get { if (int.TryParse(_ItemID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemCode")]
        public string ItemCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement(ElementName = "BatchTarget")]
        public string _BatchTarget { get; set; }
        public double? BatchTarget { get { if (double.TryParse(_BatchTarget, out var value)) return value; return null; } }

        [XmlElement(ElementName = "BatchActual")]
        public string _BatchActual { get; set; }
        public double? BatchActual { get { if (double.TryParse(_BatchActual, out var value)) return value; return null; } }

        [XmlElement(ElementName = "BatchUnit")]
        public string BatchUnit { get; set; } = string.Empty;

        [XmlElement(ElementName = "MoisturePercent")]
        public string _MoisturePercent { get; set; }
        public double? MoisturePercent { get { if (double.TryParse(_MoisturePercent, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemCategoryID")]
        public string _ItemCategoryID { get; set; }
        public int? ItemCategoryID { get { if (int.TryParse(_ItemCategoryID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemCategoryCode")]
        public string ItemCategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ItemTypeID")]
        public string _ItemTypeID { get; set; }
        public int? ItemTypeID { get { if (int.TryParse(_ItemTypeID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "ItemTypeName")]
        public string ItemTypeName { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "BatchWeight")]
    public class BatchWeight
    {

        [XmlElement(ElementName = "Material")]
        public List<Material> Material { get; set; } = null!;
    }

    [XmlRoot(ElementName = "BatchResult")]
    public class BatchResult
    {

        [XmlElement(ElementName = "BatchWeight")]
        public BatchWeight BatchWeight { get; set; } = null!;
    }
}
