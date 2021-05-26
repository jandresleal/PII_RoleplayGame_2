using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTests
    {
        private Dwarf Gimli;
        private Helmet helmet;
        private Axe axe;

        [SetUp]
        public void Setup()
        {
            this.Gimli = new Dwarf("Gimli");
            this.helmet = new Helmet();
            this.axe = new Axe();
        }

        [Test]
          public void TestAgregarItem()
        {
            Gimli.AddItem(helmet);
            Assert.IsNotEmpty(Gimli.Items);
        }
        [Test]
          public void TestQuitarItem()
        {
            Gimli.AddItem(helmet);
            Gimli.RemoveItem(helmet);
            Assert.IsEmpty(Gimli.Items);
        }
        [Test]
         public void TestAttackValue()
        {
            Gimli.AddItem(axe);
            Assert.AreEqual(25, Gimli.AttackValue);
        }
        [Test]
        public void TestAttackValueconmasdeunitemigual()
        {
            Gimli.AddItem(axe);
            Gimli.AddItem(axe);
            Assert.AreEqual(50, Gimli.AttackValue);
        }
        [Test]
         public void TestDefenseValue()
        {
            Gimli.AddItem(helmet);
            Assert.AreEqual(18, Gimli.DefenseValue);
        }
         [Test]
         public void TestHealth()
        {
            Assert.AreEqual(100, Gimli.Health);
        }
        [Test]
         public void TestReceiveDamage()
        {
            Gimli.ReceiveAttack(20);
            Assert.AreEqual(80, Gimli.Health);
        }
        [Test]
         public void TestReceiveDamagemuygrande()
        {
            Gimli.ReceiveAttack(200000);
            Assert.AreEqual(0, Gimli.Health);
        }
        [Test]
         public void TestCure()
        {
            Gimli.ReceiveAttack(200000);
            Gimli.Cure();
            Assert.AreEqual(100, Gimli.Health);
        }
    }
}
