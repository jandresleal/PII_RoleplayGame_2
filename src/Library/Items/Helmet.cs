namespace RoleplayGame
{
    public class Helmet : IDefenseItem, IItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
            }
        }
    }
}