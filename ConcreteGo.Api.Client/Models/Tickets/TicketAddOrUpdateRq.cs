using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Tickets
{
    [XmlRoot(ElementName = "TicketUpdate", Namespace = "")]
    public class TicketAddOrUpdateRq
    {
        /// <summary>
        /// Required - The ID of the ticket to update
        /// </summary>
        [XmlElement("ID")]
        public int ID { get; set; }

        /// <summary>
        /// Optional - Sets the invoiced status of the ticket
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