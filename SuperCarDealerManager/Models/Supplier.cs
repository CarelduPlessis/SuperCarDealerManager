using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCarDealerManager.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; } // Primary Key for Supplier Table

        //[Required] // this field is Required to be filed in
        [Display(Name = "Name of Supplier")] // the interface column name 
        public string SupplierName { get; set; } // the name of the Supplier for the Cars 

        //[Required] // this field is Required to be filed in
        //[DataType(DataType.EmailAddress)] // this field only allows string in the Email address format
        public string Email { get; set; } // the Email Address of the Supplier 

        //[DataType(DataType.PhoneNumber)] // this field only allows numbers in the Phone Number format
        public int Phone { get; set; } // the Phone number of the Supplier 
    }
}
