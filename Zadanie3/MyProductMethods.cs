using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class MyProductMethods
    {

        public List<MyProduct> fruits = new List<MyProduct>();

        public MyProductMethods()
        {
            MyProduct product1 = new MyProduct(1, "Banana", "1", "Yellow");
            MyProduct product2 = new MyProduct(2, "Stawberry", "2", "Red");
            MyProduct product3 = new MyProduct(3, "Apple", "3", "Red");
            MyProduct product4 = new MyProduct(4, "Orange", "4", "Orange");
            MyProduct product5 = new MyProduct(5, "Lemon", "5", "Lemon");
            MyProduct product6 = new MyProduct(6, "Grapes", "6", "Green");
            MyProduct product7 = new MyProduct(7, "Peach", "7", "Red");
            fruits.Add(product1);
            fruits.Add(product2);
            fruits.Add(product3);
            fruits.Add(product4);
            fruits.Add(product5);
            fruits.Add(product6);
            fruits.Add(product7);
        }

        
        public List<MyProduct> getAllProducts()
        {
            
            List<MyProduct> query = fruits.Select(x => x).ToList();

            foreach (var x in query)
            {
                Console.WriteLine(x);
            }


            return query;
        }



        public List<MyProduct> GetProductsByName(string namePart)
        {

            List<MyProduct> query = fruits.Select(x => x).Where(x => x.Name.Contains(namePart)).ToList();

            foreach (var x in query)
            {
                Console.WriteLine(x);
            }

         
            return query;
        }


        public List<MyProduct> GetProductsWithIdMoreThanN(int n)
        {
            List<MyProduct> query = (from fruits in fruits
                                     where fruits.Product_ID > n
                                     select fruits).ToList();


            foreach (var x in query)
            {
                Console.WriteLine(x);
            }


            return query;
        }






        }
}
