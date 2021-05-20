using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArmorTest
    {
        private Armor Chestplate;
        [SetUp]
        public void Setup()
        {
         Armor Chestplate = new Armor();
        }

        [Test]
        public void TestGetDefense()
        {
          Assert.AreEqual(25, Chestplate.DefenseValue);  
        }
    }
}