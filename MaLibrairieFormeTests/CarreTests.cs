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
    public class CarreTests
    {
        [TestMethod()]
        public void TestConstructeur()
        {
            Carre c = new Carre();
            Carre c1 = new Carre(5, 5, 5);
            Assert.AreEqual(c.Longueur, 0);   
            Assert.AreEqual(c1.Longueur, 5);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Carre c1 = new Carre(-2 ,- 2, 2);
            string s = c1.ToString();
            Assert.AreEqual(c1.ToString(), "(-2,-2)");
        }

        [TestMethod()]
        public void TestSetter()
        {
            Carre c1 = new Carre(-2,-2,2);
            Assert.AreEqual(c1.Longueur, -2);
            c1.Longueur = 10;
            Assert.AreEqual(c1.Longueur, 10);
        }

        [TestMethod()]
        public void TestGetter()
        {
            Carre c1 = new Carre(2,-2,-2);
            Assert.AreEqual(c1.Longueur, -2);
        }
    }
}