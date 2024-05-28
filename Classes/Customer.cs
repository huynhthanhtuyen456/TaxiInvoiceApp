using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiInvoiceApp.Classes
{
    public class Customer
    {
        private int Id { get; set; }
        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private string? Address { get; set; }
        private PhoneAttribute? Phone { get; set; }
        private EmailAddressAttribute? Email { get; set; }
    }
}
