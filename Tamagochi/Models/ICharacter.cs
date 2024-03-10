namespace Tamagotchi.Models
{
    public interface ICharacter
    {
        string Name { get; }
        bool IsSick { get; }
        int Health { get; }
        int Hunger { get; }
        int Tired { get; }
        int Happy { get; }
    }
}
