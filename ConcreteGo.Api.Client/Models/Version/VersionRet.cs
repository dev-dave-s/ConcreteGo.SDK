using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Version
{
    [XmlRoot(ElementName = "VersionQueryRs")]
    public class VersionRet
    {
        [XmlElement(ElementName = "ConcreteGoVersion")]
        public string ConcreteGoVersion { get; set; } = string.Empty;   

        [XmlElement(ElementName = "WebcreteVersion")]
        public string WebcreteVersion { get; set; } = string.Empty;
    }
}
