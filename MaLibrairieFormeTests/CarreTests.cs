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
            Carre c1 = new Carre(5);
            Assert.AreEqual(c.Longueur, 0);   
            Assert.AreEqual(c1.Longueur, 5);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Carre c1 = new Carre(-2);
            string s = c1.ToString();
            Assert.AreEqual(c1.ToString(), "(-2,-2)");
        }

        [TestMethod()]
        public void TestSetter()
        {
            Carre c1 = new Carre(-2);
            Assert.AreEqual(c1.Longueur, -2);
            c1.Longueur = 10;
            Assert.AreEqual(c1.Longueur, 10);
        }

        [TestMethod()]
        public void TestGetter()
        {
            Carre c1 = new Carre(-2);
            Assert.AreEqual(c1.Longueur, -2);
        }
        [TestMethod()]
        public void TestCoordonneEstDans()
        {
            Carre c1 = new Carre(2);
            Coordonnees c = new Coordonnees(1, 2);
            bool b = c1.CoordonneesEstDans(c);
            Assert.IsTrue(b);
         
        }

        [TestMethod()]
        public void TestSommet()
        {
            Carre c1 = new Carre(1);
            int som = c1.NbSommet;
            Assert.AreEqual(4, som);

        }
    }
}