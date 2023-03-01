using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MemoryGenericRepository<T> : IGenericRepository<T>
    {
        private Dictionary<int, T> _data = new();
        private int _index = 0;
        public void Add(T entity)
        {
            _data[++_index] = entity;
        }

        public T Find(int id)
        {
            return _data[id];
        }

        public List<T> GetAll()
        {
            return _data.Values.ToList();
        }
    }
}
