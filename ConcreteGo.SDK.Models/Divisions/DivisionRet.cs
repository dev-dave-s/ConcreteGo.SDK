using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Divisions
{

    [XmlRoot(ElementName = "DivisionRet")]
    public class DivisionRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "ParentID")]
        public string _ParentID { get; set; }
        [XmlIgnore]
        public int? ParentID { get { if (int.TryParse(_ParentID, out var value)) return value; return null; } }

        [XmlElement(ElementName = "HierarchyID")]
        public string HierarchyID { get; set; }
    }
}
