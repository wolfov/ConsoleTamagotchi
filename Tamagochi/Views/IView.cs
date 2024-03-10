using System;
using Tamagotchi.Models;

namespace Tamagotchi.Views
{
    public interface IView
    {
        event Action<string> SetName;
        event Action Feed;
        event Action Play;
        event Action Sleep;
        event Action Heal;
        
        void CharacterChanged(ICharacter character);
        void GetName();
    }
}
