using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<TKey, TValue>
    {
        TKey[] _array;
        TKey[] _tempArray;
        TValue[] _array2;
        TValue[] _tempArray2;
        public MyDictionary()
        {
            _array = new TKey[0];
            _array2 = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {

            _tempArray = _array;
            _tempArray2 = _array2;
            _array = new TKey[_tempArray.Length + 1];
            _array2 = new TValue[_tempArray2.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
                _array2[i] = _tempArray2[i];
            }
            _array[_array.Length - 1] = key;
            _array2[_array2.Length - 1] = value;
        }

        public object? this[TKey key]
        {
            get
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (Equals(_array[i], key))
                    {
                        return _array2[i];
                    }
                }
                return default(TValue);
            }
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }

}
