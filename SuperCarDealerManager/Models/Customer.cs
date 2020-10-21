using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCarDealerManager.Models
{
    public class Customer
    {
        public int Id { get; set; } // Primary Key for Customer Table

        [Required]// this field is Required to be filed in
        [Display(Name = "First Name")]// the interface column name
        public string FirstName { get; set; }// the First Name of the Customer 

        [Required]// this field is Required to be filed in
        [Display(Name = "Last Name")]// the interface column name
        public string LastName { get; set; }// the Last Name of the Customer 

        [Display(Name = "Full Name")]// the interface column name
        public string FullName // the Full Name of the Customer 
        {
            get { return FirstName + " " + LastName; }
        }

        [Required]// this field is Required to be filed in
        [Display(Name = "Address")]// the interface column name
        public string Address { get; set; } // the Address of the Customer 

        [Required]// this field is Required to be filed in
        [DataType(DataType.EmailAddress)]// this field only allows string in the Email address format
        public string Email { get; set; }// the Email address of the Customer 

        [DataType(DataType.PhoneNumber)]// this field only allows numbers in the Phone Number format
        public int Phone { get; set; } // the Phone number of the Customer 
    }
}
