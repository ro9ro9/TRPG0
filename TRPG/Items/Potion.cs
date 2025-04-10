using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Items
{
    public class Potion : Item
    {
        public Potion()
        {
            string name = "약초";
            string description = "체력을 20 회복하는 약초입니다.";
        }
        public override void Use()
        {
            Console.WriteLine("체력을 20 회복합니다.");
            Game.Player.Heal(20);
        }
    }
}
