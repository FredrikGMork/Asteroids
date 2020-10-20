using System;
using System.Numerics;

namespace AsteroidsAPI.Models
{
    public class Asteroid
    {
        public int Id { get; set; }
        public Vector2 Position { get; set; }
        public float Speed { get; set; }
        public Vector2 Rotation { get; set; }

        public float Size { get; set; }
    }
}