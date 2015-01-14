using MYOB.AccountRight.SDK.Contracts.Version2.Contact;
using MYOB.AccountRight.SDK.Contracts.Version2.GeneralLedger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYOB.AccountRight.SDK.Contracts.Version2.Purchase
{
    /// <summary>
    /// Purchase
    /// </summary>
    public class Purchase : BaseEntity
    {
        /// <summary>
        /// Order number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Supplier invoice number
        /// </summary>
        public string SupplierInvoiceNumber { get; set; }

        /// <summary>
        /// Supplier
        /// </summary>
        public SupplierLink Supplier { get; set; }

        /// <summary>
        /// Ship to address
        /// </summary>
        public string ShipToAddress { get; set; }

        /// <summary>
        /// Is tax inclusive
        /// </summary>
        public bool IsTaxInclusive { get; set; }

        /// <summary>
        /// Is reportable
        /// </summary>
        public bool? IsReportable { get; set; }

        /// <summary>
        /// Subtotal
        /// </summary>
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Total tax
        /// </summary>
        public decimal TotalTax { get; set; }

        /// <summary>
        /// Total amount
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Journal memo
        /// </summary>
        public string JournalMemo { get; set; }

        /// <summary>
        /// Freight tax code
        /// </summary>
        public TaxCodeLink FreightTaxCode { get; set; }

        /// <summary>
        /// Freight amount
        /// </summary>
        public decimal? Freight { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        public CategoryLink Category { get; set; }

        /// <summary>
        /// Applied to date
        /// </summary>
        public decimal AppliedToDate { get; set; }

        /// <summary>
        /// Balance due amount
        /// </summary>
        public decimal BalanceDueAmount { get; set; }
    }
}
