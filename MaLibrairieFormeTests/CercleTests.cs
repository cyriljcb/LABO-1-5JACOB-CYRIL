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
    public class CercleTests
    {
        [TestMethod()]
        public void TestConstructeur()
        {
            Cercle c = new Cercle();
            Cercle c1 = new Cercle(5);
            Assert.AreEqual(c.ray, 0);
            Assert.AreEqual(c1.ray, 5);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Cercle c1 = new Cercle(2);
            string s = c1.ToString();
            Assert.AreEqual(c1.ToString(), "(2)");
        }

        [TestMethod()]
        public void TestSetter()
        {
            Cercle c1 = new Cercle(-2);
            Assert.AreEqual(c1.ray, -2);
            c1.ray = 10;
            Assert.AreEqual(c1.ray, 10);
        }

        [TestMethod()]
        public void TestGetter()
        {
            Cercle c1 = new Cercle(-2);
            Assert.AreEqual(c1.ray, -2);
        }

        [TestMethod()]
        public void CoordonneeEstDansTest()
        {
            Cercle c1 = new Cercle(2);
            Coordonnees c = new Coordonnees(0,0);
            bool b = c1.CoordonneesEstDans(c);
            Assert.IsTrue(b);
        }

        
    }
}