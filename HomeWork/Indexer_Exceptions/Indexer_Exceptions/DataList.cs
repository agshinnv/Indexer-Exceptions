using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions
{
    public class Datalist <T> where T : Person
    {
        private T[] _datas;

        public Datalist()
        {
            _datas = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas,_datas.Length + 1);

            _datas[_datas.Length - 1] = item;
        }

        public T GetById(int id)
        {
            return _datas.FirstOrDefault(m => m.Id == id);
        }

        public T[] DeleteMethod(int id)
        {
            return _datas.Where(m => m.Id != id).ToArray();
        }
    }

    
}
