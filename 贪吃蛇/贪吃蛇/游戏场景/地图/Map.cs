using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class Map : IDraw
    {
        public Wall[] walls;

        public Map() {

            walls = new Wall[80 + (20 - 3) * 2];

            int index = 0;
            //上下
            for (int i= 0; i < 80; i += 2)
            {
                walls[index++] = new Wall(i, 0);
                walls[index++] = new Wall(i, 20-2);
            }

            //左右
            for (int i = 1; i < 20-2; i++)
            {
                
                walls[index++] = new Wall(0,i);
                walls[index++] = new Wall(80-2,i);
            }
        }

        public void Draw()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                if (walls[i] == null) continue;
                walls[i].Draw();
            }
        }
    }
}
