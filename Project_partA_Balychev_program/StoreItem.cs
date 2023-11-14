using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Balychev_program
{
    public class StoreItem
    {
        private double _price;
        private int _quantityInStock;
        private Items _item;

        public StoreItem(): this(-1,-1,Items.None) { }

        public StoreItem(double price, int quantityInStock, Items item)
        {
            throw new NotImplementedException();
        }

        public double Price
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int QuantityInStock
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Items Item
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool InStock()
        {
            throw new NotImplementedException();
        }


    }
}
