using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_partA_Balychev_program
{
    public class StoreInventory : IEnumerable<StoreItem>, ICollection
    {
        private List<StoreItem> items;

        public StoreInventory()
        {
           throw new NotImplementedException();
        }

        public int Count => throw new NotImplementedException();
        
        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void Add(StoreItem item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(StoreItem item)
        {
            throw new NotImplementedException();
        }

        public void SortByPrice()
        { 
            throw new NotImplementedException(); 
        }
        
       

        public IEnumerator<StoreItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(StoreItem item)
        {
            throw new NotImplementedException();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
