using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//entity-varlık
namespace OOP1
{
    class Product
    {
        public int Id { get; set; }   //Id
        public int CategoryId { get; set; }  //hangi kategoriye dahil ürün olduğunu
        public string ProductName { get; set; }  //ürün ismi
        public double UnitPrice { get; set; }    // ürünün birim fiyatı
        public int UnitInstack { get; set; }    //ürünün stok adedi


    }
}
