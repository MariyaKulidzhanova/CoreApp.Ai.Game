using GameServer.Library.Models;

namespace GameServer.Library.Interfaces.Implementation
{
    public class Move
    {
        private readonly IMovable Movable;

        public Move(IMovable m)
        {
            Movable = m;
        }

        public void Execute()
        {
            Movable.Position = new Vector(Movable.Position, Movable.Velocity);
        }
    }
}