using AzerbaijanStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzerbaijanStore.DAL
{
    public class EntitiyModel<T>where T:Entity,new()
    {
        private List<T> _Entities;
        public EntitiyModel()
        {
            if (_Entities == null)
                _Entities = new List<T>();

        }
        public void Add(T item)
        {
            _Entities.Add(item);
        }
        public void Remove(T item)
        {
            _Entities.Remove(item);
        }
        public List<T> GetAll()
        {
            return _Entities;
        }
    
    }
}
