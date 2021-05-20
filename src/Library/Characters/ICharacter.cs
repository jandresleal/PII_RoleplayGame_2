// Decidimos crear una interface para implementar un tipo character 
// con los metodos comunes a todos los personajes.

namespace RoleplayGame

{
    public interface ICharacter
    {

        int Health { get; }

        string Name { get; set; }

        int AttackValue { get; }

        int DefenseValue { get; }

        void ReceiveAttack(int power);

        void Cure();
    }
}