using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Trucks
{
    [XmlRoot("TruckRet")]
    public class TruckRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "Active")]
        public bool Active { get; set; }

        [XmlElement(ElementName = "OwnerName")]
        public string OwnerName { get; set; }

        [XmlElement(ElementName = "LicenseNumber")]
        public string LicenseNumber { get; set; }

        [XmlElement(ElementName = "LicenseExpirationDate")]
        public string _LicenseExpirationDate { get; set; }
        public DateTime? LicenseExpirationDate
        {
            get
            {
                if(DateTime.TryParse(_LicenseExpirationDate, out var value))
                {
                    return value;
                }
                return null;
            }
        }

        [XmlElement(ElementName = "PlantID")]
        public int PlantID { get; set; }

        [XmlElement(ElementName = "PlantCode")]
        public string PlantCode { get; set; }

        [XmlElement(ElementName = "PlantName")]
        public string PlantName { get; set; }

        [XmlElement(ElementName = "DriverID")]
        public string DriverID { get; set; }

        [XmlElement(ElementName = "DriverCode")]
        public string DriverCode { get; set; }

        [XmlElement(ElementName = "DriverName")]
        public string DriverName { get; set; }

        [XmlElement(ElementName = "CurrentPlantID")]
        public int CurrentPlantID { get; set; }

        [XmlElement(ElementName = "CurrentPlantCode")]
        public string CurrentPlantCode { get; set; }

        [XmlElement(ElementName = "CurrentPlantName")]
        public string CurrentPlantName { get; set; }

        //[XmlElement(ElementName = "CurrentDriverID")]
        //public int CurrentDriverID { get; set; }

        //[XmlElement(ElementName = "CurrentDriverCode")]
        //public string CurrentDriverCode { get; set; }

        //[XmlElement(ElementName = "CurrentDriverName")]
        //public string CurrentDriverName { get; set; }

        //[XmlElement(ElementName = "TruckTypeID")]
        //public int TruckTypeID { get; set; }

        //[XmlElement(ElementName = "TruckTypeCode")]
        //public string TruckTypeCode { get; set; }

        //[XmlElement(ElementName = "TruckTypeName")]
        //public string TruckTypeName { get; set; }

        //[XmlElement(ElementName = "ProductLine")]
        //public string ProductLine { get; set; }

        //[XmlElement(ElementName = "MinimumLoadSize")]
        //public double MinimumLoadSize { get; set; }

        //[XmlElement(ElementName = "MinimumLoadSizeUnitID")]
        //public int MinimumLoadSizeUnitID { get; set; }

        //[XmlElement(ElementName = "MinimumLoadSizeUnit")]
        //public string MinimumLoadSizeUnit { get; set; }

        //[XmlElement(ElementName = "MinimumLoadSizeUnitCode")]
        //public string MinimumLoadSizeUnitCode { get; set; }

        //[XmlElement(ElementName = "ScheduleLoadSize")]
        //public double ScheduleLoadSize { get; set; }

        //[XmlElement(ElementName = "ScheduleLoadSizeUnitID")]
        //public int ScheduleLoadSizeUnitID { get; set; }

        //[XmlElement(ElementName = "ScheduleLoadSizeUnit")]
        //public string ScheduleLoadSizeUnit { get; set; }

        //[XmlElement(ElementName = "ScheduleLoadSizeUnitCode")]
        //public string ScheduleLoadSizeUnitCode { get; set; }

        //[XmlElement(ElementName = "MaximumLoadSize")]
        //public double MaximumLoadSize { get; set; }

        //[XmlElement(ElementName = "MaximumLoadSizeUnitID")]
        //public int MaximumLoadSizeUnitID { get; set; }

        //[XmlElement(ElementName = "MaximumLoadSizeUnit")]
        //public string MaximumLoadSizeUnit { get; set; }

        //[XmlElement(ElementName = "MaximumLoadSizeUnitCode")]
        //public string MaximumLoadSizeUnitCode { get; set; }

        //[XmlElement(ElementName = "TareWeight")]
        //public double TareWeight { get; set; }

        //[XmlElement(ElementName = "TareWeightUnitID")]
        //public int TareWeightUnitID { get; set; }

        //[XmlElement(ElementName = "TareWeightUnit")]
        //public string TareWeightUnit { get; set; }

        //[XmlElement(ElementName = "TareWeightUnitCode")]
        //public string TareWeightUnitCode { get; set; }

        //[XmlElement(ElementName = "DaysTareIsValid")]
        //public int DaysTareIsValid { get; set; }

        //[XmlElement(ElementName = "TareType")]
        //public string TareType { get; set; }

        //[XmlElement(ElementName = "DeliveryMethod")]
        //public string DeliveryMethod { get; set; }

        //[XmlElement(ElementName = "FOBonly")]
        //public bool FOBonly { get; set; }

        //[XmlElement(ElementName = "RadioCode")]
        //public string RadioCode { get; set; }

        //[XmlElement(ElementName = "AutomaticSignaling")]
        //public bool AutomaticSignaling { get; set; }

        //[XmlElement(ElementName = "EnableGPS")]
        //public bool EnableGPS { get; set; }

        //[XmlElement(ElementName = "EnableAutoStatusing")]
        //public bool EnableAutoStatusing { get; set; }

        //[XmlElement(ElementName = "NumberOfDrops")]
        //public int NumberOfDrops { get; set; }

        //[XmlElement(ElementName = "SignalingUnitCode")]
        //public int SignalingUnitCode { get; set; }

        //[XmlElement(ElementName = "Latitude")]
        //public string Latitude { get; set; }

        //[XmlElement(ElementName = "Longitude")]
        //public string Longitude { get; set; }

        //[XmlElement(ElementName = "LocationUpdateTime")]
        //public DateTime LocationUpdateTime { get; set; }

        //[XmlElement(ElementName = "StatusCode")]
        //public string StatusCode { get; set; }

        //[XmlElement(ElementName = "StatusTimeStamp")]
        //public DateTime StatusTimeStamp { get; set; }

        //[XmlElement(ElementName = "TicketID")]
        //public int TicketID { get; set; }

        //[XmlElement(ElementName = "ReturnedMaterialQty")]
        //public double ReturnedMaterialQty { get; set; }

        //[XmlElement(ElementName = "SetupDate")]
        //public DateTime SetupDate { get; set; }

        //[XmlElement(ElementName = "VIN")]
        //public string VIN { get; set; }

        //[XmlElement(ElementName = "Flag")]
        //public string Flag { get; set; }

        //[XmlElement(ElementName = "ColorCode")]
        //public string ColorCode { get; set; }

        //[XmlElement(ElementName = "FontColorCode")]
        //public string FontColorCode { get; set; }

        //[XmlElement(ElementName = "PermanentColorCode")]
        //public string PermanentColorCode { get; set; }
    }
}
