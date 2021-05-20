namespace RoleplayGame
{
    public class Staff : IAttackItem, IDefenseItem, IItem, IMagicalItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}