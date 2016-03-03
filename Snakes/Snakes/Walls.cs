using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Walls
    {
        List<Figure> WallList;

        public Walls(int mapWidth, int mapHeight)
        {
            WallList = new List<Figure>();

            HorizontalLine Upline = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VertikalLine Leftline = new VertikalLine(0, mapHeight- 1, 0, '+');
            VertikalLine Rightline = new VertikalLine(0, mapHeight -1, mapWidth - 2, '+');

            WallList.Add(Upline);
            WallList.Add(Downline);
            WallList.Add(Leftline);
            WallList.Add(Rightline);            
        }

       internal bool IsHit(Figure figure)
        {
            foreach(var wall in WallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }                
            }
            return false;
        }

        public void Draw()
        {
            foreach( var wall in WallList)
            {
                wall.Draw();
            }
        }
    }
}
