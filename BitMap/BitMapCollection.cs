using System;
using System.Linq;
using System.Text;

namespace BitMap
{
    public class BitMapCollection
    {
        private bool[] _indexes = new bool[2];
        private int Capacity => _indexes.Length;

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
        
        private string ReverseString(string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
        private static byte ConvertBoolArrayToByte(bool[] source)
        {
            byte result = 0;
            // This assumes the array never contains more than 8 elements!
            var index = 8 - source.Length;

            // Loop through the array
            foreach (var b in source)
            {
                // if the element is 'true' set the bit at that position
                if (b)
                    result |= (byte)(1 << (7 - index));

                index++;
            }

            return result;
        }
        private static bool[] ConvertByteToBoolArray(byte b)
        {
            // prepare the return result
            var result = new bool[8];

            // check each bit in the byte. if 1 set to true, if 0 set to false
            for (var i = 0; i < 8; i++)
                result[i] = (b & (1 << i)) != 0;

            // reverse the array
            Array.Reverse(result);

            return result;
        }

        public override string ToString()
        {
//            var sb = new StringBuilder();
//            foreach (var i in _indexes.ToList()) sb.Append(i ? "1" : "0");
//            return ReverseString(sb.ToString());

            return ConvertBoolArrayToByte(_indexes).ToString();
        }

        public byte ToBinary()
        {
            return ConvertBoolArrayToByte(_indexes);
        }
    }
}