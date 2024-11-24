using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common {
    [XmlRoot(ElementName = "Charges")]
public class ChargesRq {

    [XmlElement(ElementName = "MinimumLoadChargeTableCode")]
    public string? MinimumLoadChargeTableCode { get; set; }

    [XmlElement(ElementName = "SeasonalChargeTableCode")]
    public string? SeasonalChargeTableCode { get; set; }
    
    [XmlElement(ElementName = "UnloadingChargeTableCode")]
    public string? UnloadingChargeTableCode { get; set; }
    
    [XmlElement(ElementName = "ApplyMinimumLoadCharge")]
    public bool? ApplyMinimumLoadCharge { get; set; }
    
    [XmlElement(ElementName = "ApplySeasonalCharge")]
    public bool? ApplySeasonalCharge { get; set; }
    
    [XmlElement(ElementName = "ApplyUnloadingCharge")]
    public bool? ApplyUnloadingCharge { get; set; }
    
    [XmlElement(ElementName = "PrintMinimumLoadChargeOnSeperateInvoice")]
    public bool? PrintMinimumLoadChargeOnSeperateInvoice { get; set; }
    
    [XmlElement(ElementName = "PrintSeasonalChargeOnSeperateInvoice")]
    public bool? PrintSeasonalChargeOnSeperateInvoice { get; set; }
    
    [XmlElement(ElementName = "PrintUnloadingChargeOnSeperateInvoice")]
    public bool? PrintUnloadingChargeOnSeperateInvoice { get; set; }
    
    [XmlElement(ElementName = "PrintAutomaticSundryChargeOnSeperateInvoice")]
    public bool? PrintAutomaticSundryChargeOnSeperateInvoice { get; set; }
    
    [XmlElement(ElementName = "SundryCharges")]
    public SundryChargesRq? SundryCharges { get; set; } 
    
}

[XmlRoot(ElementName = "SundryCharges")]
public class SundryChargesRq {
    
    [XmlAttribute("Method")] // PUT|PATCH
    public string Method { get; set; } = string.Empty;

    [XmlElement(ElementName = "SundryCharge")]
    public List<SundryChargeRq>? SundryCharge { get; set; } = new List<SundryChargeRq>();

}

[XmlRoot(ElementName = "SundryCharge")]
public class SundryChargeRq {

    [XmlAttribute("Action")] // UPSERT|DELETE
    public string Action { get; set; } = string.Empty;
    
    [XmlElement(ElementName = "SundryChargeID")]
    public int? SundryChargeID { get; set; }
    
    [XmlElement(ElementName = "SundryChargeCode")]
    public string? SundryChargeCode { get; set; }
    
    [XmlElement(ElementName = "ApplySundryCharge")]
    public bool? ApplySundryCharge { get; set; }
    
    [XmlElement(ElementName = "Price")]
    public double? Price { get; set; }
    
    [XmlElement(ElementName = "PriceUnitID")]
    public int? PriceUnitID { get; set; }
    
    [XmlElement(ElementName = "PriceUnitCode")]
    public string? PriceUnitCode { get; set; }
    
    [XmlElement(ElementName = "PriceUnit")]
    public string? PriceUnit { get; set; }
    
    [XmlElement(ElementName = "PriceExtensionCode")]
    public string? PriceExtensionCode { get; set; }
    
    [XmlElement(ElementName = "EffectiveDate")]
    public DateTime? EffectiveDate { get; set; }
    
    [XmlElement(ElementName = "PreviousPrice")]
    public double? PreviousPrice { get; set; }
    
    [XmlElement(ElementName = "PreviousPriceUnitID")]
    public int? PreviousPriceUnitID { get; set; }
    
    [XmlElement(ElementName = "PreviousPriceUnitCode")]
    public int? PreviousPriceUnitCode { get; set; }
    
    [XmlElement(ElementName = "PreviousPriceUnit")]
    public string? PreviousPriceUnit { get; set; }
    
    [XmlElement(ElementName = "PreviousPriceExtensionCode")]
    public string? PreviousPriceExtensionCode { get; set; }
    
    [XmlElement(ElementName = "CreateSeperateInvoice")]
    public bool? CreateSeperateInvoice { get; set; }
    
}
}