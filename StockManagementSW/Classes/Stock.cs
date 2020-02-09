using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSW.Classes;

namespace StockManagementSW.Classes
{
    public class Stock
    {
        private int id;
        private Storage storage;
        private Product product;
        private int quantity;

        public Storage Storage { get => storage; set => storage = value; }
        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Id { get => id; set => id = value; }

        public Stock(int id, Storage storage, Product product, int quantity)
        {
            Id = id;
            Storage = storage;
            Product = product;
            Quantity = quantity;
        }               
    }
}
