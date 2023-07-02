using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    abstract class BeginOrEndSceneBase:ISceneUpdate
    {
        protected string title,select1;
        protected int index = 0;

        public void Update()
        {
           //标题
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80/2-title.Length,5);
            Console.WriteLine(title);

            //选项
            Console.ForegroundColor = index==0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.SetCursorPosition(80 / 2 - select1.Length, 8);
            Console.WriteLine(select1);

            Console.ForegroundColor = index == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.SetCursorPosition(80 / 2 - 4, 10);
            Console.WriteLine("结束游戏");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    index=0; break;
                case ConsoleKey.S:
                    index=1; break;
                case ConsoleKey.J: 
                    EnterJDoSomething();
                    break;
            }
        }

        public abstract void EnterJDoSomething();
    }
}
