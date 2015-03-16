using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public class Tile
    {
        public Tileset Tileset;
        public int SourceX;
        public int SourceY;
        public int XPos;
        public int YPos;
        public bool IsSolid;

        public Tile(Tileset tileSet, int srcX, int srcY, bool solid);
        public Tile();

        public void Clear();
        public Tile Clone();
    }
}
