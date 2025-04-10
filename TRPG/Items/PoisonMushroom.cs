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
            string description = "신기하게 생긴 버섯, 먹으면 체력을 30 잃습니다.";
        }
        public override void Use()
        {
            Console.WriteLine("체력을 30 잃었습니다.");
            Game.Player.Heal(-30);
        }
    }
}
