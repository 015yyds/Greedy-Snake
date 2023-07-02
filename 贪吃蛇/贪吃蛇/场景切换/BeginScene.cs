using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    class BeginScene : BeginOrEndSceneBase
    {
        public BeginScene()
        {
            title = "贪吃蛇";
            select1 = "开始游戏";

        }
        public override void EnterJDoSomething()
        {
            if (index == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
