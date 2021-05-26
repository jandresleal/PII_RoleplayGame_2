// Acorde a la Interface ICharacter, creamos un subtipo IMagicalCharacter
// La diferencia es que, este subtipo puede tener una lista de IItems, de esta manera
// incluímos la posibilidad de que use INormalItems e IMagicalItems indistintamente.
using System.Collections.Generic;
namespace RoleplayGame

{
    public interface IMagicalCharacter : ICharacter
    {
        List<IItem> Items { get; }
    }
}