using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common
{
    [XmlRoot(ElementName = "Charges")]
    public class Charges
    {

        [XmlElement(ElementName = "MinimumLoadChargeTableCode")]
        public string MinimumLoadChargeTableCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SeasonalChargeTableCode")]
        public string SeasonalChargeTableCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "UnloadingChargeTableCode")]
        public string UnloadingChargeTableCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ApplyMinimumLoadCharge")]
        public bool ApplyMinimumLoadCharge { get; set; }

        [XmlElement(ElementName = "ApplySeasonalCharge")]
        public bool ApplySeasonalCharge { get; set; }

        [XmlElement(ElementName = "ApplyUnloadingCharge")]
        public bool ApplyUnloadingCharge { get; set; }

        [XmlElement(ElementName = "PrintMinimumLoadChargeOnSeperateInvoice")]
        public bool PrintMinimumLoadChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "PrintSeasonalChargeOnSeperateInvoice")]
        public bool PrintSeasonalChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "PrintUnloadingChargeOnSeperateInvoice")]
        public bool PrintUnloadingChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "PrintAutomaticSundryChargeOnSeperateInvoice")]
        public bool PrintAutomaticSundryChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "SundryCharges")]
        public object SundryCharges { get; set; }
    }
}
