using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class GameScene:ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;

        public GameScene()
        {
            map = new Map();
            snake = new Snake(40, 10);
            food = new Food(snake);
        }
        public void Update()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_Dirction.up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_Dirction.Down);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_Dirction.Left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_Dirction.Right);
                        break;
                }
            }
            //线程修眠
            Thread.Sleep(500);

            food.Draw();

            snake.Move();
            
            map.Draw();
            snake.Draw();

            snake.ChekEat(food);

            if (snake.ChekEnd(map))
                Game.ChangeScene(E_SceneType.End);
        }
    }
}
