using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common {
    [XmlRoot(ElementName = "Distribution")]
    public class DistributionRq {

        [XmlElement(ElementName = "TrackingOrderColorCode")]
        public string? TrackingOrderColorCode { get; set; }
    
        [XmlElement(ElementName = "PrintMixWeightOnTicket")]
        public bool? PrintMixWeightOnTicket { get; set; }
        public bool ShouldSerializePrintMixWeightOnTicket() { return PrintMixWeightOnTicket != null; }
    
        [XmlElement(ElementName = "ProjectType")]
        public string? ProjectType { get; set; }
    
        [XmlElement(ElementName = "Stage")]
        public string? Stage { get; set; }
    
        [XmlElement(ElementName = "MapPage")]
        public string? MapPage { get; set; }
    
        [XmlElement(ElementName = "EstimatedTravelTime")]
        public double? EstimatedTravelTime { get; set; }
        public bool ShouldSerializeEstimatedTravelTime() { return EstimatedTravelTime != null; }
    
        // 1 Do Not Poll, 2 Poll First Truck, 3 Poll Every Truck
        [XmlElement(ElementName = "TruckPollType")]
        public string? TruckPollType { get; set; }
    
        [XmlElement(ElementName = "UpdateProjectMapCoordinates")]
        public bool? UpdateProjectMapCoordinates { get; set; }
        public bool ShouldSerializeUpdateProjectMapCoordinates() { return UpdateProjectMapCoordinates != null; }
    
        [XmlElement(ElementName = "UpdateOrderMapCoordinates")]
        public bool? UpdateOrderMapCoordinates { get; set; }
        public bool ShouldSerializeUpdateOrderMapCoordinates() { return UpdateOrderMapCoordinates != null; }
    
        [XmlElement(ElementName = "DefaultOrderType")]
        public string? DefaultOrderType { get; set; }
    
        [XmlElement(ElementName = "SchedulePlantCode")]
        public string? SchedulePlantCode { get; set; }
    
        [XmlElement(ElementName = "TruckTypeCode")]
        public string? TruckTypeCode { get; set; }
    
        [XmlElement(ElementName = "DeliveryMethod")]
        public string? DeliveryMethod { get; set; }
    }
}