using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Scenes
{
    public class WalkScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("무언가 발견했습니다!");
            Console.WriteLine();
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void Wait()
        {
            throw new NotImplementedException();
        }
        public override void Next()
        {
            throw new NotImplementedException();
        }
    }
}
