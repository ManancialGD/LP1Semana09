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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Player otherPlayer = (Player)obj;
            return PCClass == otherPlayer.PCClass && Name == otherPlayer.Name;
        }
    }

}