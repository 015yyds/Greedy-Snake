using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class SnakeBody:GameObject
    {
        E_SnakeType nowType;

        public SnakeBody(int x,int y, E_SnakeType type) 
        {
            pos.x = x;
            pos.y = y;
            nowType = type;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = nowType == E_SnakeType.snake ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write(nowType == E_SnakeType.snake ? "@" : "*");
        }
    }
    enum E_SnakeType
    {
        snake,
        Body
    }
}
