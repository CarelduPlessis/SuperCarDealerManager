using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuperCarDealerManager.Models
{
    public class Car
    {
        public int Id { get; set; } // Primary Key for Car Table

        [Required] // this field is Required to be filed in
        [Display(Name = "Car Brand Name")] // the interface column name 
        public string CarBrandName { get; set; } // the name of the brand of the Car 

        [Required] // this field is Required to be filed in
        public string CarModel { get; set; } // the name of the model of the Car 

        [Required] // this field is Required to be filed in
        [MaxLength(4)] // this field have a max input length of 4 characters
        [MinLength(4)] // this field have a min input length of 4 characters
        [RegularExpression("^[0-9]*$", ErrorMessage = "Year Needs 4 numbers")] // this field only allows numbers
        [Display(Name = "Year")] // the interface column name  
        public string CarYear { get; set; } // the Year of the Car

        [Required] // this field is Required to be filed in
        [Display(Name = "Fuel Type")] // the interface column name  
        public FuelType Fuel { get; set; } // Create method using type FuelType Named Fuel

        [Required] // this field is Required to be filed in
        [Display(Name = "Transmission Type")] // the interface column name 
        public TransmissionType Transmission { get; set; }// Create method using type TransmissionType Named Transmission

        [Required] // this field is Required to be filed in
        [Display(Name = "Color")] // the interface column name 
        public string Color { get; set; } // the Color of the Car

        [Required] // this field is Required to be filed in
        [Display(Name = "InStock")] // the interface column name 
        public int InStock { get; set; } // the number of this Car InStock

        // Foreign Key of the Supplier Table
        [ForeignKey("SupplierFK")]
        [Display(Name = "Supplier")] // the interface column name 
        public Supplier supplier { get; set; }
        public int SupplierFK { get; set; }
    }

    public enum FuelType // Create enum method named FuelType
    {
        Diesel,
        BioFuel,
        EthanolFuel,
        Electrical,
        Hybrid
    }

    public enum TransmissionType // Create enum method named TransmissionType
    {
        Automatic,
        Manual,
        CVT,
        DCT,
        DSG,
        Tiptronic
    }
}
