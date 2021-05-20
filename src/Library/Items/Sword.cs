namespace RoleplayGame
{
    public class Sword : IAttackItem, IItem
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }
    }
}