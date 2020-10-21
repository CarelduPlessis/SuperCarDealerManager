using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperCarDealerManager.Models
{
    public class Store
    {
        public int Id { get; set; } // Primary Key for Store Table

        [Required]// this field is Required to be filed in
        [Display(Name = "Date Of Purchase")]// the interface column name 
        public DateTime DateOfPurchase { get; set; } // when the car was purchased

        [Required]// this field is Required to be filed in
        [Display(Name = "Warranty Duration (Number of Years)")]// the interface column name 
        public int WarrantyDuration { get; set; }  // the duration of the warranty on the car

        /* Foreign Key of the Car Table*/
        [ForeignKey("CarFK")]
        public Car car { get; set; }
        [Display(Name = "Car")]// the interface column name 
        public int CarFK { get; set; }

        /* Foreign Key of the Customer Table*/
        [ForeignKey("CustomerFK")]
        public Customer customer { get; set; }
        [Display(Name = "Customer")]// the interface column name 
        public int CustomerFK { get; set; }
    }
}
