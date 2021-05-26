//Haciendo uso de tipos, Wizard es el unico Character que puede utilizar todos los objetos del tipo Iitem
//Esto se debe a que es el único que tiene la capacidad de utilizar items normales y mágicos
//por eso lo definimos como un subtipo de ICharacter que es IMagicalCharacter
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : IMagicalCharacter
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
            this.Items = new List<IItem>{};
        }

        public string Name { get; private set; }
        public List<IItem> Items { get; private set;}
        public void AddItem(IItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            Items.Remove(item);
        }
        
        public int AttackValue
        {
            get
            {
                int attack = 0;
                foreach (IItem item in Items)
                {
                    if (typeof(IAttackItem).IsInstanceOfType(item))
                    {
                        attack += ((IAttackItem)item).AttackValue;
                    }
                    if (typeof(IMagicalAttackItem).IsInstanceOfType(item))
                    {
                        attack += ((IMagicalAttackItem)item).AttackValue;
                    }
                }
                return attack;
            }
        }

        public int DefenseValue
        {
            get
            {
                int defense = 0;
                foreach (IItem item in Items)
                {
                    if (typeof(IDefenseItem).IsInstanceOfType(item))
                    {
                        defense += ((IDefenseItem)item).DefenseValue;
                    }
                    if (typeof(IMagicalDefenseItem).IsInstanceOfType(item))
                    {
                        defense += ((IMagicalDefenseItem)item).DefenseValue;
                    }
                }
                return defense;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}