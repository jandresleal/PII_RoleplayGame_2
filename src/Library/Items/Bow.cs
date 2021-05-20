namespace RoleplayGame
{
    public class Bow : IAttackItem, IItem
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            } 
        }
    }
}