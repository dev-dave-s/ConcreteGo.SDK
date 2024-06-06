using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Trucks
{
    [XmlRoot(ElementName = "TruckUpdate", Namespace = "")]
    public class TruckAddOrUpdateRq
    {
        [XmlElement(ElementName = "ID")]
        public int? ID { get; set; }
        public bool ShouldSerializeID() { return ID != null; }

        [XmlElement(ElementName = "Code")]
        public string? Code { get; set; }
        [XmlElement("Action")]
        //add, edit, update, delete.
        public string Action { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]

        public string? Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string? ShortDescription { get; set; }

        [XmlElement(ElementName = "Active")]
        public bool? Active { get; set; } 
        public bool ShouldSerializeActive() { return Active != null; }

        [XmlElement(ElementName = "OwnerName")]
        public string? OwnerName { get; set; }

        [XmlElement(ElementName = "LicenseNumber")]
        public string? LicenseNumber { get; set; }

        [XmlElement(ElementName = "LicenseExpirationDate")]
        public DateTime? LicenseExpirationDate { get; set; }
        public bool ShouldSerializeLicenseExpirationDate() { return LicenseExpirationDate != null; }

        [XmlElement(ElementName = "PlantID")]
        public int? PlantID { get; set; }
        public bool ShouldSerializePlantID() { return PlantID != null; }

        [XmlElement(ElementName = "PlantCode")]
        public string? PlantCode { get; set; }

        [XmlElement(ElementName = "PlantName")]
        public string? PlantName { get; set; }

        [XmlElement(ElementName = "DriverID")]
        public int? DriverID { get; set; }
        public bool ShouldSerializeDriverID() { return DriverID != null; }

        [XmlElement(ElementName = "DriverCode")]
        public string? DriverCode { get; set; }

        [XmlElement(ElementName = "DriverName")]
        public string? DriverName { get; set; }

        [XmlElement(ElementName = "CurrentPlantID")]
        public int? CurrentPlantID { get; set; }
        public bool ShouldSerializeCurrentPlantID() { return CurrentPlantID != null; }

        [XmlElement(ElementName = "CurrentPlantCode")]
        public string? CurrentPlantCode { get; set; }

        [XmlElement(ElementName = "CurrentPlantName")]
        public string? CurrentPlantName { get; set; }

        [XmlElement(ElementName = "CurrentDriverID")]
        public int? CurrentDriverID { get; set; }
        public bool ShouldSerializeCurrentDriverID() { return CurrentDriverID != null; }

        [XmlElement(ElementName = "CurrentDriverCode")]
        public string? CurrentDriverCode { get; set; }

        [XmlElement(ElementName = "CurrentDriverName")]
        public string? CurrentDriverName { get; set; }

        [XmlElement(ElementName = "TruckTypeID")]
        public int? TruckTypeID { get; set; }
        public bool ShouldSerializeTruckTypeID() { return TruckTypeID != null; }

        [XmlElement(ElementName = "TruckTypeCode")]
        public string? TruckTypeCode { get; set; }

        [XmlElement(ElementName = "TruckTypeName")]
        public string? TruckTypeName { get; set; }

        [XmlElement(ElementName = "ProductLine")]
        public string? ProductLine { get; set; }

        [XmlElement(ElementName = "MinimumLoadSize")]
        public double? MinimumLoadSize { get; set; }
        public bool ShouldSerializeMinimumLoadSize() { return MinimumLoadSize != null; }

        [XmlElement(ElementName = "MinimumLoadSizeUnitID")]
        public int? MinimumLoadSizeUnitID { get; set; }
        public bool ShouldSerializeMinimumLoadSizeUnitID() { return MinimumLoadSizeUnitID != null; }

        [XmlElement(ElementName = "MinimumLoadSizeUnit")]
        public string? MinimumLoadSizeUnit { get; set; }

        [XmlElement(ElementName = "MinimumLoadSizeUnitCode")]
        public string? MinimumLoadSizeUnitCode { get; set; }

        [XmlElement(ElementName = "ScheduleLoadSize")]
        public double? ScheduleLoadSize { get; set; }
        public bool ShouldSerializeScheduleLoadSize() { return ScheduleLoadSize != null; }

        [XmlElement(ElementName = "ScheduleLoadSizeUnitID")]
        public int? ScheduleLoadSizeUnitID { get; set; }
        public bool ShouldSerializeScheduleLoadSizeUnitID() { return ScheduleLoadSizeUnitID != null; }

        [XmlElement(ElementName = "ScheduleLoadSizeUnit")]
        public string? ScheduleLoadSizeUnit { get; set; }

        [XmlElement(ElementName = "ScheduleLoadSizeUnitCode")]
        public string? ScheduleLoadSizeUnitCode { get; set; }

        [XmlElement(ElementName = "MaximumLoadSize")]
        public double? MaximumLoadSize { get; set; }
        public bool ShouldSerializeMaximumLoadSize() { return MaximumLoadSize != null; }

        [XmlElement(ElementName = "MaximumLoadSizeUnitID")]
        public int? MaximumLoadSizeUnitID { get; set; }
        public bool ShouldSerializeMaximumLoadSizeUnitID() { return MaximumLoadSizeUnitID != null; }

        [XmlElement(ElementName = "MaximumLoadSizeUnit")]
        public string? MaximumLoadSizeUnit { get; set; }

        [XmlElement(ElementName = "MaximumLoadSizeUnitCode")]
        public string? MaximumLoadSizeUnitCode { get; set; }

        [XmlElement(ElementName = "TareWeight")]
        public double? TareWeight { get; set; }
        public bool ShouldSerializeTareWeight() { return TareWeight != null; }

        [XmlElement(ElementName = "TareWeightUnitID")]
        public int? TareWeightUnitID { get; set; }
        public bool ShouldSerializeTareWeightUnitID() { return TareWeightUnitID != null; }

        [XmlElement(ElementName = "TareWeightUnit")]
        public string? TareWeightUnit { get; set; }

        [XmlElement(ElementName = "TareWeightUnitCode")]
        public string? TareWeightUnitCode { get; set; }

        [XmlElement(ElementName = "DaysTareIsValid")]
        public int? DaysTareIsValid { get; set; }
        public bool ShouldSerializeDaysTareIsValid() { return DaysTareIsValid != null; }

        [XmlElement(ElementName = "TareType")]
        public string? TareType { get; set; }

        [XmlElement(ElementName = "DeliveryMethod")]
        public string? DeliveryMethod { get; set; }

        [XmlElement(ElementName = "FOBonly")]
        public bool? FOBonly { get; set; }
        public bool ShouldSerializeFOBonly() { return FOBonly != null; }

        [XmlElement(ElementName = "RadioCode")]
        public string RadioCode { get; set; }

        [XmlElement(ElementName = "AutomaticSignaling")]
        public bool? AutomaticSignaling { get; set; }
        public bool ShouldSerializeAutomaticSignaling() { return AutomaticSignaling != null; }

        [XmlElement(ElementName = "EnableGPS")]
        public bool? EnableGPS { get; set; }
        public bool ShouldSerializeEnableGPS() { return EnableGPS != null; }

        [XmlElement(ElementName = "EnableAutoStatusing")]
        public bool? EnableAutoStatusing { get; set; }
        public bool ShouldSerializeEnableAutoStatusing() { return EnableAutoStatusing != null; }

        [XmlElement(ElementName = "NumberOfDrops")]
        public int? NumberOfDrops { get; set; }
        public bool ShouldSerializeNumberOfDrops() { return NumberOfDrops != null; }

        [XmlElement(ElementName = "SignalingUnitCode")]
        public int? SignalingUnitCode { get; set; }
        public bool ShouldSerializeSignalingUnitCode() { return SignalingUnitCode != null; }

        [XmlElement(ElementName = "Latitude")]
        public string? Latitude { get; set; }

        [XmlElement(ElementName = "Longitude")]
        public string? Longitude { get; set; }

        [XmlElement(ElementName = "LocationUpdateTime")]
        public DateTime? LocationUpdateTime { get; set; }
        public bool ShouldSerializeLocationUpdateTime() { return LocationUpdateTime != null; }

        [XmlElement(ElementName = "StatusCode")]
        public string StatusCode { get; set; }

        [XmlElement(ElementName = "StatusTimeStamp")]
        public DateTime? StatusTimeStamp { get; set; }
        public bool ShouldSerializeStatusTimeStamp() { return StatusTimeStamp != null; }

        [XmlElement(ElementName = "TicketID")]
        public int? TicketID { get; set; }
        public bool ShouldSerializeTicketID() { return TicketID != null; }

        [XmlElement(ElementName = "ReturnedMaterialQty")]
        public double? ReturnedMaterialQty { get; set; }
        public bool ShouldSerializeReturnedMaterialQty() { return ReturnedMaterialQty != null; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime? SetupDate { get; set; }
        public bool ShouldSerializeSetupDate() { return SetupDate != null; }

        [XmlElement(ElementName = "VIN")]
        public string? VIN { get; set; }

        [XmlElement(ElementName = "Flag")]
        public string? Flag { get; set; }

        [XmlElement(ElementName = "ColorCode")]
        public string? ColorCode { get; set; }

        [XmlElement(ElementName = "FontColorCode")]
        public string? FontColorCode { get; set; }

        [XmlElement(ElementName = "PermanentColorCode")]
        public string? PermanentColorCode { get; set; }
    }
}
