using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Plants
{
    [XmlRoot(ElementName = "PlantRet")]
    public class PlantRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "Address1")]
        public string Address1 { get; set; }

        [XmlElement(ElementName = "Address2")]
        public string Address2 { get; set; }

        [XmlElement(ElementName = "Address3")]
        public string Address3 { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "LocationID")]
        public int LocationID { get; set; }

        [XmlElement(ElementName = "LocationCode")]
        public string LocationCode { get; set; }

        [XmlElement(ElementName = "CompanyID")]
        public int CompanyID { get; set; }

        [XmlElement(ElementName = "CompanyCode")]
        public string CompanyCode { get; set; }

        [XmlElement(ElementName = "WindowsTimeZone")]
        public string WindowsTimeZone { get; set; }

        [XmlElement(ElementName = "IANATimeZone")]
        public string IANATimeZone { get; set; }

        [XmlElement(ElementName = "Latitude")]
        public string Latitude { get; set; }

        [XmlElement(ElementName = "Longitude")]
        public string Longitude { get; set; }

        [XmlElement(ElementName = "MaxBatchSize")]
        public string _MaxBatchSize { get; set; }
        [XmlIgnore]
        public double? MaxBatchSize
        {
            get
            {
                if(double.TryParse(_MaxBatchSize, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "MaxBatchSizeUnit")]
        public string MaxBatchSizeUnit { get; set; }

        [XmlElement(ElementName = "MaxBatchSizeUnitID")]
        public string _MaxBatchSizeUnitID { get; set; }
        [XmlIgnore]
        public int? MaxBatchSizeUnitID
        {
            get
            {
                if(int.TryParse(_MaxBatchSizeUnitID, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "MaxBatchSizeUnitCode")]
        public string MaxBatchSizeUnitCode { get; set; }

        [XmlElement(ElementName = "AccountLinkCode")]
        public string AccountLinkCode { get; set; }

        [XmlElement(ElementName = "TruckRentalCostPerHour")]
        public string _TruckRentalCostPerHour { get; set; }
        [XmlIgnore]
        public double? TruckRentalCostPerHour
        {
            get
            {
                if (double.TryParse(_TruckRentalCostPerHour, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "AdministrationCost")]
        public string _AdministrationCost { get; set; }
        [XmlIgnore]
        public double? AdministrationCost
        {
            get
            {
                if (double.TryParse(_AdministrationCost, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "SalesCost")]
        public string _SalesCost { get; set; }
        public double? SalesCost
        {
            get
            {
                if (double.TryParse(_SalesCost, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "DispatchCost")]
        public string _DispatchCost { get; set; }
        public double? DispatchCost
        {
            get
            {
                if (double.TryParse(_DispatchCost, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "PlantCost")]
        public string _PlantCost { get; set; }
        public double? PlantCost
        {
            get
            {
                if (double.TryParse(_PlantCost, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "FixedTruckCost")]
        public string _FixedTruckCost { get; set; }
        public double? FixedTruckCost
        {
            get
            {
                if (double.TryParse(_FixedTruckCost, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "YearlyInterestRate")]
        public string _YearlyInterestRate { get; set; }
        public double? YearlyInterestRate
        {
            get
            {
                if (double.TryParse(_YearlyInterestRate, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "TruckProductiveFactor")]
        public string _TruckProductiveFactor { get; set; }
        public double? TruckProductiveFactor
        {
            get
            {
                if (double.TryParse(_TruckProductiveFactor, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "DesiredProfitPerQuantity")]
        public string _DesiredProfitPerQuantity { get; set; }
        public double? DesiredProfitPerQuantity
        {
            get
            {
                if (double.TryParse(_DesiredProfitPerQuantity, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "TaxCode")]
        public string? TaxCode { get; set; }
    }
}
