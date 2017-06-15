using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public static class ExtensionMethods
    {
        public static List<Product> GetProductsWithoutCategory(string categoryName)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> query = 
                    db.Products.Select(x => (x)).Where(y => y.ProductSubcategoryID == null).ToList();

                foreach (var x in query)
                {
                    Console.WriteLine(x.Name + " " + x.ProductID);
                }

                return query;
             }



        }


        public static List<Product> GetPageNumberWithNProducts(int n, int pagenumber)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {

                List<Product> query = db.Products.OrderBy(x => x.ProductID).Skip(n * pagenumber).Take(n).ToList();

                foreach (var x in query)
                {
                    Console.WriteLine(x.Name + " " + x.ProductID);
                }

                return query;

               


            }
        }


        public static String getStringFromVendorAndProduct(this List<Product> products)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                
                    var query = (from product in db.Products
                             join productvendor in db.ProductVendors
                             on product.ProductID equals productvendor.ProductID
                             join vendor in db.Vendors
                             on productvendor.BusinessEntityID equals vendor.BusinessEntityID

                             select new
                             {
                                 ProductName = product.Name,
                                
                                 VendordName = vendor.Name,

                             }).ToList();

                        ;


                foreach (var x in query)
                {
                    Console.WriteLine(x.ProductName + " ; " + x.VendordName);
                }
                
                return query.ToString();

            }
        }
    }
}
