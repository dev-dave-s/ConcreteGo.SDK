using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Common
{
    [XmlRoot(ElementName = "Distribution")]
    public class Distribution
    {

        [XmlElement(ElementName = "TrackingOrderColorCode")]
        public object TrackingOrderColorCode { get; set; }

        [XmlElement(ElementName = "PrintMixWeightOnTicket")]
        public bool PrintMixWeightOnTicket { get; set; }

        [XmlElement(ElementName = "PrinterSelector")]
        public object PrinterSelector { get; set; }
    }
}
