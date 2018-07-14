using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace Northwind.Data.Entities
{
    //The Table annotation points to the table in the sql database that this class defines
    [Table("Products")]
    //By default a class is private and cannot be used anywhere else
    public class Product
    {
        //Create a property for each attribute on the sql table
        //use C# data type for the sql attributes
        //Rules:
        // a) If you use the attribute name as your property name the order of properties is not important
        // b) If you do not use the attribute nAME AS YOUR PROPERTY NAME, THE ORDER OF PROPERTIES MUST match the order of attibutes
        // c) Foriegn keys do not need an annotation if the property name is the same as the attribute name
        // d) Primary Keys are by default treated as identity. If your pkey is not an IDENTITY, the you must add a .DataGenerated(DataGeneratedOption.xxxx) annotation parameter
        // e) Primary key properties are best defaulted to end in ID (id)
        // f) Compound pkeys all described using the column (order=n) parameter where n is 1, 2, 3, 4,.....etc. (Physical Oreder of sql attrinute

        [Key]
        public int ProdcutID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; } //Foreign key
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInSotck { get; set; }
        public Int16? UnitsonOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }

        //Sometimes you will wanr annother property in your class that will return a non attribute value to the user
        //Example Name which could be created by the first and last name properties
        //To create these non mapped (non existing sql attributes) properties use the annotation [Not Mapped]

        [NotMapped]
        public string ProductIDName {
            get
            {
                return ProductName + "(" + ProdcutID.ToString() + ")";
            }
        }
    }
}
