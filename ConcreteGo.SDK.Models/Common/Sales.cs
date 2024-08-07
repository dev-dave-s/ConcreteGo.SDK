using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common
{
    [XmlRoot(ElementName = "Sales")]
    public class Sales
    {

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string SalesAnalysisCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SalesmanCode")]
        public string SalesmanCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; } = string.Empty;
    }
}
