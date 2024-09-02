using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Customers
{
    [XmlRoot(ElementName = "CustomerUpdate", Namespace = "")]
    public class CustomerAddOrUpdateRq
    {
        [XmlElement(ElementName = "Action")]
        public string Action { get; set; }
        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "UserDefinedFields")]
        public UserDefinedFields UserDefinedFields { get; set; }
        //SUNDRYCHARGE, USERDEFINEDFIELD
        public List<string> IncludeRetElement { get; set; } = new List<string>();
    }


}
