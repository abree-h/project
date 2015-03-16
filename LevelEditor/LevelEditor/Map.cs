using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public class Map
    {
      public delegate Image RequestTexture(string Name);

      public Map()

      public List<maplayer> MapLayers
      public int RealWidth
      public int RealHeight
      public int Width
      public int Height
      public virtual int TileSize
      public List<tileset> TileSets

      public void Load(string Path, RequestTexture requestTexture)
      public virtual void Load(Stream dataStream, RequestTexture requestTexture)
    }
}
