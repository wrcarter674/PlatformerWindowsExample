using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace PlatformerContentExtension
{
    /// <summary>
    /// A class representing the details of a single 
    /// tile in a TiledSpriteSheet
    /// </summary>
    public class TileContent
    {
        /// <summary>
        /// The Tile's source rectangle
        /// </summary>
        public Rectangle Source { get; set; }
        public Rectangle Collision { get; set; } = Rectangle.Empty;
        /// <summary>
        /// Creates a new TileContent with the specified source rectangle
        /// </summary>
        /// <param name="source">The source rectangle of the tile in its spritesheet</param>
        public Dictionary<string, string> Properties { get; set; }
        public TileContent()
        {
            Properties = new Dictionary<string, string>();
        }

        //  public Rectangle Collision = Rectangle.Empty; 
    }
}
