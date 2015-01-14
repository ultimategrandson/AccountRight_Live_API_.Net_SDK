using System;
using MYOB.AccountRight.SDK.Contracts.Version2.Contact;
using MYOB.AccountRight.SDK.Contracts.Version2.GeneralLedger;
using MYOB.AccountRight.SDK.Contracts.Version2.Sale;

namespace MYOB.AccountRight.SDK.Contracts.Version2.Purchase
{
    /// <summary>
    /// Describe the Purchase/Bill resource
    /// </summary>
    public class Bill : Purchase
    {
        /// <summary>
        /// The payment terms
        /// </summary>
        public InvoiceTerms Terms { get; set; }

        /// <summary>
        /// A general comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// What is the shipping method
        /// </summary>
        public string ShippingMethod { get; set; }

        /// <summary>
        /// When is the payment promised
        /// </summary>
        public DateTime? PromisedDate { get; set; }
       
        /// <summary>
        /// Bill delivery status assigned.
        /// </summary>
        public DocumentAction BillDeliveryStatus { get; set; }

        /// <summary>
        /// The current status of the purchase
        /// </summary>
        public PurchaseStatus Status { get; set; }

        /// <summary>
        /// The date of the last payment made on the invoice
        /// </summary>
        /// <remarks>
        /// Availability: 2013.5 (Cloud), 2014.1 (Desktop)
        /// </remarks>
        public DateTime? LastPaymentDate { get; set; }

        /// <summary>
        /// The type of Bill - this is only populated when querying the "/Purchase/Bill" endpoint
        /// </summary>
        public BillType BillType { get; set; }

        /// <summary>
        /// The source Purchase Order when an Bill is converted from an Purchase Order
        /// or when you wish to convert an existing Open Purchase Order to a new Bill
        /// Available from 2014.4
        /// </summary>
        public PurchaseOrderLink Order { get; set; }
    }

    /// <summary>
    /// Describe the link to the Purchase/Order resource
    /// </summary>
    public class PurchaseOrderLink: BaseLink
    {
        /// <summary>
        /// The number of the purchase order
        /// </summary>
        public string Number { get; set; }
    }
}
