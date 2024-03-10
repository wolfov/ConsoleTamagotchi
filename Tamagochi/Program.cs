using Tamagotchi.Models;
using Tamagotchi.Views;
using Tamagotchi.Controllers;
using System;

namespace Tamagotchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IView view = new ConsoleView();
            Digimon digimon = new Digimon();
            Controller controller = new Controller(digimon, view);
            controller.LoadView();
            Console.ReadLine();
        }
    }
}
