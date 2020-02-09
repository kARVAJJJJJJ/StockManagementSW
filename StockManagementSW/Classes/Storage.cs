using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSW.Classes
{
    public class Storage
    {
        private int id;
        private string name;
        private string address;
        private IList<Stock> stocks;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        internal IList<Stock> Stocks { get => stocks; set => stocks = value; }
        public int Id { get => id; set => id = value; }

        public Storage(int id, string name, string address, IList<Stock> stocks)
        {
            Id = id;
            Name = name;
            Address = address;
            Stocks = stocks;
        }
    }
}
