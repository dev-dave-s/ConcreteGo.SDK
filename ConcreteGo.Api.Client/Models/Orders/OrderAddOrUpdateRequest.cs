using ConcreteGo.Api.Client.Models.Options;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderUpdateRq", Namespace = "")]
    public class OrderAddOrUpdateRequest
    {
        [XmlElement(ElementName = "OrderUpdate")]
        public List<OrderUpdate>? OrderUpdate { get; set; }
       
    }

    [XmlRoot(ElementName = "OrderUpdate")]
    public class OrderUpdate
    {
        /// <summary>
        /// Required - The ID of the order to update
        /// </summary>
        [XmlElement("ID")]
        public int? ID { get; set; }

        /// <summary>
        /// Optional - Sets the invoiced status of the order
        /// </summary>
        [XmlElement("Invoiced")]
        public bool? Invoiced { get; set; }

        /// <summary>
        /// Determines if Invoiced should be serialized
        /// </summary>
        public bool ShouldSerializeInvoiced()
        {
            return Invoiced.HasValue;
        }

        [XmlElement("InvoiceNumber")]
        public string? InvoiceNumber { get; set; }
        /// <summary>
        /// Determines if Invoiced should be serialized
        /// </summary>
        public bool ShouldSerializeInvoiceNumber()
        {
            return !string.IsNullOrEmpty(InvoiceNumber);
        }

        /// <summary>
        /// Optional - Sets the current status of the order.
        /// 0 = Normal, 1 = Will Call, 2 = Weather Permitting,
        /// 3 = Hold Delivery, 4 = Completed, 5 = Wait List
        /// </summary>
        [XmlElement("CurrentStatus")]
        public int? CurrentStatus { get; set; }

        /// <summary>
        /// Determines if CurrentStatus should be serialized
        /// </summary>
        public bool ShouldSerializeCurrentStatus()
        {
            return CurrentStatus.HasValue;
        }
    }

    /// <summary>
    /// Represents the possible status values for an order.
    /// </summary>
    public enum OrderStatus
    {
        Normal = 0,
        WillCall = 1,
        WeatherPermitting = 2,
        HoldDelivery = 3,
        Completed = 4,
        WaitList = 5
    }
}