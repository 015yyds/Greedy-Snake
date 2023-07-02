using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class Wall : GameObject
    {
        public Wall(int x,int y)
        {
            pos.x = x;
            pos.y = y;
        }
        public override void Draw()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.SetCursorPosition(pos.x,pos.y);
            Console.Write("#");
        }
    }
}
