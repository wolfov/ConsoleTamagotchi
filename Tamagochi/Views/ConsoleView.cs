using System;
using Tamagotchi.Models;

namespace Tamagotchi.Views
{
    partial class ConsoleView : IView
    {
        public event Action<string> SetName;
        public event Action Feed;
        public event Action Play;
        public event Action Sleep;
        public event Action Heal;

        ICharacter character;

        public void CharacterChanged(ICharacter character)
        {
            this.character = character;
            Draw();
            if (character.IsSick)
                return;
            RedrawAndWait();
        }
        private void RedrawAndWait()
        {
            Draw();
            SwitchCommand(Console.ReadLine());
        }

        private void SwitchCommand(string line)
        {
            switch (line)
            {
                case "1":
                    Feed?.Invoke();
                    break;
                case "2":
                    Play?.Invoke();
                    break;
                case "3":
                    Sleep?.Invoke();
                    break;
                case "4":
                    Heal?.Invoke();
                    break;
                default:
                    Console.WriteLine("Unknow command");
                    RedrawAndWait();
                    break;
            }
        }

        public void GetName()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Set name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    continue;
                SetName?.Invoke(name);
                return;
            }
        }
    }
}
