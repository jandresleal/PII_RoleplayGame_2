// Decidimos crear una interface para implementar un tipo character 
// con los metodos comunes a todos los personajes.
using System.Collections.Generic;
namespace RoleplayGame

{
    public interface INormalCharacter : ICharacter
    {
        List<INormalItem> Items { get; }
    }
}