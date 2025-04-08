using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRPG.Scenes;

namespace TRPG
{
    public static class Game
    {
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static Player player;
        public static Player Player { get { return player; } }

        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Water", new WaterScene());
            sceneDic.Add("Forest", new ForestScene());
            sceneDic.Add("Walk", new WalkScene());

            curScene = sceneDic["Title"];

            player = new Player(); 
        }


        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
            End();
        }

        public static void LoadScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void End()
        {
            gameOver = true;
            Console.WriteLine("당신은 죽었습니다.");
            Console.WriteLine("타이틀로 돌아갑니다.");
            Console.ReadKey(true);
            Game.LoadScene("Title");
        }
    }
}