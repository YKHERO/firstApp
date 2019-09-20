using firstApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace firstAppTests
{
    [TestClass]
    public class MathTest
    {


        [TestMethod]
        public void Factorielle_AvecValeur0_Retourne1()
        {
            MathHelper M = new MathHelper();
            double resultat = MathHelper.Factorielle(0);
            Assert.AreEqual(1, resultat);
        }

        [TestMethod]
        public void Factorielle_AvecValeur3_Retourne6()
        {
            double resultat = MathHelper.Factorielle(3);
            Assert.AreEqual(6, resultat);
        }

        [TestMethod]
        public void Factorielle_AvecValeur15_Retourne1307674368000()
        {
            double resultat = MathHelper.Factorielle(15);
            Assert.AreEqual(6, resultat);
        }
    }
}
