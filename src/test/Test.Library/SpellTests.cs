using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class SpellTests
    {
        private Spell Fireball;
        [SetUp]
        public void Setup()
        {
         Spell Fireball = new Spell();
        }

        [Test]
        public void TestGetAttack()
        {
          Assert.AreEqual(70, Fireball.AttackValue);  
        }
        
        [Test]
        public void TestGetDefense()
        {
            Assert.AreEqual(70, Fireball.DefenseValue);
        }
    }
}