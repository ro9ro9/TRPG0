using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Scenes
{
    public class TownScene : Scene
    {

        public override void Render()
        {
            Console.WriteLine("폭풍에 휩쓸려 조난당했습니다.");
            Console.WriteLine("이곳은 무인도입니다.");
            Console.WriteLine("구조가 올 때까지 살아 남아야 합니다.");
            Console.WriteLine("무엇을 해야할까?");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 식수를 구하러 갑니다.");
            Console.WriteLine("2. 식량을 구하러 숲에 갑니다.");
            Console.WriteLine("3. 어슬렁거린다.");
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 눌러주세요.");
            Console.ReadKey(true);
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("식수를 구하러 갑니다.");
                    Console.ReadKey(true);
                    Game.LoadScene("Water");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("숲에 갑니다.");
                    Console.ReadKey(true);
                    Game.LoadScene("Forest");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("어슬렁거렸습니다");
                    Console.ReadKey(true);
                    Game.LoadScene("WalkScene");
                    break;
                default:
                    Console.WriteLine("아무것도 하지 않았습니다");
                    Console.WriteLine("체력을 5 잃었습니다.");
                    Console.WriteLine("현재 체력{0}", Game.Player.CurHP - 5);
                    break;
            }
        }
        public override void Next()
        {

        }
    }
}
