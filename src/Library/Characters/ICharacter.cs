// Decidimos crear una interface para implementar un tipo character 
// con los metodos comunes a todos los personajes.
using System.Collections.Generic;
namespace RoleplayGame

{
    public interface ICharacter
    {

        int Health { get; }

        string Name { get; }

        int AttackValue { get; }

        int DefenseValue { get; }

        void ReceiveAttack(int power);

        void Cure();
    }
}