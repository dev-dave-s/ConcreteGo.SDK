using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.ItemCategories
{
    [XmlRoot(ElementName = "ItemCategoryRet")]
    public class ItemCategoryRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "ItemTypeID")]
        public int ItemTypeID { get; set; }

        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; }
    }
}
