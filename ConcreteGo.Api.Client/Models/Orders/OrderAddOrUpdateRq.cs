using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Orders
{
    [XmlRoot(ElementName = "OrderUpdate", Namespace = "")]
    public class OrderAddOrUpdateRq
    {
        /// <summary>
        /// Required - The ID of the order to update
        /// </summary>
        [XmlElement("ID")]
        public int ID { get; set; }

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
    }
}