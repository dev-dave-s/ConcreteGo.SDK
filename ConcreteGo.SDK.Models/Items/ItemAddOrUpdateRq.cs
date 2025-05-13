using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Items
{
    [XmlRoot(ElementName = "ItemUpdate", Namespace = "")]
    public class ItemAddOrUpdateRq
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; } = string.Empty;

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; }

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; } = null!;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;

        //Include Ret
        public List<string> IncludeRetElement { get; set; } = new List<string>();
    }
}
