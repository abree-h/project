using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public class MapLayer : IComparable<maplayer>
    {
      public string Name
      public int ID
      public bool IsBackground
      public float Z_Value
      public bool Visible
      public Tile[,] Tiles

      public MapLayer(string Name, int ID, float ZValue, bool Background)

      public void Resize(int width, int height)
      public bool TileIsAlive(int X, int Y)
    }
}
