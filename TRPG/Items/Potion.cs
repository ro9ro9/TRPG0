using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Items
{
    internal class Potion : Item
    {
        public Potion()
        {
            string name = "약초";
        }
        public override void Use()
        {
            Console.WriteLine("체력을 20 회복합니다.");
            Game.Player.Heal(20);
        }
    }
}
