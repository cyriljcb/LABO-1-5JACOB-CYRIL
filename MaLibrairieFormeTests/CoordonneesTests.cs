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
    public class CoordonneesTests
    {
        [TestMethod()]
        public void TestConstructeur()
        {
            Coordonnees c = new Coordonnees(0, 0);
            Coordonnees c1 = new Coordonnees(1, -2);

            Assert.AreEqual(c.x,0);
            Assert.AreEqual(c.y,0);
            Assert.AreEqual(c1.x,1);
            Assert.AreEqual(c1.y,-2);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Coordonnees c1 = new Coordonnees(1, -2);
            string s = c1.ToString();
            Assert.AreEqual(c1.ToString(),"(1,-2)");
        }

        [TestMethod()]
        public void TestSetter()
        {
            Coordonnees c1 = new Coordonnees(1, -2);
            Assert.AreEqual(c1.x,1);
            Assert.AreEqual(c1.y, -2);
            c1._x = 10;
            c1._y = -10;
            Assert.AreEqual(c1.x, 10);
            Assert.AreEqual(c1.y, -10);
        }

        [TestMethod()]
        public void TestGetter()
        {
            Coordonnees c1 = new Coordonnees(1, -2);
            Assert.AreEqual(c1._x, 1);
            Assert.AreEqual(c1._y, -2);
        }
    }
}