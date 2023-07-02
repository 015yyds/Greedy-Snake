using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class Snake:IDraw
    {
        SnakeBody[] bodies;
        
        int nowIndex;

        E_Dirction nowDir;

        public Snake(int x,int y)
        {
            bodies = new SnakeBody[200];
            bodies[0]=new SnakeBody(x,y,E_SnakeType.snake);
            nowIndex = 1;
        }

        public void Draw()
        {
            for (int i = 0; i < nowIndex; i++) 
            {
                bodies[i].Draw();
            }
        }

        public void Move() 
        {
            SnakeBody last = bodies[nowIndex-1];
            Console.SetCursorPosition(last.pos.x, last.pos.y);
            Console.Write("  ");

            //吃食物时，身体逻辑
            for(int i=nowIndex-1; i > 0; i--) 
            {
                bodies[i].pos = bodies[i-1].pos;
            }

            //按键移动逻辑
            switch (nowDir)
            {
                case E_Dirction.up:
                    bodies[0].pos.y--;
                    break;
                case E_Dirction.Down:
                    bodies[0].pos.y++;
                    break;
                case E_Dirction.Left:
                    bodies[0].pos.x-=2;
                    break;
                case E_Dirction.Right:
                    bodies[0].pos.x+=2;
                    break;
            }
        }

        public void ChangeDir(E_Dirction dir)
        {
            if(nowIndex > 1 && 
                (nowDir==E_Dirction.Left&&dir== E_Dirction.Right) ||
                 (nowDir == E_Dirction.Right && dir == E_Dirction.Left) ||
                  (nowDir == E_Dirction.Down && dir == E_Dirction.up) ||
                   (nowDir == E_Dirction.up && dir == E_Dirction.Down))
            {
                return;
            }

            nowDir = dir;
        }

        public bool CheckSamePos(Position pos)
        {
            for(int i=0; i < nowIndex; i++)
            {
                if (bodies[i].pos == pos)
                    return true;
            }
            return false;
        }

        public void ChekEat(Food food)
        {
            if (bodies[0].pos == food.pos)
            {
                food.RandomPos(this);
                bodies[nowIndex++] = new SnakeBody(0, 0, E_SnakeType.Body);
            }
        }

        //结束条件
        public bool ChekEnd(Map map)
        {
            for(int i = 1; i < nowIndex; i++)
            {
                if (bodies[0].pos == bodies[i].pos)
                    return true;
            }

            for(int i = 0; i < 98; i++)
            {
                if (bodies[0].pos == map.walls[i].pos)
                    return true;
            }
            return false;
        }

    }
    enum E_Dirction
    {
        up,
        Down,
        Left,
        Right,
    }
}
