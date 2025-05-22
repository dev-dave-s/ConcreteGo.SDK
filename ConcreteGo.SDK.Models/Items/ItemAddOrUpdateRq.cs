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

        [XmlElement(ElementName = "CategoryCode")]
        public string CategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; } = string.Empty;

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; } = string.Empty;

        [XmlElement(ElementName = "DoNotAllowTicketing")]
        public bool DoNotAllowTicketing { get; set; } = false;

        [XmlElement(ElementName = "IsConstituent")]
        public bool IsConstituent { get; set; } = false;
        
        [XmlElement(ElementName = "IsResaleable")]
        public bool IsResaleable { get; set; } = false;

        [XmlElement(ElementName = "KeepInInventory")]
        public bool KeepInInventory { get; set; } = false;

        [XmlElement(ElementName = "ItemTypeID")]
        public int? ItemTypeID { get; set; }

        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; } = string.Empty;

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        [XmlElement(ElementName = "UOM")]
        public UOM UOM { get; set; } = null!;

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; } = null!;

        [XmlElement(ElementName = "Mix")]
        public Mix Mix { get; set; } = null!;

        [XmlElement(ElementName = "Locations")]
        public Locations Locations { get; set; } = null!;

        [XmlElement(ElementName = "TaxOverrides")]
        public TaxOverrides TaxOverrides { get; set; } = null!;

        //Include Ret
        public List<string> IncludeRetElement { get; set; } = new List<string>();
    }
}
