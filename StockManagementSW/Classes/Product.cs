using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSW
{
    public class Product
    {
        private int id;
        private string name;
        private string category;
        private int purchasePrice;
        private int sellingPrice;
        private string description;
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public int PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public int SellingPrice { get => sellingPrice; set => sellingPrice = value; }
        public string Description { get => description; set => description = value; }
        
        public Product(int id, string name, string category, int purchasePrice, int sellingPrice, string description)
        {
            Id = id;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            Description = description;
        }
    }
}
