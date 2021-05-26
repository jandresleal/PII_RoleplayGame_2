using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class WizardTests
    {
        private Wizard Gandalf;
        private Armor armor;
        private Sword sword;
        private Staff staff;

        [SetUp]
        public void Setup()
        {
            this.Gandalf = new Wizard("Gandalf");
            this.armor = new Armor();
            this.sword = new Sword();
            this.staff = new Staff();
        }

        [Test]
          public void TestAgregarItem()
        {
            Gandalf.AddItem(armor);
            Assert.IsNotEmpty(Gandalf.Items);
        }
        [Test]
          public void TestQuitarItem()
        {
            Gandalf.AddItem(armor);
            Gandalf.RemoveItem(armor);
            Assert.IsEmpty(Gandalf.Items);
        }
        [Test]
         public void TestAttackValue()
        {
            Gandalf.AddItem(sword);
            Assert.AreEqual(20, Gandalf.AttackValue);
        }
        [Test]
        public void TestAttackValueconmasdeunitem()
        {
            Gandalf.AddItem(sword);
            Gandalf.AddItem(staff);
            Assert.AreEqual(120, Gandalf.AttackValue);
        }
        [Test]
         public void TestDefenseValue()
        {
            Gandalf.AddItem(armor);
            Gandalf.AddItem(staff);
            Assert.AreEqual(125, Gandalf.DefenseValue);
        }
         [Test]
         public void TestHealth()
        {
            Assert.AreEqual(100, Gandalf.Health);
        }
        [Test]
         public void TestReceiveDamage()
        {
            Gandalf.ReceiveAttack(20);
            Assert.AreEqual(80, Gandalf.Health);
        }
        [Test]
         public void TestReceiveDamagemuygrande()
        {
            Gandalf.ReceiveAttack(200000);
            Assert.AreEqual(0, Gandalf.Health);
        }
        [Test]
         public void TestCure()
        {
            Gandalf.ReceiveAttack(200000);
            Gandalf.Cure();
            Assert.AreEqual(100, Gandalf.Health);
        }
    }
}
