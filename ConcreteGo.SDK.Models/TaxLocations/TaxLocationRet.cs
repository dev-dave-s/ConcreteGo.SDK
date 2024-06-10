using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.TaxLocations
{
    [XmlRoot(ElementName = "TaxLocationRet")]
    public class TaxLocationRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "ShortDescription")]
        public string ShortDescription { get; set; }

        [XmlElement(ElementName = "TaxAuthorityID")]
        public int TaxAuthorityID { get; set; }

        [XmlElement(ElementName = "TaxAuthorityCode")]
        public string TaxAuthorityCode { get; set; }

        [XmlElement(ElementName = "CurrentRate")]
        public double CurrentRate { get; set; }

        [XmlElement(ElementName = "EffectiveDate")]
        public DateTime EffectiveDate { get; set; }

        [XmlElement(ElementName = "PreviousRate")]
        public double PreviousRate { get; set; }

        [XmlElement(ElementName = "MaxTaxableAmount")]
        public double MaxTaxableAmount { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonID")]
        public string _NonTaxableReasonID { get; set; }
        [XmlIgnore]
        public int? NonTaxableReasonID
        {
            get
            {
                if(int.TryParse(_NonTaxableReasonID, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public string NonTaxableReasonCode { get; set; }

        [XmlElement(ElementName = "CalculateTaxOnDiscount")]
        public bool CalculateTaxOnDiscount { get; set; }

        [XmlElement(ElementName = "ReadyMixDeliveryExempt")]
        public bool ReadyMixDeliveryExempt { get; set; }

        [XmlElement(ElementName = "ReadyMixNonTaxableReasonID")]
        public string _ReadyMixNonTaxableReasonID { get; set; }
        [XmlIgnore]
        public int? ReadyMixNonTaxableReasonID 
        {
            get
            {
                if (int.TryParse(_ReadyMixNonTaxableReasonID, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "ReadyMixNonTaxableReasonCode")]
        public string ReadyMixNonTaxableReasonCode { get; set; }

        [XmlElement(ElementName = "ReadyMixExemptionType")]
        public int ReadyMixExemptionType { get; set; }

        [XmlElement(ElementName = "ReadyMixExemptionRate")]
        public string _ReadyMixExemptionRate { get; set; }
        [XmlIgnore]
        public double? ReadyMixExemptionRate
        {
            get
            {
                if (double.TryParse(_ReadyMixExemptionRate, out var value)) return value; return null; 
            }
        }

        [XmlElement(ElementName = "ReadyMixExemptionUnitID")]
        public string _ReadyMixExemptionUnitID { get; set; }
        [XmlIgnore]
        public int? ReadyMixExemptionUnitID
        {
            get
            {
                if(int.TryParse(_ReadyMixExemptionUnitID, out var value)) return value; return null;
            }
        }

        [XmlElement(ElementName = "ReadyMixExemptionUnitCode")]
        public string ReadyMixExemptionUnitCode { get; set; }
    }
}
