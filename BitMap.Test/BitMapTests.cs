using BitMap;
using NUnit.Framework;

namespace Test
{
    public class BitMapTests
    {
        private BitMapCollection _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new BitMapCollection();
        }

        [Test]
        public void Contains()
        {
            _sut.Add(1);
            _sut.Add(2);
            _sut.Add(4);
            _sut.Add(255);
            
            Assert.AreEqual(true, _sut.Contains(1));
            Assert.AreEqual(true, _sut.Contains(2));
            Assert.AreEqual(false, _sut.Contains(3));
            Assert.AreEqual(true, _sut.Contains(4));
            Assert.AreEqual(true, _sut.Contains(255));
            Assert.AreEqual(false, _sut.Contains(256));
        }

        [Test]
        public void ToStringMustReturnStringWithBinaryCode()
        {
            _sut.Add(1);
            _sut.Add(3);
            _sut.Add(5);
            
            Assert.AreEqual("21", _sut.ToString());
        }
        

        [Test]
        public void ToBinaryMustReturnBinaryCode()
        {
            _sut.Add(1);
            _sut.Add(3);
            _sut.Add(5);
            
            Assert.AreEqual(21, _sut.ToBinary());
        }
        
        
    }
}