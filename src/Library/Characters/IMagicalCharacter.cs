// Decidimos crear una interface para implementar un tipo character 
// con los metodos comunes a todos los personajes.
using System.Collections.Generic;
namespace RoleplayGame

{
    public interface IMagicalCharacter : ICharacter
    {
        List<IItem> Items { get; }
    }
}