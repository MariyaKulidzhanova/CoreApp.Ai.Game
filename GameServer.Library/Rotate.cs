namespace GameServer.Library
{
    public class Rotate
    {
        private readonly IRotatable Rotatable;

        public Rotate(IRotatable r)
        {
            Rotatable = r;
        }

        public void Execute()
        {
            Rotatable.Position = new Vector(Rotatable.Position, Rotatable.Velocity);
        }
    }
}