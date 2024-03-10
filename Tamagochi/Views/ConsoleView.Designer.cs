using System;
using Tamagochi.Helpers;

namespace Tamagotchi.Views
{
    partial class ConsoleView
    {
        private void Draw()
        {
            Console.Clear();
            string HealthBar = new string('#', character.Health) + new string('_', 10 - character.Health);
            string HungerBar = new string('#', character.Hunger) + new string('_', 10 - character.Hunger);
            string TiredBar = new string('#', character.Tired) + new string('_', 10 - character.Tired);
            string HappyBar = new string('#', character.Happy) + new string('_', 10 - character.Happy);
            string Move = character.IsSick ? character.Name + " is sick. Game over" : "Command number:";
            Console.Write(string.Format(UI, StringHelper.Centered(character.Name, 27), HealthBar, HungerBar, TiredBar, HappyBar, Move));
        }
        private string UI = @"===========================
{0, -27}
===========================

HEALTH: {1}
HUNGER: {2}
TIRED:  {3}
HAPPY:  {4}

===========================
Commands:
1. Feed
2. Play
3. Sleep
4. Heal
===========================
{5} ";

    }
}
