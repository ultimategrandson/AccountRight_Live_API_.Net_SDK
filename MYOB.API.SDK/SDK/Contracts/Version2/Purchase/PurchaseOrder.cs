using System;
using MYOB.AccountRight.SDK.Contracts.Version2.Contact;
using MYOB.AccountRight.SDK.Contracts.Version2.GeneralLedger;
using MYOB.AccountRight.SDK.Contracts.Version2.Sale;

namespace MYOB.AccountRight.SDK.Contracts.Version2.Purchase
{
    /// <summary>
    /// Describe the Purchase/Order resource
    /// </summary>
    public class PurchaseOrder : Purchase
    {       
        /// <summary>
        /// The current status of the purchase
        /// </summary>
        public PurchaseOrderStatus Status { get; set; }

        /// <summary>
        /// The date of the last payment made on the invoice
        /// </summary>
        public DateTime? LastPaymentDate { get; set; }

        /// <summary>
        /// The type of the order
        /// </summary>
        public OrderLayoutType OrderType { get; set; }
    
    }

    /// <summary>
    /// The status of an <see cref="PurchaseOrder" />
    /// </summary>
    public enum PurchaseOrderStatus
    {
        /// <summary>
        /// The order is still open
        /// </summary>
        Open,

        /// <summary>
        /// The order has since been converted to an bill
        /// </summary>
        ConvertedToBill
    }
}
