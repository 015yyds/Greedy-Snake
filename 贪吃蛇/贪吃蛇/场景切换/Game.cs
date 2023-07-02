using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    internal class Game
    {
        public int w = 80;
        public int h = 20;

        static ISceneUpdate? nowScene;

        public Game() {
            Console.CursorVisible = false;
            Console.SetWindowSize(w,h);
            Console.SetBufferSize(w, h);

        }

        public static void Start()
        {
            ChangeScene(E_SceneType.Begin);
            while(true)
            {
                nowScene?.Update();
            }
        }

        public static void ChangeScene(E_SceneType type) {
            Console.Clear();

            switch(type)
            {
                case E_SceneType.Begin: 
                    nowScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    nowScene = new GameScene();
                    break;
                case E_SceneType.End:
                    nowScene = new EndScene();
                    break;
            }
        }
    }
    enum E_SceneType
    {
        Begin,
        Game,
        End
    }
}
