using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ekran görevi görecek main kısmı
namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
           Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInstack = 3;
              // diğer ürünü de bu formatta yazabiliriz.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInstack = 5, ProductName = "kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add();
        }
    }
}
