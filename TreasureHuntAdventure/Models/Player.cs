namespace TreasureHuntAdventure.Models
{
    public class Player
    {
        public string Name { get; set; }

        public int Health { get; set; } = 100;
        public int Gold { get; set; } = 0;
        public int PositionX { get; set; } = 1;
        public int PositionY { get; set; } = 1;

        public Player(string name)
        {
            Name = name;
        }
    }
}
