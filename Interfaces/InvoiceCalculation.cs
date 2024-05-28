using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiInvoiceApp.Interfaces
{
    public interface ITaxInvoiceCalculation
    {
        public decimal Total();
        public decimal SubTotal();
    }
}
