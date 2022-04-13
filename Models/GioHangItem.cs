using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apple_Clone_Website.Models
{
    public class GioHangItem
    {
        AppleStoreEntities db = new AppleStoreEntities();
        public string ProductID { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string CategoryID { get; set; }
        public string SupplierID { get; set; }
        public string Image { get; set; }
        public int SoLuong { get; set; }
        public string ProductColorID { get; set; }
        
        public double dThanhTien { get { return UnitPrice * SoLuong; } }
        public GioHangItem(string ProductID)
        {
            this.ProductID = ProductID;
            Product product = db.Products.SingleOrDefault(n => n.ProductID == ProductID);
            this.Name = product.Name;
            this.UnitPrice = double.Parse(product.UnitPrice.ToString());
            this.Image = product.Image;
            this.SoLuong = 1;
        }
    }
}