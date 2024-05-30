using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiInvoiceApp.Classes
{
    public class Company
    {
        public required string Name { get; set; }
        public required TaxiPrice TaxiPrice { get; set; }
    }

    public class TaxiPrice
    {
        public decimal OpenDoorPrice { get; set; }
        public decimal FirstKM2ThirstyPrice { get; set; }
        public decimal FromThirstyOneKMPrice { get; set; }
        public decimal WaitingFeePerHour { get; set; }
    }
}
