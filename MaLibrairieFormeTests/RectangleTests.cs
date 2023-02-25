using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaLibrairieForme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void TestConstructeur()
        {
            Rectangle c = new Rectangle();
            Rectangle c1 = new Rectangle(5,4);
            Assert.AreEqual(c.Lon, 0);
            Assert.AreEqual(c.larg, 0);
            Assert.AreEqual(c1.Lon, 5);
            Assert.AreEqual(c1.larg, 4);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Rectangle c1 = new Rectangle(2,5);
            Assert.AreEqual(c1.ToString(), "(2,5)");
        }
        [TestMethod()]
        public void TestSetter()
        {
            Rectangle c1 = new Rectangle(-2,5);
            Assert.AreEqual(c1.Lon, -2);
            Assert.AreEqual(c1.larg, 5);
            c1.Lon = 10;
            Assert.AreEqual(c1.Lon, 10);
        }

        [TestMethod()]
        public void TestGetter()
        {
            Rectangle c1 = new Rectangle(-2,5);
            Assert.AreEqual(c1.Lon, -2);
            Assert.AreEqual(c1.larg, 5);
        }

        [TestMethod()]
        public void CoordonneeEstDansTest()
        {
            Rectangle c1 = new Rectangle(2,5);
            Coordonnees c = new Coordonnees(1, 2);
            bool b = c1.CoordonneesEstDans(c);
            Assert.IsFalse(b);
        }

        [TestMethod()]
        public void TestSommet()
        {
            Rectangle c1 = new Rectangle(1,2);
            int som = c1.NbSommet;
            Assert.AreEqual(4, som);

        }

    }
}