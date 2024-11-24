using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Common {
    [XmlRoot(ElementName = "Accounting")]
    public class AccountingRq {

        [XmlElement(ElementName = "AccountingCategoryCode")]
        public string? AccountingCategoryCode { get; set; }

        [XmlElement(ElementName = "PrepaymentPercentage")]
        public decimal? PrepaymentPercentage { get; set; }

        [XmlElement(ElementName = "CreditCard")]
        public CreditCardRq? CreditCard { get; set; } 
    
        [XmlElement(ElementName = "CreditInformation")]
        public CreditInformationRq? CreditInformation { get; set; } 
    
        [XmlElement(ElementName = "PurchaseOrderRequiredInOrderEntry")]
        public bool? PurchaseOrderRequiredInOrderEntry { get; set; }
    
        [XmlElement(ElementName = "CustomerJobRequiredInOrderEntry")]
        public bool? CustomerJobRequiredInOrderEntry { get; set; }
    
        [XmlElement(ElementName = "LotBlockRequiredInOrderEntry")]
        public bool? LotBlockRequiredInOrderEntry { get; set; }
    
        [XmlElement(ElementName = "LotBlock")]
        public string? LotBlock { get; set; }
    
        [XmlElement(ElementName = "SuspendOrderReasonCode")]
        public bool? SuspendOrderReasonCode { get; set; }
    
        [XmlElement(ElementName = "UsageCodeRequiredInOrderEntry")]
        public bool? UsageCodeRequiredInOrderEntry { get; set; }
    
    }

    [XmlRoot(ElementName = "CreditCard")]
    public class CreditCardRq {

        [XmlElement(ElementName = "CardName")]
        public string? CardName { get; set; }
    
        [XmlElement(ElementName = "CardNumber")]
        public string? CardNumber { get; set; }
    
        [XmlElement(ElementName = "ResponsibleName")]
        public string? ResponsibleName { get; set; }
    
        [XmlElement(ElementName = "ExpirationDate")]
        public string? ExpirationDate { get; set; }
    
    }
    
    [XmlRoot(ElementName = "CreditInformation")]
    public class CreditInformationRq {

        [XmlElement(ElementName = "Credit")]
        public CreditRq? CardName { get; set; }
    
    }

    [XmlRoot(ElementName = "Credit")]
    public class CreditRq {

        [XmlElement(ElementName = "CreditCode")]
        public string? CreditCode { get; set; }
    
        [XmlElement(ElementName = "CreditEffectiveDate")]
        public DateTime? CreditEffectiveDate { get; set; }
    
    }
}