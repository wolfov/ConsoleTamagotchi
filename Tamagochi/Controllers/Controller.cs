using Tamagotchi.Models;
using Tamagotchi.Views;

namespace Tamagotchi.Controllers
{
    public class Controller
    {
        private Digimon _digimon;
        private IView _view;

        public Controller(Digimon digimon, IView view)
        {
            _digimon = digimon;
            _view = view;
            _view.Feed += Feed;
            _view.Play += Play;
            _view.Sleep += Sleep;
            _view.Heal += Heal;
            _view.SetName += SetName;
            _digimon.CharacterChanged += _view.CharacterChanged;
        }

        

        private void SetName(string name)
        {
            _digimon.SetName(name);
        }
        private void Feed()
        {
            _digimon.Feed();
        }
        private void Play()
        {
            _digimon.Play();
        }
        private void Sleep()
        {
            _digimon.Sleep();
        }
        private void Heal()
        {
            _digimon.Heal();
        }
        public void LoadView()
        {
            _view.GetName();
        }
    }
}
