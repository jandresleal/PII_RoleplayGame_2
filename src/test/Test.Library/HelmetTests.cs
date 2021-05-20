using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class HelmetTests
    {
        private Helmet HelmOfHador;
        [SetUp]
        public void Setup()
        {
         Helmet HelmOfHador = new Helmet();
        }

        [Test]
        public void TestGetDefense()
        {
          Assert.AreEqual(18, HelmOfHador.DefenseValue);  
        }
    }
}