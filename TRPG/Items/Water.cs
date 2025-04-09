using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG.Items
{
    internal class Water : Item
    {
        public override void Use()
        {
            Game.Player.Heal(15);
        }
    }
}
