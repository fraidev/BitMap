using System;

namespace BitMap
{
    public class BitMap
    {
        private bool[] _indexes = new bool[2];
        private int Capacity => _indexes.Length;

        public void Add(int value) {
            EnsureCapacity(value + 1);
            _indexes[value] = true;
        }

        private void EnsureCapacity(int newCapacity) {
            if (Capacity < newCapacity) {
                Grow(newCapacity);
            }
        }

        private void Grow(int newSize) {
            Array.Resize(ref _indexes, newSize);
        }

        public bool Contains(int value) {
            return value < Capacity && _indexes[value];
        }
    }
}