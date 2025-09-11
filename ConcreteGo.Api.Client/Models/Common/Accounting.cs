using ConcreteGo.Api.Client.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.Api.Client.Models.Common
{
    [XmlRoot(ElementName = "Accounting")]
    public class Accounting
    {

        [XmlElement(ElementName = "StatementCycle")]
        public string StatementCycle { get; set; } = string.Empty;

        [XmlElement(ElementName = "AccountingCategoryCode")]
        public string AccountingCategoryCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "ApplyFinanceCharges")]
        public bool ApplyFinanceCharges { get; set; }

        [XmlElement(ElementName = "PrintStatements")]
        public bool PrintStatements { get; set; }

        [XmlElement(ElementName = "CreditCard")]
        public CreditCard CreditCard { get; set; }

        [XmlElement(ElementName = "CreditInformation")]
        public CreditInformation CreditInformation { get; set; }

        [XmlElement(ElementName = "PurchaseOrderRequiredInOrderEntry")]
        public bool PurchaseOrderRequiredInOrderEntry { get; set; }

        [XmlElement(ElementName = "CustomerJobRequiredInOrderEntry")]
        public bool CustomerJobRequiredInOrderEntry { get; set; }

        [XmlElement(ElementName = "ExternalLiensRequiredInOrderEntry")]
        public bool ExternalLiensRequiredInOrderEntry { get; set; }

        [XmlElement(ElementName = "SuspendOrderReasonCode")]
        public string SuspendOrderReasonCode { get; set; } = string.Empty;

        [XmlElement(ElementName = "UsageCodeRequiredInOrderEntry")]
        public bool UsageCodeRequiredInOrderEntry { get; set; }
    }
}
