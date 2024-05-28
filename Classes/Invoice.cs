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
        public DateTime ExportedDate = DateTime.Now;
        private Customer? Customer { get; set; }
        protected float TaxRate = 0.2F;
    }

    public class TaxiInvoice : Invoice, ITaxInvoiceCalculation
    {
        public float TotalKM { get; set; }
        public required Company Company { get; set; }
        public int WaitingHours { get; set; }

        public decimal SubTotal()
        {
            decimal first2ThirstyKM = this.Company.TaxiPrice.FirstKM2ThirstyPrice * (decimal)this.TotalKM;
            decimal subTotal = this.Company.TaxiPrice.OpenDoorPrice + first2ThirstyKM + this.WaitingFee();
            if (this.TotalKM > 30) subTotal += this.Company.TaxiPrice.FromThirstyOneKMPrice * (decimal)(this.TotalKM - 30.0);
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

        public decimal WaitingFee()
        {
            decimal watingFee = this.Company.TaxiPrice.WaitingFeePerHour * (decimal)this.WaitingHours;
            return watingFee;
        }
    }
}
