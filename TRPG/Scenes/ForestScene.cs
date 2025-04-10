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
        Random random = new Random();
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("채집을 시작합니다.");
                    Console.WriteLine("체력을 5 잃었습니다.");
                    Console.WriteLine("현재 체력{0}", Game.Player.CurHP - 5);
                    int randomValue = random.Next(0, 100);
                    if (randomValue <= 2)
                    {
                        Console.WriteLine("신기하게 생긴 버섯을 발견했습니다!");
                                                
                    }
                    else if (randomValue <= 40)
                    {
                        Console.WriteLine("약초를 구했습니다.");
                    }
                    else { Console.WriteLine("아무것도 발견하지 못했습니다..."); }
                    Console.WriteLine("거점으로 돌아갑니다.");
                    Game.LoadScene("Town");

                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("토끼를 사냥했습니다");
                    Console.WriteLine("토끼 고기를 얻었습니다.");
                    Console.WriteLine("체력을 10 잃었습니다.");
                    Console.WriteLine("현재 체력{0}", Game.Player.CurHP - 10);
                    Console.WriteLine("거점으로 돌아갑니다.");
                    Game.LoadScene("Town");

                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("땔감을 구했습니다.");
                    Console.WriteLine("체력을 5 잃었습니다.");
                    Console.WriteLine("현재 체력{0}", Game.Player.CurHP - 5);
                    Console.WriteLine("거점으로 돌아갑니다.");
                    Game.LoadScene("Town");

                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("거점으로 돌아갑니다.");
                    Game.LoadScene("Town");
                    break;
            }

        }

        public override void Wait()
        {
           
        }
    }
}
