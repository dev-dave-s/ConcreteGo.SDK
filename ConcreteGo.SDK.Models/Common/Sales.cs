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
        public string SalesAnalysisCode { get; set; }

        [XmlElement(ElementName = "SalesmanCode")]
        public string _SalesmanCode { get; set; } = string.Empty;
        [XmlIgnore]
        public int? SalesmanCode { get { if (int.TryParse(_SalesmanCode, out var value)) return value; return null; } }

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; }
    }
}
