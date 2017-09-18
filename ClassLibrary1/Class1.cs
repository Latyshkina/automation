using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AddTestPl()
        {
            int result = Claculator.AddPl(4, 9);
            Assert.AreEqual(13, result);
        }

        [Test]
        public void AddTestPl2()
        {
            int result = Claculator.AddPl(9, 9);
            Assert.AreEqual(13, result);
        }
        [Test]
        public void AddTestPl3()
        {
            int result = Claculator.AddPl(1, 9);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void AddTestPl4()
        {
            int result = Claculator.AddPl(4, 4);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void AddTestPl5()
        {
            int result = Claculator.AddPl(0, 9);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void AddTestMin()
        {
            int result = Claculator.AddMin(9, 4);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddTestMin2()
        {
            int result = Claculator.AddMin(9, 9);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void AddTestMin3()
        {
            int result = Claculator.AddMin(9, 1);
            Assert.AreEqual(7, result);
        }
        [Test]
        public void AddTestMin4()
        {
            int result = Claculator.AddMin(9, 18);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddTestMin5()
        {
            int result = Claculator.AddMin(9, 5);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void AddTestDel()
        {
            int result = Claculator.AddDel(10, 5);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void AddTestDel2()
        {
            int result = Claculator.AddDel(10, 2);
            Assert.AreEqual(5, result);
        }
        [Test]
        public void AddTestDel3()
        {
            int result = Claculator.AddDel(10, 10);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void AddTestDel4()
        {
            int result = Claculator.AddDel(1, 1);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void AddTestDel5()
        {
            int result = Claculator.AddDel(4, 2);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void AddTestYmn()
        {
            int result = Claculator.AddYmn(4, 2);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void AddTestYmn2()
        {
            int result = Claculator.AddYmn(2, 2);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void AddTestYmn3()
        {
            int result = Claculator.AddYmn(4, 4);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void AddTestYmn4()
        {
            int result = Claculator.AddYmn(4, 1);
            Assert.AreEqual(4, result);
        }
        [Test]
        public void AddTestYmn5()
        {
            int result = Claculator.AddYmn(2, 2);
            Assert.AreEqual(4, result);
        }


    }
}
