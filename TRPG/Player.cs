namespace TRPG
{
    public class Player
    {
        private int curHP;
        public int CurHP
        {
            get { return curHP; }
            set
            {
                curHP = value;
                if (Game.Player.CurHP <= 0)
                {
                    Game.End();
                }
            }
        }

        private int maxHP;
        public int MaxHP { get { return maxHP; } }

        private Inventory inventory;
        public Inventory Inventory { get { return inventory; } }



        public Player()
        {
            inventory = new Inventory();
            maxHP = 100;
            curHP = maxHP;
        }


        public void Heal(int amount)
        {
            curHP += amount;
            if (curHP > maxHP)
            {
                curHP = maxHP;
            }
        }

        public void GetDamage(int damage)
        {
            curHP -= damage;
            if (curHP <= 0)
            {
                Game.End();
            }
        }

        public void Action(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }
        }
    }
}
