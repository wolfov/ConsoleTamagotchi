using System;

namespace Tamagotchi.Models
{
    public class Digimon : ICharacter
    {
        public Digimon()
        {
            _health = 10;
            _hunger = 0;
            _tired = 0;
            _happy = 10;
            _isSick = false;
        }
        private string _name;
        private int _health;
        private int _hunger;
        private int _tired;
        private int _happy;
        private bool _isSick;
        public string Name => _name;
        public int Health => _health; 
        public int Hunger => _hunger; 
        public int Tired => _tired;
        public bool IsSick => _isSick;
        public int Happy => _happy;

        public event Action<ICharacter> CharacterChanged;
        public void SetName(string name) 
        {
            _name = name;
            CharacterChanged?.Invoke(this);
        }
        public void Feed()
        {
            ChangeHunger(-1);
            CharacterChanged?.Invoke(this);
        }

        public void Play()
        {
            ChangeTired(1);
            ChangeHappy(1);
            CharacterChanged?.Invoke(this);
        }

        public void Sleep()
        {
            ChangeTired(-10);
            ChangeHunger(1);
            ChangeHealth(1);
            CharacterChanged?.Invoke(this);

        }
        public void Heal()
        {
            ChangeHealth(1);
            ChangeHappy(-1);
            CharacterChanged?.Invoke(this);
        }
        private void ChangeHealth(int value)
        {
            if (_happy == 0 && value < 0)
                value -= 1;
            if (_health + value <= 0)
            {
                _health = 0;
                _isSick = true;
            }
            else if (Health + value >= 10)
                _health = 10;
            else _health += value;
        }
        private void ChangeHunger(int value)
        {
            if (_hunger + value < 0)
            {
                _hunger = 0;
                ChangeHealth(-1);
            }
            else if (_hunger + value > 10)
                _hunger = 10;
            else _hunger += value;
        }
        private void ChangeTired(int value)
        {
            if (_tired + value < 0)
                _tired = 0;
            else if (_tired + value > 10)
            {
                _tired = 10;
                ChangeHealth(-1);
                ChangeHunger(1);
            }
            else _tired += value;
        }
        private void ChangeHappy(int value)
        {
            if (_happy + value < 0)
                _happy = 0;
            else if (_happy + value > 10)
                _happy = 10;
            else _happy += value;
        }
    }
}
