using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Skat.tests
{
    [TestClass]
    public class BilAfgiftTests
    {
        [TestMethod]
        public void TestAfBilAFgiftUnder200000()
        {
            int pris = 150000;
            //Arrange
            Bil bil = new Bil();

            //Act
            bil.BilAfgift(pris);

            //Assert
            Assert.AreEqual(127500, bil.BilAfgift(pris));
        }

        [TestMethod]
        public void TestAfBilAFgiftOver200000()
        {
            int pris = 250000;
            //Arrange
            Bil bil = new Bil();

            //Act
            bil.BilAfgift(pris);

            //Assert
            Assert.AreEqual(245000, bil.BilAfgift(pris));
        }
        [TestMethod]
        public void TestAfBilAFgiftVed0()
        {
            int pris = 0;
            //Arrange
            Bil bil = new Bil();

            //Act
            bil.BilAfgift(pris);

            //Assert
            Assert.AreEqual(0, bil.BilAfgift(pris));
        }

        [TestMethod]
        public void TestAfElBilAFgiftUnder200000()
        {
            int pris = 150000;
            //Arrange
            Bil bil = new Bil();

            //Act
            bil.ElBilAfgift(pris);

            //Assert
            Assert.AreEqual(25500, bil.ElBilAfgift(pris));
        }

        [TestMethod]
        public void TestAfElBilAFgiftOver200000()
        {
            int pris = 250000;
            //Arrange
            Bil bil = new Bil();

            //Act
            bil.ElBilAfgift(pris);

            //Assert
            Assert.AreEqual(49000, bil.ElBilAfgift(pris));
        }

        [TestMethod]
        public void TestAfElBilAFgiftVed0()
        {
            int pris = 0;
            //Arrange
            Bil bil = new Bil();

            //Act
            bil.ElBilAfgift(pris);

            //Assert
            Assert.AreEqual(0, bil.ElBilAfgift(pris));
        }
    }
}
