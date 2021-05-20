namespace RoleplayGame
{
    public class Armor : IDefenseItem, IItem
    {
        public int DefenseValue
        {
            get
            {
                return 25;
            }
        }
    }
}