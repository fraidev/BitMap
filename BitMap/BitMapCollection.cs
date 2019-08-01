using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitMap
{
    public class BitMapCollection
    {
        //TODO Index class
        private bool[] _indexes = new bool[1];
        private int Capacity => _indexes.Length;

        public BitMapCollection()
        {
            
        }

        public BitMapCollection(string b)
        {
            //TODO ONLY STRINGS WITH 0 AND 1
            throw new NotImplementedException();
        }
        
        public BitMapCollection(IEnumerable<bool> b)
        {
            _indexes = b.Reverse().ToArray();
        }

        public void Add(int value)
        {
            EnsureCapacity(value + 1);
            _indexes[value] = true;
        }

        private void EnsureCapacity(int newCapacity)
        {
            if (Capacity < newCapacity) Grow(newCapacity);
        }

        private void Grow(int newSize)
        {
            Array.Resize(ref _indexes, newSize);
        }

        public bool Contains(int value)
        {
            return value < Capacity && _indexes[value];
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var i in _indexes.ToList()) sb.Append(i ? "1" : "0");
            return ReverseString(sb.ToString());
        }

        public bool[] ToBoolArray()
        {
            return ToString().Select(c => c == '1').ToArray();
        }

        public string ToHex()
        {
            return BinaryStringToHexString(ToString());
        }
        
        //TODO Extensions
        private static string BinaryStringToHexString(string binary)
        {
            string strHex = Convert.ToInt32(binary,2).ToString("X");
            return strHex;
        }
        
        
        private static string ReverseString(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
        
    }
}