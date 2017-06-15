using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie3;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        #region FromMethods
        [TestMethod]
        public void GetProductsByName()
        {
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List <Product> products = new List<Product>();
                products = FromMethods.GetProductsByName("ML Mountain Frame-W - Silver, 40");
                Assert.IsTrue(products.Count == 1);

            }
        }


        [TestMethod]
        public void GetProductsByVendorName()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                products = FromMethods.GetProductsByVendorName("Vision Cycles, Inc.");
                Assert.IsTrue(products.Count == 3);
            }
        }


        [TestMethod]
        public void GetProductNamesByVendorName()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<String> products = new List<String>();
                products = FromMethods.GetProductNamesByVendorName("Vision Cycles, Inc.");
                Assert.IsTrue(products.Count > 0);
            }
        }

        [TestMethod]
        public void GetProductsWithNRecentReviews()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                products = FromMethods.GetProductsWithNRecentReviews(2);
                Assert.IsTrue(products.Count == 1);
            }
        }

        [TestMethod]
        public void GetNRecentlyReviewedProducts()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                products = FromMethods.GetNRecentlyReviewedProducts(2);
                Assert.IsTrue(products.Count == 2);
            }
        }


        [TestMethod]
        public void GetNProductsFromCategory()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                products = FromMethods.GetNProductsFromCategory("Accessories", 2);
                Assert.IsTrue(products.Count == 2);
            }
        }
        [TestMethod]
        public void GetTotalStandardCostByCategory()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                int sum;
                sum = FromMethods.GetTotalStandardCostByCategory("Accessories");
                Assert.IsTrue(sum == 996);
            }
        }



        #endregion


        #region ExtensionMethods
        [TestMethod]
        public void GetProductsWithoutCategory()
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                products = ExtensionMethods.GetProductsWithoutCategory("Accessories");
                Assert.IsTrue(products.Count > 200);

            }
        }


        [TestMethod]
        public void GetPageNumberWithNProducts()
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                products = ExtensionMethods.GetPageNumberWithNProducts(2,3);
                Assert.IsTrue(products.Count == 2);

            }
        }


        [TestMethod]
        public void getStringFromVendorAndProduct()
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                List<Product> products = new List<Product>();
                List<Product> productsafterextendedmethod = new List<Product>();
                products = ExtensionMethods.GetPageNumberWithNProducts(1, 3);
                products.getStringFromVendorAndProduct();
                Assert.IsTrue(products.getStringFromVendorAndProduct().Length > 0);

            }
        }




        #endregion

        #region MyProductMethods

        [TestMethod]
        public void getAllProducts()
        {
            MyProductMethods myproducts = new MyProductMethods();
            List<MyProduct> products = new List<MyProduct>();
            products = myproducts.getAllProducts();
            Assert.IsTrue(products.Count > 3);

        }


        [TestMethod]
        public void GetProductsByName_MyProduct()
        {
            MyProductMethods myproducts = new MyProductMethods();
            List<MyProduct> products = new List<MyProduct>();
            products = myproducts.GetProductsByName("Banana");
            Assert.IsTrue(products.Count > 0);

        }


        [TestMethod]
        public void GetProductsByID()
        {
            MyProductMethods myproducts = new MyProductMethods();
            List<MyProduct> products = new List<MyProduct>();
            products = myproducts.GetProductsWithIdMoreThanN(2);
            Assert.IsTrue(products.Count > 4);

        }





        #endregion
    }
}
