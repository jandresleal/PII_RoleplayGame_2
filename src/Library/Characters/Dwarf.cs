using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf : INormalCharacter
    {
        private int health = 100;

        public Dwarf(string name)
        {
            this.Name = name;
            this.Items = new List<INormalItem>{};
        }

        public string Name { get; private set; }

        public List<INormalItem> Items { get; private set;}
        public void AddItem(INormalItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(INormalItem item)
        {
            Items.Remove(item);
        }
        
        public int AttackValue
        {
            get
            {
                int attack = 0;
                foreach (INormalItem item in Items)
                {
                    if (typeof(IAttackItem).IsInstanceOfType(item))
                    {
                        attack += ((IAttackItem)item).AttackValue;
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
                foreach (INormalItem item in Items)
                {
                    if (typeof(IDefenseItem).IsInstanceOfType(item))
                    {
                        defense += ((IDefenseItem)item).DefenseValue;
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