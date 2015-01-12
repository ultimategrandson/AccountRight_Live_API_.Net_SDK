using MYOB.AccountRight.SDK.Contracts.Version2.Contact;
using MYOB.AccountRight.SDK.Contracts.Version2.GeneralLedger;
using MYOB.AccountRight.SDK.Contracts.Version2.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYOB.AccountRight.SDK.Contracts.Version2.Purchase
{
    /// <summary>
    /// Interface for similar fields between Bill and PurchaseOrder
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Order number
        /// </summary>
        string Number { get; set; }
        
        /// <summary>
        /// Order date
        /// </summary>
        DateTime Date { get; set; }
        
        /// <summary>
        /// Supplier invoice number
        /// </summary>
        string SupplierInvoiceNumber { get; set; }
        
        /// <summary>
        /// Supplier
        /// </summary>
        SupplierLink Supplier { get; set; }
        
        /// <summary>
        /// Ship to address
        /// </summary>
        string ShipToAddress { get; set; }
        
        /// <summary>
        /// Is tax inclusive
        /// </summary>
        bool IsTaxInclusive { get; set; }
        
        /// <summary>
        /// Is reportable
        /// </summary>
        bool? IsReportable { get; set; }
        
        /// <summary>
        /// Subtotal
        /// </summary>
        decimal Subtotal { get; set; }
        
        /// <summary>
        /// Total tax
        /// </summary>
        decimal TotalTax { get; set; }
        
        /// <summary>
        /// Total amount
        /// </summary>
        decimal TotalAmount { get; set; }
        
        /// <summary>
        /// Journal memo
        /// </summary>
        string JournalMemo { get; set; }
        
        /// <summary>
        /// Freight tax code
        /// </summary>
        TaxCodeLink FreightTaxCode { get; set; }
        
        /// <summary>
        /// Freight amount
        /// </summary>
        decimal? Freight { get; set; }
        
        /// <summary>
        /// Category
        /// </summary>
        CategoryLink Category { get; set; }
        
        /// <summary>
        /// Applied to date
        /// </summary>
        decimal AppliedToDate { get; set; }
        
        /// <summary>
        /// Balance due amount
        /// </summary>
        decimal BalanceDueAmount { get; set; }
    }
}
