using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IMagicalAttackItem, IMagicalDefenseItem
    {
        public List<ISpell> Spells { get; private set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (ISpell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
        public void AddSpell (ISpell spell)
        {
            Spells.Add(spell);
        }
    }
}