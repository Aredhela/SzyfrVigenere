using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfrator
{
    public class RingKey
    {
        readonly byte[] _keyData;
        int _index;

        public RingKey(string key)
        {
            _keyData = Encoding.ASCII.GetBytes(key.ToUpperInvariant());
            for (var i = 0; i < _keyData.Length; i++)
            {
                _keyData[i] -= 'A' - 1;
            }
        }

        public byte Current
        {
            get { return _keyData[_index]; }
        }

        public void MoveNext()
        {
            if (_index >= _keyData.Length - 1)
            {
                _index = 0;
            }
            else
            {
                _index++;
            }
        }
    }
}
