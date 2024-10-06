using GameServer.Library.Models;

namespace GameServer.Library
{
    public interface IRotatable
    {
        public Vector Position { get; set; }
        public Vector Velocity { get; set; }
    }
}