using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace M6.Data.Models
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [MaxLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }

    [Table("CustomerCustomerDemo")]
    public class CustomerCustomerDemo
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(5)]
        public string CustomerID { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(10)]
        public string CustomerTypeID { get; set; }
    }

    [Table("CustomerDemographics")]
    public class CustomerDemographics
    {
        [Key]
        [MaxLength(10)]
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    }

    [Table("Customers")]
    public class Customers
    {
        [Key]
        [MaxLength(5)]
        public string CustomerID { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(30)]
        public string ContactName { get; set; }
        [MaxLength(30)]
        public string ContactTitle { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string Region { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
        [MaxLength(24)]
        public string Fax { get; set; }
    }

    [Table("Employees")]
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(10)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        [MaxLength(25)]
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string Region { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(24)]
        public string HomePhone { get; set; }
        [MaxLength(4)]
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public int? ReportsTo { get; set; }
        [MaxLength(255)]
        public string PhotoPath { get; set; }
    }

    [Table("EmployeeTerritories")]
    public class EmployeeTerritories
    {
        [Key]
        [Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(20)]
        public string TerritoryID { get; set; }
    }

    [Table("Order Details")]
    public class Order_Details
{
    [Key]
    [Column(Order = 1)]
    public int OrderID { get; set; }
    [Key]
    [Column(Order = 2)]
    public int ProductID { get; set; }
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public Single Discount { get; set; }
}

    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [MaxLength(5)]
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        [MaxLength(40)]
        public string ShipName { get; set; }
        [MaxLength(60)]
        public string ShipAddress { get; set; }
        [MaxLength(15)]
        public string ShipCity { get; set; }
        [MaxLength(15)]
        public string ShipRegion { get; set; }
        [MaxLength(10)]
        public string ShipPostalCode { get; set; }
        [MaxLength(15)]
        public string ShipCountry { get; set; }
    }

    [Table("Products")]
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }

    [Table("Region")]
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        [MaxLength(50)]
        public string RegionDescription { get; set; }
    }

    [Table("Shippers")]
    public class Shippers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShipperID { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
    }

    [Table("Suppliers")]
    public class Suppliers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierID { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(30)]
        public string ContactName { get; set; }
        [MaxLength(30)]
        public string ContactTitle { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string Region { get; set; }
        [MaxLength(10)]
        public string PostalCode { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(24)]
        public string Phone { get; set; }
        [MaxLength(24)]
        public string Fax { get; set; }
        public string HomePage { get; set; }
    }

    [Table("Territories")]
    public class Territories
    {
        [Key]
        [MaxLength(20)]
        public string TerritoryID { get; set; }
        [MaxLength(50)]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
    }


}
