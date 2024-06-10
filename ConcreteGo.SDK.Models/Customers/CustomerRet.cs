using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConcreteGo.SDK.Models.Customers
{
    [XmlRoot(ElementName = "CustomerRet")]
    public class CustomerRet
    {
        [XmlElement(ElementName = "ID")]
        public int ID { get; set; }

        [XmlElement(ElementName = "Code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "SortName")]
        public string SortName { get; set; }

        [XmlElement(ElementName = "SetupDate")]
        public DateTime SetupDate { get; set; }

        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }

        [XmlElement(ElementName = "InvoiceAddress")]
        public InvoiceAddress InvoiceAddress { get; set; }

        [XmlElement(ElementName = "StatementAddress")]
        public StatementAddress StatementAddress { get; set; }

        [XmlElement(ElementName = "Contact")]
        public object Contact { get; set; }

        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }

        [XmlElement(ElementName = "Fax")]
        public object Fax { get; set; }

        [XmlElement(ElementName = "Cellular")]
        public object Cellular { get; set; }

        [XmlElement(ElementName = "Email")]
        public string Email { get; set; }

        [XmlElement(ElementName = "QBInvoiceEmailChecked")]
        public bool QBInvoiceEmailChecked { get; set; }

        [XmlElement(ElementName = "Sales")]
        public Sales Sales { get; set; }

        [XmlElement(ElementName = "Taxing")]
        public Taxing Taxing { get; set; }

        [XmlElement(ElementName = "Pricing")]
        public Pricing Pricing { get; set; }

        [XmlElement(ElementName = "Charges")]
        public Charges Charges { get; set; }

        [XmlElement(ElementName = "Accounting")]
        public Accounting Accounting { get; set; }

        [XmlElement(ElementName = "Distribution")]
        public Distribution Distribution { get; set; }

        [XmlElement(ElementName = "DivisionID")]
        public int DivisionID { get; set; }

        [XmlElement(ElementName = "DivisionCode")]
        public string DivisionCode { get; set; }

        [XmlElement(ElementName = "UpdateDate")]
        public DateTime UpdateDate { get; set; }

        [XmlElement(ElementName = "InActive")]
        public bool InActive { get; set; }
        [XmlElement(ElementName = "UserDefinedFields")]
        public UserDefinedFields UserDefinedFields { get; set; }
    }

    [XmlRoot(ElementName = "UserDefinedFields")]
    public class UserDefinedFields
    {

        [XmlElement(ElementName = "UserDefinedField")]
        public List<UserDefinedField> UserDefinedField { get; set; }
    }

    [XmlRoot("UserDefinedField")]
    public class UserDefinedField
    {
        [XmlElement("Name")]
        public string Name { get; set; } = string.Empty;
        [XmlElement("Value")]
        public string Value { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Distribution")]
    public class Distribution
    {

        [XmlElement(ElementName = "TrackingOrderColorCode")]
        public object TrackingOrderColorCode { get; set; }

        [XmlElement(ElementName = "PrintMixWeightOnTicket")]
        public bool PrintMixWeightOnTicket { get; set; }

        [XmlElement(ElementName = "PrinterSelector")]
        public object PrinterSelector { get; set; }
    }

    [XmlRoot(ElementName = "Accounting")]
    public class Accounting
    {

        [XmlElement(ElementName = "StatementCycle")]
        public string StatementCycle { get; set; }

        [XmlElement(ElementName = "AccountingCategoryCode")]
        public int AccountingCategoryCode { get; set; }

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
        public object SuspendOrderReasonCode { get; set; }

        [XmlElement(ElementName = "UsageCodeRequiredInOrderEntry")]
        public bool UsageCodeRequiredInOrderEntry { get; set; }
    }

    [XmlRoot(ElementName = "CreditInformation")]
    public class CreditInformation
    {

        [XmlElement(ElementName = "Credit")]
        public Credit Credit { get; set; }
    }

    [XmlRoot(ElementName = "Credit")]
    public class Credit
    {

        [XmlElement(ElementName = "CompanyCode")]
        public int CompanyCode { get; set; }

        [XmlElement(ElementName = "CreditCode")]
        public int CreditCode { get; set; }

        [XmlElement(ElementName = "CreditChangeDate")]
        public object CreditChangeDate { get; set; }

        [XmlElement(ElementName = "CreditLimit")]
        public object CreditLimit { get; set; }

        [XmlElement(ElementName = "CurrentBalance")]
        public object CurrentBalance { get; set; }

        [XmlElement(ElementName = "HighBalance")]
        public object HighBalance { get; set; }

        [XmlElement(ElementName = "UpdateCredit")]
        public bool UpdateCredit { get; set; }

        [XmlElement(ElementName = "HighBalanceDate")]
        public object HighBalanceDate { get; set; }

        [XmlElement(ElementName = "CreditUpdateDate")]
        public object CreditUpdateDate { get; set; }

        [XmlElement(ElementName = "LastInvoiceDate")]
        public object LastInvoiceDate { get; set; }

        [XmlElement(ElementName = "CreditPersonCode")]
        public object CreditPersonCode { get; set; }

        [XmlElement(ElementName = "CreditPersonName")]
        public object CreditPersonName { get; set; }
    }

    [XmlRoot(ElementName = "CreditCard")]
    public class CreditCard
    {

        [XmlElement(ElementName = "CardName")]
        public object CardName { get; set; }

        [XmlElement(ElementName = "CardNumber")]
        public object CardNumber { get; set; }

        [XmlElement(ElementName = "ResponsibleName")]
        public object ResponsibleName { get; set; }
    }

    [XmlRoot(ElementName = "Charges")]
    public class Charges
    {

        [XmlElement(ElementName = "MinimumLoadChargeTableCode")]
        public string MinimumLoadChargeTableCode { get; set; }

        [XmlElement(ElementName = "SeasonalChargeTableCode")]
        public object SeasonalChargeTableCode { get; set; }

        [XmlElement(ElementName = "UnloadingChargeTableCode")]
        public string UnloadingChargeTableCode { get; set; }

        [XmlElement(ElementName = "ApplyMinimumLoadCharge")]
        public bool ApplyMinimumLoadCharge { get; set; }

        [XmlElement(ElementName = "ApplySeasonalCharge")]
        public bool ApplySeasonalCharge { get; set; }

        [XmlElement(ElementName = "ApplyUnloadingCharge")]
        public bool ApplyUnloadingCharge { get; set; }

        [XmlElement(ElementName = "PrintMinimumLoadChargeOnSeperateInvoice")]
        public bool PrintMinimumLoadChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "PrintSeasonalChargeOnSeperateInvoice")]
        public bool PrintSeasonalChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "PrintUnloadingChargeOnSeperateInvoice")]
        public bool PrintUnloadingChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "PrintAutomaticSundryChargeOnSeperateInvoice")]
        public bool PrintAutomaticSundryChargeOnSeperateInvoice { get; set; }

        [XmlElement(ElementName = "SundryCharges")]
        public object SundryCharges { get; set; }
    }

    [XmlRoot(ElementName = "Pricing")]
    public class Pricing
    {

        [XmlElement(ElementName = "PriceCategoryCode")]
        public int PriceCategoryCode { get; set; }

        [XmlElement(ElementName = "PriceCategoryName")]
        public string PriceCategoryName { get; set; }

        [XmlElement(ElementName = "PriceCategoryDescription")]
        public string PriceCategoryDescription { get; set; }

        [XmlElement(ElementName = "PricingPlantCode")]
        public int PricingPlantCode { get; set; }

        [XmlElement(ElementName = "TradeDiscountPercent")]
        public double TradeDiscountPercent { get; set; }

        [XmlElement(ElementName = "TradeDiscountAmount")]
        public double TradeDiscountAmount { get; set; }

        [XmlElement(ElementName = "TradeDiscountAmountUnitCode")]
        public string TradeDiscountAmountUnitCode { get; set; }

        [XmlElement(ElementName = "TermCode")]
        public object TermCode { get; set; }

        [XmlElement(ElementName = "ZoneCode")]
        public object ZoneCode { get; set; }

        [XmlElement(ElementName = "OverrideChargeRate")]
        public int OverrideChargeRate { get; set; }

        [XmlElement(ElementName = "OverrideChargeEfftiveDate")]
        public object OverrideChargeEfftiveDate { get; set; }

        [XmlElement(ElementName = "ApplyZoneCharges")]
        public bool ApplyZoneCharges { get; set; }

        [XmlElement(ElementName = "AllowPriceChangeInOrderEntry")]
        public bool AllowPriceChangeInOrderEntry { get; set; }

        [XmlElement(ElementName = "ControlPricePrintInOE")]
        public bool ControlPricePrintInOE { get; set; }

        [XmlElement(ElementName = "PrintPricesOnTicket")]
        public bool PrintPricesOnTicket { get; set; }

        [XmlElement(ElementName = "RestrictOrderstoCustomerProducts")]
        public bool RestrictOrderstoCustomerProducts { get; set; }

        [XmlElement(ElementName = "AllowAutomaticPriceAjustment")]
        public bool AllowAutomaticPriceAjustment { get; set; }
    }

    [XmlRoot(ElementName = "Address")]
    public class Address
    {

        [XmlElement(ElementName = "Addr1")]
        public string Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public object Addr2 { get; set; }

        [XmlElement(ElementName = "Addr3")]
        public object Addr3 { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }

        [XmlElement(ElementName = "State")]
        public string State { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public int PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
    }

    [XmlRoot(ElementName = "InvoiceAddress")]
    public class InvoiceAddress
    {

        [XmlElement(ElementName = "Addr1")]
        public object Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public object Addr2 { get; set; }

        [XmlElement(ElementName = "City")]
        public object City { get; set; }

        [XmlElement(ElementName = "State")]
        public object State { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public object PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public object Country { get; set; }
    }

    [XmlRoot(ElementName = "StatementAddress")]
    public class StatementAddress
    {

        [XmlElement(ElementName = "Name")]
        public object Name { get; set; }

        [XmlElement(ElementName = "Addr1")]
        public object Addr1 { get; set; }

        [XmlElement(ElementName = "Addr2")]
        public object Addr2 { get; set; }

        [XmlElement(ElementName = "City")]
        public object City { get; set; }

        [XmlElement(ElementName = "State")]
        public object State { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public object PostalCode { get; set; }

        [XmlElement(ElementName = "Country")]
        public int Country { get; set; }
    }

    [XmlRoot(ElementName = "Sales")]
    public class Sales
    {

        [XmlElement(ElementName = "SalesAnalysisCode")]
        public string SalesAnalysisCode { get; set; }

        [XmlElement(ElementName = "SalesmanCode")]
        public int SalesmanCode { get; set; }

        [XmlElement(ElementName = "SalesmanName")]
        public string SalesmanName { get; set; }
    }

    [XmlRoot(ElementName = "Taxing")]
    public class Taxing
    {

        [XmlElement(ElementName = "TaxID")]
        public object TaxID { get; set; }

        [XmlElement(ElementName = "TaxCode")]
        public string TaxCode { get; set; }

        [XmlElement(ElementName = "Taxable")]
        public string Taxable { get; set; }

        [XmlElement(ElementName = "NonTaxableReasonCode")]
        public object NonTaxableReasonCode { get; set; }
    }
}
