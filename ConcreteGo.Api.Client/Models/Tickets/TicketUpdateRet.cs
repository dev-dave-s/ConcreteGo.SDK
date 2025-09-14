using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Tickets
{
    [XmlRoot(ElementName = "TicketRet")]
    public class TicketUpdateRet
    {
        /// <summary>
        /// The ID of the ticket that was updated
        /// </summary>
        [XmlElement("ID")]
        public int ID { get; set; }

        /// <summary>
        /// The action that was performed (e.g., "Update")
        /// </summary>
        [XmlElement("Action")]
        public string Action { get; set; } = string.Empty;
    }
}