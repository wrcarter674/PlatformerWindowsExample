using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace PlatformLibrary
{
    /// <summary>
    /// A class representing a single tile from a tilesheet
    /// </summary>
    public struct Tile
    {
        #region Properties
        // The tile's source rectangle
        public Rectangle Source { get; set; }

        // The tile's texture
        public Texture2D Texture { get; set; }

        //The Tiles Collision box
        public Rectangle Collision { get; set; }

        //The Tile's properties dictionary
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets the tile's width
        /// </summary>
        public int Width => Source.Width;

        /// <summary>
        /// Gets teh tile's height
        /// </summary>
        public int Height => Source.Height;
        #endregion
        #region Initialization
        /// <summary>
        /// Constructs a new tile
        /// </summary>
        /// <param name="source"></param>
        /// <param name="texture"></param>
        public Tile(Rectangle source, Texture2D texture, Rectangle collision, Dictionary<string, string> properties)
        {
            Texture = texture;
            Source = source;
            Collision = collision;
            Properties = properties;
        }
        #endregion

        /// <summary>
        /// Draws the tile using the provided SpriteBatch 
        /// This method should should be called between 
        /// SpriteBatch.Begin() and SpriteBatch.End()
        /// </summary>
        /// <param name="SpriteBatch">The SpriteBatch</param>
        /// <param name="destinationRectangle">The rectangle to draw the tile into</param>
        /// <param name="color">The color</param>
        /// <param name="rotation">Rotation about the origin (in radians)</param>
        /// <param name="origin">A vector2 to the origin</param>
        /// <param name="effects">The SpriteEffects</param>
        /// <param name="layerDepth">The sorting layer of the tile</param>
        public void Draw(SpriteBatch SpriteBatch, Rectangle destinationRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
        {
            SpriteBatch.Draw(Texture, destinationRectangle, Source, color, rotation, origin, effects, layerDepth);
        }

        /// <summary>
        /// Draws the tile using the provided SpriteBatch 
        /// This method should should be called between 
        /// SpriteBatch.Begin() and SpriteBatch.End()
        /// </summary>
        /// <param name="SpriteBatch">The SpriteBatch</param>
        /// <param name="destinationRectangle">The rectangle to draw the tile into</param>
        /// <param name="color">The color</param>
        public void Draw(SpriteBatch SpriteBatch, Rectangle destinationRectangle, Color color)
        {
            SpriteBatch.Draw(Texture, destinationRectangle, Source, color);
        }

        /// <summary>
        /// Draws the tile using the provided SpriteBatch 
        /// This method should should be called between 
        /// SpriteBatch.Begin() and SpriteBatch.End()
        /// </summary>
        /// <param name="SpriteBatch">The SpriteBatch</param>
        /// <param name="position">A Vector2 for position</param>
        /// <param name="color">The color</param>
        public void Draw(SpriteBatch SpriteBatch, Vector2 position, Color color)
        {
            SpriteBatch.Draw(Texture, position, Source, color);
        }

        /// <summary>
        /// Draws the tile using the provided SpriteBatch 
        /// This method should should be called between 
        /// SpriteBatch.Begin() and SpriteBatch.End()
        /// </summary>
        /// <param name="SpriteBatch">The SpriteBatch</param>
        /// <param name="position">A Vector2 for position</param>
        /// <param name="color">The color</param>
        /// <param name="rotation">Rotation about the origin (in radians)</param>
        /// <param name="origin">A vector2 to the origin</param>
        /// <param name="scale">The scale of the tile centered on the origin</param>
        /// <param name="effects">The SpriteEffects</param>
        /// <param name="layerDepth">The sorting layer of the tile</param>
        public void Draw(SpriteBatch SpriteBatch, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
        {
            SpriteBatch.Draw(Texture, position, Source, color, rotation, origin, scale, effects, layerDepth);
        }
    }
}