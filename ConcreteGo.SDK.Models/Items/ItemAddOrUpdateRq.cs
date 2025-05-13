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
        [XmlElement(ElementName = "Action")]
        public string Action { get; set; }

        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;

        //Include Ret
        public List<string> IncludeRetElement { get; set; } = new List<string>();
    }
}
