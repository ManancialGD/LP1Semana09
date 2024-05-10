namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PCClass { get; }
        public string Name { get; }

        public Player(PlayerClass pClass, string name)
        {
            PCClass = pClass;
            Name = name;
        }
    }

}