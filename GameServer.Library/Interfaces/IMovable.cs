using GameServer.Library.Models;

namespace GameServer.Library.Interfaces
{
    public interface IMovable
    {
        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
    }
}