using System;
using System.ComponentModel.DataAnnotations;
namespace NorthwindMVC.Models
{

    #region Connect Base model classes to metadata
    [MetadataType(typeof(OrderMetaData))]
    public partial class Order { }
    #endregion


    /// <summary>
    /// Class used to define metadata attributes for Order class.
    /// </summary>
    public class OrderMetaData
    {
        public int OrderID;
        public string CustomerID;
        public Nullable<int> EmployeeID;
        [Display(Name = "Order date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Order date is required")]
        [DataType(DataType.Date, ErrorMessage = "Order data must be a valid date")
            , DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"
            , ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> OrderDate;
        /// <summary>
        /// Data annotation for Order Date make it required & validate the date value
        /// Required Date make it optional but validate the date value if entered
        /// </summary>
        [Display(Name = "Required Date")]
        [DataType(DataType.Date, ErrorMessage = "Required date must be a valid date")
            , DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"
            , ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> RequiredDate;
        [Display(Name = "Ship Date")]
        [DataType(DataType.Date, ErrorMessage = "Ship date must be a valid date")
            , DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}"
            , ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> ShippedDate;
        public Nullable<int> ShipVia;
        public Nullable<decimal> Freight;
        [Display(Name = "Ship To")]
        [MaxLength(256, ErrorMessage = "Name cannot exceed 256 characters")]
        public string ShipName;
        [Display(Name = "Mailing Address")]
        [MaxLength(256, ErrorMessage = "Name cannot exceed 256 characters")]
        public string ShipAddress;
        [Display(Name = "City")]
        [MaxLength(10, ErrorMessage = "Name cannot exceed 100 characters")]
        public string ShipCity;
        [Display(Name = "Region")]
        public string ShipRegion;
        [Display(Name = "Zip")]
        public string ShipPostalCode;
        [Display(Name = "Country")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string ShipCountry;
    }
}