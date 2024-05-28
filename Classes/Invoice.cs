using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiInvoiceApp.Interfaces;

namespace TaxiInvoiceApp.Classes
{
    public class Invoice
    {
        private string? Number { get; set; }
        private DateTime ExportedDate { get; set; }
        private Customer? Customer { get; set; }
        protected float TaxRate { get; set; }
    }

    public class TaxiInvoice : Invoice, ITaxInvoiceCalculation
    {
        public float TotalKM { get; set; }
        public decimal OpenDoorPrice { get; set; }
        public decimal FirstKM2ThirstyPrice { get; set; }
        public decimal WaitingFee { get; set; }
        public decimal FromThirstyOneKMPrice { get; set; }
        private readonly float TaxRate = 0.2F;

        public decimal SubTotal()
        {
            decimal subTotal = this.OpenDoorPrice + this.FirstKM2ThirstyPrice * 30 + this.FromThirstyOneKMPrice * (decimal)(this.TotalKM - 30.0) + this.WaitingFee;
            return subTotal;
        }

        public decimal Total ()
        {
            decimal total = this.SubTotal() + this.Tax();
            return total;
        }

        public decimal Tax()
        {
            decimal tax = this.SubTotal() * (decimal)this.TaxRate;
            return tax;
        }
    }
}
