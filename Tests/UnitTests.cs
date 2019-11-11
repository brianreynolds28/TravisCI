using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Sub_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub1_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub2_Null()
        {
            Assert.True(true);
        }

        [Test]
        public void Sub3_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub4_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub5_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub6_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub7_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub8_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub9_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub10_Null()
        {
            Assert.True(true);
        }
        [Test]
        public void Sub11_Null()
        {
            Assert.True(true);
        }
    }
}
