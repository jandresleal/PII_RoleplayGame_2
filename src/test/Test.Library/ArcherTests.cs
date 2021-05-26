using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTests
    {
        private Archer Legolas;
        private Helmet helmet;
        private Bow bow;

        [SetUp]
        public void Setup()
        {
            this.Legolas = new Archer("Legolas");
            this.helmet = new Helmet();
            this.bow = new Bow();
        }

        [Test]
          public void TestAgregarItem()
        {
            Legolas.AddItem(helmet);
            Assert.IsNotEmpty(Legolas.Items);
        }
        [Test]
          public void TestQuitarItem()
        {
            Legolas.AddItem(helmet);
            Legolas.RemoveItem(helmet);
            Assert.IsEmpty(Legolas.Items);
        }
        [Test]
         public void TestAttackValue()
        {
            Legolas.AddItem(bow);
            Assert.AreEqual(15, Legolas.AttackValue);
        }
        [Test]
        public void TestAttackValueconmasdeunitemigual()
        {
            Legolas.AddItem(bow);
            Legolas.AddItem(bow);
            Assert.AreEqual(30, Legolas.AttackValue);
        }
        [Test]
         public void TestDefenseValue()
        {
            Legolas.AddItem(helmet);
            Assert.AreEqual(18, Legolas.DefenseValue);
        }
         [Test]
         public void TestHealth()
        {
            Assert.AreEqual(100, Legolas.Health);
        }
        [Test]
         public void TestReceiveDamage()
        {
            Legolas.ReceiveAttack(20);
            Assert.AreEqual(80, Legolas.Health);
        }
        [Test]
         public void TestReceiveDamagemuygrande()
        {
            Legolas.ReceiveAttack(200000);
            Assert.AreEqual(0, Legolas.Health);
        }
        [Test]
         public void TestCure()
        {
            Legolas.ReceiveAttack(200000);
            Legolas.Cure();
            Assert.AreEqual(100, Legolas.Health);
        }
    }
}
