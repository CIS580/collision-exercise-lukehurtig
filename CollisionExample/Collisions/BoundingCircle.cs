using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace CollisionExample.Collisions
{
    public struct BoundingCircle
    {
        /// <summary>
        /// The center of the bounding circle
        /// </summary>
        public Vector2 Center;

        /// <summary>
        /// the radius of the bounding circle
        /// </summary>
        public float Radius;

        /// <summary>
        /// Constructs new Bounding circle
        /// </summary>
        /// <param name="center"></param>
        /// <param name="radius"></param>
        public BoundingCircle(Vector2 center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// Tests for a collision between this and another bounding circle
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool CollidesWith(BoundingCircle other)
        {
            return CollisionHelper.Collides(this, other);
        }

        public bool CollidesWith(BoundingRectangle other)
        {
            return CollisionHelper.Collides(this, other);
        }
    }
}
