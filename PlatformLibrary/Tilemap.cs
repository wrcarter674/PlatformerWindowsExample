using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PlatformLibrary
{
    /// <summary>
    /// A class representing a tilemap created with the Tiled editor
    /// </summary>
    public class Tilemap
    {
        #region private fields

        // An array of all tiles in the tilemap
        public Tile[] Tiles;

        // An array of all tile layers in the tilemap
        public TilemapLayer[] Layers;

        // The width of the map, measured in tiles
        public uint MapWidth;

        // The height of the map, measured in tiles
        public uint MapHeight;

        // The width of the tiles in the map
        public uint TileWidth;

        // The height of the tiles in the map
        public uint TileHeight;

        #endregion

        #region initialization

        /// <summary>
        /// Constructs a new instance of a Tilemap
        /// </summary>
        /// <param name="mapWidth">The width of the map, in tiles</param>
        /// <param name="mapHeight">The height of the map, in tiles</param>
        /// <param name="tileWidth">The width of the tiles, in pixels</param>
        /// <param name="tileHeight">The heigh of the tiles, in pixels</param>
        /// <param name="layers">The layers of the map</param>
        /// <param name="tiles">The tiles of the map</param>
        public Tilemap(uint mapWidth, uint mapHeight, uint tileWidth, uint tileHeight, TilemapLayer[] layers, Tile[] tiles)
        {
            this.MapWidth = mapWidth;
            this.MapHeight = mapHeight;
            this.TileWidth = tileWidth;
            this.TileHeight = tileHeight;
            this.Layers = layers;
            this.Tiles = tiles;
        }

        #endregion

        #region Drawing

        /// <summary>
        /// Draws the specified layer of the tilemap
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to draw with</param>
        /// <param name="layerIndex">The index of the layer to use</param>
        public void DrawLayer(SpriteBatch spriteBatch, int layerIndex)
        {

            var layer = Layers[layerIndex];
            for (uint y = 0; y < MapHeight; y++)
            {
                for (uint x = 0; x < MapWidth; x++)
                {
                    uint dataIndex = y * MapWidth + x;
                    uint tileIndex = layer.Data[dataIndex];
                    if (tileIndex != 0 && tileIndex < Tiles.Length)
                    {
                        Vector2 position = new Vector2(x * TileWidth, y * TileHeight);
                        Tiles[tileIndex].Draw(spriteBatch, position, Color.White);
                    }
                }
            }
        }

        /// <summary>
        /// Draws the entire Tilemap
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to draw with</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var layer in Layers)
            {
                for (uint y = 0; y < MapHeight; y++)
                {
                    for (uint x = 0; x < MapWidth; x++)
                    {
                        uint dataIndex = y * MapWidth + x;
                        uint tileIndex = layer.Data[dataIndex];
                        if (tileIndex != 0 && tileIndex < Tiles.Length)
                        {
                            Tile tile = Tiles[tileIndex];
                            Vector2 position = new Vector2(x * TileWidth, y * TileHeight);
                            Tiles[tileIndex].Draw(spriteBatch, position, Color.White);
                        }
                    }
                }
            }
        }

        #endregion

    }
}