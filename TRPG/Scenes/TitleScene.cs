﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Scenes
{
    public class TitleScene : Scene
    {

        public override void Render()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("-      김씨 표류기       -");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        public override void Result()
        {

        }

        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");

            Console.WriteLine("3. 게임종료");
        }

        public override void Wait()
        {

        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.LoadScene("Town");
                    break;

            }
        }
    }
}
