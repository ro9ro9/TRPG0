using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Items
{
    public class PoisonMushroom : Item
    {
        public PoisonMushroom()
        {
            string name = "독버섯";
        }
        public override void Use()
        {
            Console.WriteLine("체력을 30 잃었습니다.");
            Game.Player.Heal(-30);
        }
    }
}
