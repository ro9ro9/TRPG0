using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Scenes
{
    public class ForestScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("숲에 도착했습니다");
            Console.WriteLine("무엇을 하시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 채집을 한다");
            Console.WriteLine("2. 사냥하러 간다");
            Console.WriteLine("3. 땔감을 구한다");
            Console.WriteLine("4. 귀환합니다.");
        }

        public override void Next()
        {
           
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:

                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.D3:

                    break;
                case ConsoleKey.D4:
                    Game.LoadScene("Town");
                    break;
            }

        }

        public override void Wait()
        {
           
        }
    }
}
