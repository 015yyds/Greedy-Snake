using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class EndScene:BeginOrEndSceneBase
    {
        public EndScene() {
            title = "游戏结束";
            select1 = "回到开始界面";

        }
        public override void EnterJDoSomething()
        {
            if (index == 0)
            {
                Game.ChangeScene(E_SceneType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
