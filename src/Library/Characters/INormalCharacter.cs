// Acorde a la Interface ICharacter, creamos un subtipo INormalCharacter
// La diferencia es que puede tener una lista solo de INormalItems, de esta manera
// gracias a los tipos, podemos hacer que solo utilicen objetos normales sin tener que estar
// poniendo condicionantes para comprobar que esto sea correcto, ya que la propia lista verifica
// los tipos de las variables que se asignan a ella.
using System.Collections.Generic;
namespace RoleplayGame

{
    public interface INormalCharacter : ICharacter
    {
        List<INormalItem> Items { get; }
    }
}