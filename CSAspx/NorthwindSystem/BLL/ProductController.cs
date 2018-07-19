
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespace
using Northwind.Data.Entities;
using NorthwindSystem.DAL;
#endregion

namespace NorthwindSystem.BLL
{
    //This is the public interface class that will handle web page service requests for data to the Product sql table
    //Methods in this class can interact with the internal DAL Context class
    public class ProductController
    {
        //This method will return all records from the sql table Products
        //This method will first create a transaction code bock which uses the DAL Context class
        //The Context class has a DbSet<Product> property for referencing the sql table 
        //The Property works with entity framework to retieve the data
        public List<Product> Products_List() //This method will be underline because it wants a return statement
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();// add the .ToList() to convert Products into a List
            }
        }

        //This methode will return a specific method from the sql product table based on the primary key
        public Product products_GetProduct(int productid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }

    }
    public class SupplierController
    {

        public List<Supplier> Suppliers_List() //This method will be underline because it wants a return statement
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.ToList();// add the .ToList() to convert Products into a List
            }
        }

        //This methode will return a specific method from the sql Supplier table based on the primary key
        public Supplier Suppliers_GetSupplier(int supplierid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }

    }

    public class CategoryController
    {
        public List<Category> Categories_List() //This method will be underline because it wants a return statement
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.ToList();// add the .ToList() to convert Products into a List
            }
        }

        //This methode will return a specific method from the sql Supplier table based on the primary key
        public Category Categories_GetCategory(int categoryid)
        {
            using (var context = new NorthwindContext())
            {
                return context.Categories.Find(categoryid);
            }
        }

    }


}
